using NewDesignedTranslator.Classes.TranslatorClasses.Mistakes;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NewDesignedTranslator.Classes.TranslatorClasses
{
    //По каким правилам идет перевод.
    public class TranslatorRules
    {
        #region [-------=Переменные=-------]

        //Словари 

        //Словарь для Молдавского языка
        private static Dictionary<string, string> moldova = new Dictionary<string, string>()
            {
                {"a", "а"},{"g", "г"},{"e", "е"},{"n", "н"},{"x", "кс"},{"m", "м"},{"o", "о"},{"l", "л"},{"ă", "э"},{"ț", "ц"},
                {"b", "б"},{"c", "к"},{"p", "п"},{"f", "ф"},{"z", "з"},{"u", "у"},{"i", "и"},{"t", "т"},{"ţ", "ц"},
                {"v", "в"},{"d", "д"},{"r", "р"},{"j", "ж"},{"k", "к"},{"s", "с"},{"h", "х"},{"ș", "ш"},{"ş", "ш"},{"â", "ы"},
                {"î", "ы"},{"q","к"},{"w","в"},{"y","и"},

                {"A", "А"},{"G", "Г"},{"E", "Е"},{"N", "Н"},{"X", "Кс"},{"M", "М"},{"O", "О"},{"L", "Л"},{"Ă", "Э"},{"Ț", "Ц"},
                {"B", "Б"},{"C", "К"},{"P", "П"},{"F", "Ф"},{"Z", "З"},{"U", "У"},{"I", "И"},{"T", "Т"},{"Ţ", "Ц"},
                {"V", "В"},{"D", "Д"},{"R", "Р"},{"J", "Ж"},{"K", "К"},{"S", "С"},{"H", "Х"},{"Ș", "Ш"},{"Ş", "Ш"},{"Â", "Ы"},
                {"Î", "Ы"},{"Q","К"},{"W","В"},{"Y","И"}
            };

        //Словарь для Румынского языка
        private Dictionary<string, string> moldovainrumin = new Dictionary<string, string>()
            {
                {"а", "a"},{"г", "g"},{"е", "e"},{"н", "n"},{"м", "m"},{"о", "o"},{"л", "l"},{"э", "ă"},{"ц", "ț"},
                {"б", "b"},{"к", "c"},{"п", "p"},{"ф", "f"},{"з", "z"},{"у", "u"},{"и", "i"},{"т", "t"},
                {"в", "v"},{"д", "d"},{"р", "r"},{"ж", "j"},{"с", "s"},{"х", "h"},{"ш", "ș"},{"ч","c"},
                {"ы", "â"},

                {"А", "A"},{"Г", "G"},{"Е", "E"},{"Н", "N"},{"М", "M"},{"О", "O"},{"Л", "L"},{"Э", "Ă"},{"Ц", "Ț"},
                {"Б", "B"},{"К", "C"},{"П", "P"},{"Ф", "F"},{"З", "Z"},{"У", "U"},{"И", "I"},{"Т", "T"},
                {"В", "V"},{"Д", "D"},{"Р", "R"},{"Ж", "J"},{"С", "S"},{"Х", "H"},{"Ш", "Ș"},{"Ч","C"},
                {"Ы", "Â"}
            };

        #region [-=Коллекции для перевода=-]

        //Гласные буквы хули не понятного
        public List<char> glasnie = new List<char>
            {'a', 'ă', 'â', 'e', 'i', 'î', 'o', 'u','A', 'Ă', 'Â', 'E', 'I', 'Î','O', 'U', 'ă'};

        //Согласные буквы
        public List<char> soglasnie = new List<char>
            {'b', 'c', 'd', 'f', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z', 'y','ğ','ș','ș','ş','ţ','ț','ţ','g',
             'B', 'C', 'D', 'F', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z', 'Y', 'Ș', 'Ş', 'Ț', 'Ţ', 'G'};

        //Пунктуация
        public List<char> punctuacia = new List<char>
            {' ', '-', '.', '–', ',', '„', '”', '’', '‘', ':',  ';', '(',  ')', '…', '!', '?', '&', '«', '»'};

        //После ia и тд крч впадлу коментить код
        
        //Коллекции для дифтонгов
        public List<char> dupaEa = new List<char> { 'ș', 'ș', 'j', 'Ș', 'Ş', 'J', 'd', 'D' };

        public List<char> dupaIa = new List<char> { 'b', 'p', 'm', 'f', 'v', 'g', 'B', 'P', 'M', 'F', 'V', 'G' };
        #endregion


        #region [---=Химические элменты=---]

        //Элементы с двумя чарами
        public List<string> elementsWithTwoChar = new List<string> { "He","Li","Be","Ne","Na","Mg","Al","Si","Cl","Ar","Ca","Sc","Ti","Cr","Mn",
            "Fe","Co","Ni","Cu","Zn","Ga","Ge","As","Se","Br","Kr","Rb","Sr","Zr","Nb","Mo","Tc","Ru","Rh","Pd","Ag","Cd","In","Sn","Sb","Te",
            "Xe","Cs","Ba","La","Ce","Pr","Nd","Pm","Sm","Eu","Gd","Tb","Dy","Ho","Er","Tm","Yb","Lu","Hf","Ta","Re","Os","Ir","Pt","Au","Hg",
            "Pb","Tl","Bi","Po","At","Rn","Fr","Ra","Ac","Th","Pa","Np","Pu","Am","Cm","Bk","Cf","Es","Fm","Md","No","Lr","Rf","Db","Sg","Bh",
            "Hs","Mt","Ds","Rg","Cn","Nh","Fl","Mc","Lv","Ts","Og"};

        //Элементы с одним чарам
        public List<char> elementsWithOneChar = new List<char> { 'H', 'B', 'C', 'N', 'O', 'F', 'P', 'S', 'K', 'V', 'Y', 'I', 'U' };

        #endregion

        #region [----------=Числа=---------]

        //Числа
        public List<char> numbers = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            '+', '-', '-', '→', '=',
            '₀','₁','₂', '₃', '₄', '₅','₆','₇','₈','₉','ₙ', 'ₗ' ,'₍', '₎',
            '²', '³', '¹', '⁴', '⁵', '⁶', '⁷', '⁸', '⁹', '⁰', 'ⁿ' ,'ⁱ', '⁽', '⁾' };

        //Римские числа
        public List<char> RomeNumbers = new List<char> { 'X', 'V', 'I', 'L', 'C', 'D', 'M' };

        #endregion

        #region [----=Обработчик ошибок=----]

        //Массив ошибочных слов
        public List<PotentialMisspelledWord> potentialMisspelledWords;

        //Возможные ошибки
        public List<string> potentialMistakes = new List<string> { "ea", "ia", "ie", "iu", "io" };

        //Позиция слова
        public int wordStartIndex = 0;
        public int wordEndIndex = -1;

        //Нужно ли скипнуть букву
        private bool SkipNextLetter = false;

        //Начало слова или конец?
        private bool mistakenWord = false;
        private bool wordEnd = false;

        //Текущее слово
        private string currentWord = string.Empty;
        private string originalCurrentWord = string.Empty;

        //Сколько символов надо скипнуть
        private int skipChars = 0;

        #endregion

        #endregion

        #region [---------=Методы=---------]

        //Методы
        #region [--------=Обработчик ошибок=--------]

        //Инициализация переменных
        public void Initialize()
        {
            potentialMisspelledWords = new List<PotentialMisspelledWord>();
            wordStartIndex = 0;
            wordEndIndex = -1;

            currentWord = string.Empty;
            originalCurrentWord = string.Empty;
        }

        //Обновляет данные для Обработчика ошибок
        private void UpdateMMData(char letter, char next, ref string translation)
        {
            //Является ли слово с возможной ошибкой
            if (!mistakenWord)
                mistakenWord = Globals.mistakeHandler.CheckForMistake(letter, next);

            if (!wordEnd)
            {
                currentWord += translation[translation.Length - 1];
                originalCurrentWord += letter;
            }

            //Оригинал слова и его перевод
            

            else if (wordEnd)
            {
                //Вычисляем индекс конца слова
                wordEndIndex = translation.Length - 1;

                if (mistakenWord)
                {
                    originalCurrentWord = Regex.Replace(originalCurrentWord, @"\n", "");
                    MisspelledWord mw = Globals.mistakeHandler.CheckIfMW(originalCurrentWord);

                    if (mw != null)
                    {
                        translation = translation.Remove((translation.Length - 1) - currentWord.Length);
                        translation += mw.getRegString(originalCurrentWord) + letter;
                    }

                    //Является ли слово ошибочным
                    mistakenWord = false;

                    //Добавляем в массив новое слово с возможной ошибкой
                    potentialMisspelledWords.Add(
                    new PotentialMisspelledWord(
                    currentWord, originalCurrentWord,
                    wordStartIndex, wordEndIndex
                    ));
                }
                
                //Началом нового слова становится конец предыдущего +1
                wordStartIndex = wordEndIndex;

                //Очищаем слова
                currentWord = string.Empty;
                originalCurrentWord = string.Empty;
            }
        }

        #endregion

        #region [-------=Химический элемент=--------]

        //Химический ли это элемент?
        private bool CheckIfElement(string text,int index, char letter, char nextLetter)
        {
            if (index == 0) return false;

            char next2Letter = text[index + 2];
            char next3Letter = text[index + 3];

            char prevLetter = text[index - 1];

            bool twoCharElement = false;
            bool oneCharElement = false;

            //Являются ли они элементами?
            if (elementsWithOneChar.Contains(letter))
                oneCharElement = true;

            if (elementsWithTwoChar.Contains(letter.ToString() + nextLetter.ToString()))
                twoCharElement = true;

            if (!twoCharElement & !oneCharElement)
                return false;

            //Элемент просто сидит между пробелами или пунктуацией

            //Для 2элемента
            if (punctuacia.Contains(prevLetter) & punctuacia.Contains(next2Letter))
                return true;

            //Для 1элемента
            if (punctuacia.Contains(prevLetter) & punctuacia.Contains(nextLetter))
                return true;

            //Впереди есть другой элэмент или формула
            if (numbers.Contains(next2Letter) | numbers.Contains(next3Letter))
                return true;

            //Сзади число
            if (numbers.Contains(prevLetter))
                return true;

            //Сзади 1элемент
            if (elementsWithOneChar.Contains(prevLetter))
                return true;

            //Сзади 2элемент
            if (index - 2 >= 0 && elementsWithTwoChar.Contains(text[index - 2].ToString() + prevLetter))
                return true;

            //Впереди число
            if (numbers.Contains(nextLetter))
                return true;

            //Впереди 1элемент
            if (elementsWithOneChar.Contains(next2Letter))
                return true;

            //Впереди 2элемент
            if (elementsWithTwoChar.Contains(next2Letter.ToString() + next3Letter.ToString()))
                return true;
            
            //prevWordIsChemicalElement = true;
            return false;
        }

        private int GetLengthOfElement(char letter, char nextLetter)
        {
            if (elementsWithTwoChar.Contains(letter.ToString() + nextLetter))
                return 2;

            return 1;
        }

        //Проверка на химический элемент
        private void DetectChemicalElements(string text, int index, char letter, char nextLetter)
        {
            if (!CheckIfElement(text, index, letter, nextLetter))
                return;

            skipChars = GetLengthOfElement(letter, nextLetter);
        }

        #endregion

        #region [-------------=Буквы=---------------]
        //Проверка регистра буквы
        private void AppendLetter(ref string translation, char letter)
        {
            //Если буква верхнего регистра то в перевод суем большую букву
            if (char.IsUpper(letter))
                translation += moldova[letter.ToString().ToUpper()];
            //Иначе мелкую
            else
                translation += moldova[letter.ToString()];
        }

        //Создание правила для комбинации буквы например: Sh = Ш
        private void AppendTwoLetters(ref string translation, char letter, char zamena)
        {
            //Если буква замены большая ставим
            if (char.IsUpper(letter))
                translation += zamena.ToString().ToUpper();
            else
                translation += zamena;

            SkipNextLetter = true;
        }

        private void ChangeLetterTranslation(ref string translation, char letter, char zamena)
        {
            //Если буква замены большая ставим
            if (char.IsUpper(letter))
                translation += zamena.ToString().ToUpper();
            else
                translation += zamena;
        }

        #endregion

        #endregion

        public void CheckRules(ref string translation, int index, string text)
        {
            //Текст кончился,текст сделан на +4 символа больше так как если этого не будет то
            //проверка на 4 символа вперед будет в конце проверять
            //на 4 символа вперед он выйдет за границы,а так нет.
            if (index + 1 > text.Length - 4)
                return;

            //Переменные
            char letter = text[index];
            char nextLetter = text[index + 1];

            //Предыдущий символ
            char prevLetter = ' ';
            if(index - 1 >= 0) prevLetter = text[index - 1];

            //CheckIfElement(letter, next,ref translation);

            //Конец слова?
            if (punctuacia.Contains(letter))
                wordEnd = true;
            else wordEnd = false;

            //Нужно пропустить данный символ и не переводить его,так как о нем уже позаботились
            if (SkipNextLetter == true)
            {
                SkipNextLetter = !SkipNextLetter;
                return;
            }

            //Химические элементы
            DetectChemicalElements(text, index, letter, nextLetter);
            if (skipChars-- > 0)
            {
                translation += letter;
                return;
            }

            #region [----=Римские Числа=----]
            if (RomeNumbers.Contains(letter))
            {
                if (RomeNumbers.Contains(nextLetter) | (index != 0 && RomeNumbers.Contains(prevLetter) ) )
                    translation += letter;

                else if(index != 0 && punctuacia.Contains(nextLetter) & punctuacia.Contains(prevLetter) )
                    translation += letter;

                else AppendLetter(ref translation, letter);
            }
            #endregion

            #region [------=Буквы Ч;К=------]
            else if (letter == 'c' || letter == 'C')
            {
                //Ci в конце слова = Ч
                if (letter == 'c' & nextLetter == 'i' & (punctuacia.Contains(text[index + 2]) || glasnie.Contains(text[index + 2])))
                    AppendTwoLetters(ref translation, letter, 'ч');

                //После i и e пишем Ч
                else if (letter == 'c' & nextLetter == 'i'
                      || nextLetter == 'e' | letter == 'C'
                      & nextLetter == 'i' || nextLetter == 'e')
                    ChangeLetterTranslation(ref translation, letter, 'ч');

                //Ch = к
                else if (letter == 'c' & nextLetter == 'h'
                     || letter == 'C' & nextLetter == 'h')
                    AppendTwoLetters(ref translation, letter, 'к');

                //В других случаях пишем К
                else AppendLetter(ref translation, letter);
            }
            #endregion

            #region [------=Дифтонги=-------]
            //Все правила связанные с буквой i (ci chi ia ie iu ь й)
            else if (index != 0 & (letter == 'i' || letter == 'I'))
            {
                //Дифтонг ia
                if (nextLetter == 'a')
                {
                    //Ия
                    if (punctuacia.Contains(text[index + 2])) { 
                        AppendTwoLetters(ref translation, letter, 'и');
                        currentWord +="и" ; originalCurrentWord += nextLetter; 
                        translation += 'я'; }

                    //Я
                    else if (
                             punctuacia.Contains(prevLetter) |
                             glasnie.Contains(prevLetter) |
                             dupaIa.Contains(prevLetter) |
                             punctuacia.Contains(prevLetter)
                             & soglasnie.Contains(prevLetter))
                        AppendTwoLetters(ref translation, letter, 'я');

                    //Ья
                    //else if (dupaia.Contains(text[index - 1])) { RegForTwo(ref translation, letter, 'ь'); translation += 'я'; }

                    //Иначе обычная иа
                    else AppendLetter(ref translation, letter);
                }

                //in - ын
                else if (nextLetter == 'n' & punctuacia.Contains(prevLetter) & punctuacia.Contains(text[index + 2]))
                    translation += "ы";

                //Дифтонг ie
                else if (nextLetter == 'e')
                {
                    //Ие
                    if (punctuacia.Contains(text[index + 2])) 
                        AppendLetter(ref translation, letter);                    
                    
                    //Е
                    else if (punctuacia.Contains(prevLetter) || 
                             glasnie.Contains(prevLetter) || 
                             punctuacia.Contains(prevLetter) & 
                             soglasnie.Contains(prevLetter))
                        AppendTwoLetters(ref translation, letter, 'е');

                    //Ье
                    //else if (dupaia.Contains(text[index - 1])) { RegForTwo(ref translation, letter, 'ь'); translation += 'е'; }

                    //Иначе обычная ие
                    else AppendLetter(ref translation, letter);
                }

                //Дифтонг iu
                else if (nextLetter == 'u')
                {
                    //Иу
                    if (punctuacia.Contains(text[index + 2]))
                        AppendLetter(ref translation, letter);
                    
                    //Ю
                    else if (punctuacia.Contains(prevLetter) || 
                             glasnie.Contains(prevLetter) || 
                             punctuacia.Contains(prevLetter) & 
                             soglasnie.Contains(prevLetter)) 
                        AppendTwoLetters(ref translation, letter, 'ю');
                    
                    //Ью
                    //else if (dupaia.Contains(text[index - 1])) { RegForTwo(ref translation, letter, 'ь'); translation += 'ю'; }
                    
                    //Иначе обычная иу
                    else AppendLetter(ref translation, letter);
                }

                //Дифтонг io
                else if (nextLetter == 'o')
                {
                    //Ио
                    if (punctuacia.Contains(text[index + 2]))
                        AppendLetter(ref translation, letter);

                    //йо
                    else if (punctuacia.Contains(prevLetter) || 
                             glasnie.Contains(prevLetter) || 
                             punctuacia.Contains(prevLetter) & 
                             soglasnie.Contains(prevLetter)) 
                        ChangeLetterTranslation(ref translation, letter, 'й');

                    //Ьо
                    //else if (dupaia.Contains(text[index - 1])) { RegForTwo(ref translation, letter, 'ь'); translation += 'о'; }

                    //Иначе обычная ио
                    else AppendLetter(ref translation, letter);
                }

                //После согласной в конце слова i = ь
                else if (index >= 2 && punctuacia.Contains(nextLetter) & !punctuacia.Contains(text[index - 2]) & soglasnie.Contains(prevLetter) & prevLetter != 'i' || nextLetter == '-' & text[index + 2] != 'i' || nextLetter == '–' & text[index + 2] != 'i')
                    ChangeLetterTranslation(ref translation, letter, 'ь');

                else if (index >= 2 && punctuacia.Contains(text[index - 2]) & glasnie.Contains(prevLetter) & punctuacia.Contains(nextLetter) & glasnie.Contains(prevLetter))
                    ChangeLetterTranslation(ref translation, letter, 'й');

                //i после гласной в конце слова = й и когда mi-i = ми-й
                else if (index >= 2 && punctuacia.Contains(nextLetter) & !punctuacia.Contains(text[index - 2]) & glasnie.Contains(prevLetter) & nextLetter != 'i' || letter == 'i' & prevLetter == '-' || prevLetter == '–')
                    ChangeLetterTranslation(ref translation, letter, 'й');

                else { translation += moldova[letter.ToString()]; }
            }
            #endregion

            #region [-------=Буква Е=-------]
            else if (index != 0 & (letter == 'e' || letter == 'E'))
            {
                //Если это дифтонг
                if (nextLetter == 'a')
                {
                    if (punctuacia.Contains(text[index + 2]) | dupaEa.Contains(prevLetter))
                        AppendTwoLetters(ref translation, letter, 'я');

                    else 
                        AppendLetter(ref translation, letter);
                }

                //Иначе обычная e
                else AppendLetter( ref translation, letter);
            }
            #endregion

            #region [-------=Буква У=-------]
            else if (index != 0 & letter == 'u')
            {
                //sunt = сынт
                if (prevLetter == 's' & nextLetter == 'n' & text[index + 2] == 't')
                    translation += "ы";

                //Не дифтонг = обычная буква у
                else translation += 'у';
            }
            #endregion

            #region [-------=Буква С=-------]
            else if (letter == 's' || letter == 'S')
            {
                //Sh = ш
                if (nextLetter == 'h')
                    AppendTwoLetters(ref translation, letter, 'ш');
                
                //Si - Ши
                else if (nextLetter == 'i')
                {
                    if (punctuacia.Contains(prevLetter) & punctuacia.Contains(text[index + 2]) & punctuacia.Contains(prevLetter))
                        ChangeLetterTranslation(ref translation, letter, 'ш');

                    else AppendLetter(ref translation, letter);
                }
                
                //Иначе обычная Ш в зависимости от регистра
                else AppendLetter(ref translation, letter);
            }
            #endregion

            #region [------=Буква Г;Ж=------]
            else if ((letter == 'g' || letter == 'G') | (letter == 'j' || letter == 'J'))
            {
                //После e и i = ӂ,но проверяем не дифтонг ли это еа
                if (nextLetter == 'e' || nextLetter == 'i' & text[index + 2] != 'a' & nextLetter != 'e') 
                    ChangeLetterTranslation(ref translation, letter, 'ӂ');

                //Gh = г
                else if (letter == 'g' & nextLetter == 'h' || letter == 'G' & nextLetter == 'h')
                    AppendTwoLetters(ref translation, letter, 'г');

                //Иначе обыная г
                else AppendLetter(ref translation, letter);
            }
            #endregion

            #region [-------=Буква К=-------]
            else if (letter == 'k' & nextLetter == 'h')
            {
                AppendTwoLetters(ref translation, letter, 'к');
            }
            #endregion

            #region [-------=Буква Т=-------]
            else if (letter == 't' & nextLetter == 's' & punctuacia.Contains(text[index + 2]))
            {
                AppendTwoLetters(ref translation, letter, 'ц');
            }
            #endregion

            //Обычная замена букв
            else
            {
                try { translation += moldova[letter.ToString()]; }
                catch (KeyNotFoundException) { translation += letter; }
            }

            //Генерация ошибочных слов
            #region [---=Обработчик ошибок=---]
            UpdateMMData(letter, nextLetter, ref translation);
            #endregion

        }
        
        //Demo - он сделан для галочки,дорабатывайте сами xD
        public string TranslateFromMold(string text)
        {
            bool skipnextletter = false;
            //Перевод
            string translation = "";

            //Перебор символов из текста и их перевод на буквы из словаря.
            int index = 0;
            foreach (var letter in text)
            {
                if (skipnextletter)
                {
                    skipnextletter = !skipnextletter;
                    continue;
                }

                //Следующая буква
                char next = ' ';

                if(index + 1 < text.Length)
                    next = text[index + 1];

                if (letter == 'й' || letter == 'й')
                {
                    if (char.IsUpper(Convert.ToChar(letter)))
                        translation += "I";
                    //Иначе мелкую
                    else
                        translation += "i";
                }

                else if (letter == 'ӂ' || letter == 'Ӂ')
                {
                    if (char.IsUpper(Convert.ToChar(letter)))
                        translation += "G";
                    //Иначе мелкую
                    else
                        translation += "g";
                }

                else if (letter == 'к' & next == 'с' || letter == 'К' & next == 'с')
                {
                    if (char.IsUpper(Convert.ToChar(letter)))
                        translation += "X";
                    //Иначе мелкую
                    else
                        translation += "x";

                    skipnextletter = true;
                }

                //Перевод ы на î
                else if (index != 0 & letter == 'ы' || index != 0 & letter == 'Ы')
                {
                    if (punctuacia.Contains(text[index - 1]) || punctuacia.Contains(text[index + 1]))
                    {
                        //Большую
                        if (char.IsUpper(Convert.ToChar(letter)))
                            translation += "Î";
                        //Иначе мелкую
                        else
                            translation += "î";
                    }
                    else { translation += moldovainrumin[letter.ToString()]; }
                }

                //Мягкий знак
                else if (letter == 'ь')
                {
                    translation += "i";
                }

                //Я буква
                else if (letter == 'я' || letter == 'Я')
                {
                    if (char.IsUpper(Convert.ToChar(letter)))
                        translation += "Ia";
                    //Иначе мелкую
                    else
                        translation += "ia";
                }

                //Буква Ю
                else if (letter == 'ю' || letter == 'Ю')
                {
                    if (char.IsUpper(Convert.ToChar(letter)))
                        translation += "Iu";
                    //Иначе мелкую
                    else
                        translation += "iu";
                }


                else if (letter == 'ч') { translation += 'c'; }

                /*=====================*/


                //Обычная замена букв
                else
                {
                    try { translation += moldovainrumin[letter.ToString()]; }
                    catch (KeyNotFoundException) { translation += letter; }
                }
                //Индекс для каждой буквы мне впадлу делать цикл

                index++;
            }

            return translation;
        }
    }
}

