using System.Collections.Generic;
using System;

namespace NewDesignedTranslator.Classes.TranslatorClasses
{
    public class Translator
    {
        //Переменные
        private string translation;

        public bool PMWInit = false;

        //Перебор всех букв в тексте и их перевод на кириллицу.
        public string Translate(string text)
        {
            //Создаем новый массив возможных ошибок
            Globals.rules.Initialize();

            //Массив возможно ошибочных слов создан
            PMWInit = true;

            //Инициализация Переменных
            text += "%%%%";

            //Обновляем перевод
            translation = string.Empty;
            int index = 0;

            foreach (char letter in text)
            {
                //Проверяем все правила для перевода
                Globals.rules.CheckRules(ref translation, index, text);

                index++;
            }

            return translation;
        }

        public string TranslateFromMold(string text)
        {
            return Globals.rules.TranslateFromMold(text);
        }

    }
}

