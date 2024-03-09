namespace NewDesignedTranslator.Classes.TranslatorClasses.Mistakes
{
    public class MisspelledWord
    {
        public string _originalWord { get; set; }
        public string _wordTranslation { get; set; }
        public int _position { get; set; }

        public MisspelledWord(string originalWord, string wordTranslation, int position) 
        { 
            _originalWord = originalWord;
            _wordTranslation = wordTranslation;
            _position = position;
        }

        //Вернуть перевод слова согласно регистру
        public string getRegString(string word)
        {
            string regTranslation = string.Empty;
            
            //Начинается с заглавной,возвращаем перевод с заглавной буквой
            if (char.IsUpper(word[0]))
                regTranslation += char.ToUpper(_wordTranslation[0]) + _wordTranslation.Remove(0,1);

            //Слово в нижнем регистре,так и возвращаем
            else regTranslation = _wordTranslation;

            return regTranslation;
        }

        //Являюсь ли я этим словом?
        public bool checkIfInUNT(string originalWord)
        {
            //Да,являюсь
            if (originalWord.ToLower() == _originalWord)
                return true;

            //Нет
            return false;
        }

    }
}
