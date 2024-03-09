using System.IO;

namespace NewDesignedTranslator.Classes.TranslatorClasses.Mistakes
{
    public class MistakeHandler
    {
        //Потенциально ошибочные слова

        //Проверяем на наличие дифтонга 2 буквы
        public bool CheckForMistake(char letter, char next)
        {
            if (Globals.rules.potentialMistakes.Contains(letter.ToString() + next.ToString()))
                return true;

            return false;
        }

        //UNT - UserNewTranslations (создает файл UNT если его нету)
        private void CreateUNT() 
        {
            FileStream stream = null;
            try
            {
                stream = new FileStream(Globals.UNTFile, FileMode.CreateNew);
            }
            catch
            {
                
            }
            finally
            {
                if(stream != null)
                    stream.Close();
            }
        }

        //Изменяет текст на нужной строке в UNT
        private void UNTChangeLine(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        //Проверяем нету ли слова в UNT,если есть,меняем перевод на новый
        private bool CheckIfUNTExists(string originalWord, string newTranslation)
        {
            foreach (var item in Globals.MisspelledWords)
            {
                if (item.checkIfInUNT(originalWord))
                {
                    item._wordTranslation = newTranslation.ToLower();
                    UNTChangeLine($"{originalWord.ToLower()}-{newTranslation.ToLower()}", 
                        Globals.UNTFile, item._position + 1);
                    return true;
                }
            }
            return false;
        }

        //Записываем в файл UNT новвую пару слов
        public async void WriteToUNT(string originalWord, string newTranslation)
        {
            //Если пара уже существует,редактируем её
            if (CheckIfUNTExists(originalWord, newTranslation))
                return;

            // добавление в файл
            using (StreamWriter writer = new StreamWriter(Globals.UNTFile, true))
            {
                string message = originalWord.ToLower() + "-" + newTranslation.ToLower();
                await writer.WriteLineAsync(message);
            }
        }

        //Ошибочные слова

        //Проверить если это ошибочное слово уже существует и вернуть его
        //чтобы добавить UNT в перевод
        public MisspelledWord CheckIfMW(string word)
        {
            foreach (var item in Globals.MisspelledWords)
            {
                if (item.checkIfInUNT(word))
                    return item;
            }

            return null;
        }
        
        //Инициализирует массив ошибочных слов
        public void ReadUNT()
        {
            Globals.MisspelledWords = new System.Collections.Generic.List<MisspelledWord>();

            //Убеждаемся что файл существует
            CreateUNT();

            using (StreamReader reader = new StreamReader(Globals.UNTFile))
            {
                string line = null;
                string[] pair = new string[2];

                int lineNumber = 0;
                
                while ((line = reader.ReadLine()) != null)
                {
                    pair = line.Split('-');
                    
                    Globals.MisspelledWords.Add(new MisspelledWord(pair[0], pair[1], lineNumber));

                    lineNumber++;
                }
            }
        }
    
    }
}
