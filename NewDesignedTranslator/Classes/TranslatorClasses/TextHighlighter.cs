using NewDesignedTranslator.UserControls;
using System;
using System.Drawing;

namespace NewDesignedTranslator.Classes.TranslatorClasses
{
    public class TextHighlighter
    {
        private static string[] wordsToHighlight = { "иа","ия", "еа", "я", "ие", "иу", "ю", "йо", "ио", "кс" };

        public static void HighlightText(IGTextBox textBox)
        {
            // Сохраняем текущее выделение пользователя
            int originalSelectionStart = textBox.SelectionStart;
            int originalSelectionLength = textBox.SelectionLength;

            foreach (var wordToHighlight in wordsToHighlight)
            {
                for (int index = 0; index < textBox.Text.Length;)
                {
                    // Находим индекс ближайшего дифтонга
                    index = textBox.Text.IndexOf(wordToHighlight, index, StringComparison.OrdinalIgnoreCase);

                    // Если мы нашли - выделяем
                    if (index != -1)
                    {
                        // Устанавливаем selection start и длинну чтобы выделить слово
                        textBox.SelectionStart = index;
                        textBox.SelectionLength = wordToHighlight.Length;

                        // Меняем цвет фона слова
                        textBox.SelectionBackColor = Color.Red;

                        // Индекс повышаем
                        index += wordToHighlight.Length;
                    }
                    else
                    {
                        //Не нашли ничего,выходим
                        break;
                    }
                }
            }

            // Восстанавливаем выделение пользователя
            textBox.SelectionStart = originalSelectionStart;
            textBox.SelectionLength = originalSelectionLength;
        }

        public static void RemoveAllHighlights(IGTextBox textBox)
        {
            // Сохраняем текущее выделение пользователя
            int originalSelectionStart = textBox.SelectionStart;
            int originalSelectionLength = textBox.SelectionLength;

            //Выделить весь текст
            textBox.SelectAll();

            // Установить цвет
            textBox.SelectionBackColor = Color.White;

            // Восстанавливаем выделение пользователя
            textBox.SelectionStart = originalSelectionStart;
            textBox.SelectionLength = originalSelectionLength;
        }
    }
}
