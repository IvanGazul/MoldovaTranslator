using NewDesignedTranslator.Classes.TranslatorClasses;
using NewDesignedTranslator.Forms.Messages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NewDesignedTranslator.UserControls
{
    public partial class Programm : UserControl
    {
        private bool swapLang = false;
        public bool translationLoading = false;

        //Методы для текст боксов
        public string getMoldText()
        {
            return moldTextBox.Text;
        }

        public string getRumText()
        {
            return rumTextBox.Text;
        }

        //Утсанавливает сохраненный текст из настроек
        public void setSavedText()
        {
            if (Globals.settings._swappedLang)
                swapLangButton.PerformClick();

            moldTextBox.Text = Globals.settings._savedTextMold;
            rumTextBox.Text = Globals.settings._savedTextRum;
        }

        //Обновить перевод
        public void UpdateTranslation()
        {
            int position = moldTextBox.SelectionStart;
            translateButton.PerformClick();

            moldTextBox.Select(position, 0);
            moldTextBox.ScrollToCaret();

            if (highlightMistakes)
                TextHighlighter.HighlightText(moldTextBox);
        }

        public Programm()
        {
            InitializeComponent();

            InitializeTimer();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        #region [------=Кнопки=------]

        //Кнопка хайлайта возможных ошибок
        bool highlightMistakes = false;
        public void HighlightMistakes()
        {
            highlightMistakes = !highlightMistakes;

            if (highlightMistakes)
                TextHighlighter.HighlightText(moldTextBox);

            else TextHighlighter.RemoveAllHighlights(moldTextBox);
        }

        private void highlightMistakesButton_Click(object sender, EventArgs e)
        {
            HighlightMistakes();
        }

        //Кнопка перевода текста

        private void translateButton_Click(object sender, EventArgs e)
        {
            if (translationLoading) { errorBox.Show("Перевод уже начался.."); return; }
                
            translationLoading = true;

            TranslationManager waitGUI;

            if (!swapLang)
                waitGUI = new TranslationManager(rumTextBox.Text, false);
            else waitGUI = new TranslationManager(rumTextBox.Text, true);

            waitGUI.ShowDialog();
            waitGUI.Dispose();

            moldTextBox.Text = waitGUI.translation;
        }

        //---------------------Молдавские кнопочки---------------------\\

        //Вставляем в молдавский бокс (ниче сибе)
        private void pasteMold_Click(object sender, EventArgs e)
        {
            //Копируем текст с буфера обмена
            string text = Clipboard.GetText();
            //Сплеплим 2 текста: 1 который был и новый.
            string newtext = moldTextBox.Text + text;
            moldTextBox.Text = newtext;
        }

        //Очистить молдавский бокс
        private void clearMold_Click(object sender, EventArgs e)
        {
            moldTextBox.Text = string.Empty;
        }

        //Скопировать молдавский бокс
        private void copyMold_Click(object sender, EventArgs e)
        {
            //Просто копируем текст в буфер обмена
            if (moldTextBox.Text != null & moldTextBox.Text != string.Empty)
            {
                string text = moldTextBox.Text ?? string.Empty;
                Clipboard.SetText(text);
            }
        }

        //---------------------Румынские кнопочки---------------------\\

        //Очищяем румыночку
        private void clearRum_Click(object sender, EventArgs e)
        {
            rumTextBox.Text = string.Empty;
        }

        //Вставляем в румыночку (ну это без подробностей)
        private void pasteRum_Click(object sender, EventArgs e)
        {
            //Вставляем текст с буфера обмена
            string text = Clipboard.GetText();
            //Слепим старый текст и новый в одно целое
            string newtext = rumTextBox.Text + text;
            rumTextBox.Text = newtext;
        }

        //Копируем румынский боксич (битбоксич)
        private void copyRum_Click(object sender, EventArgs e)
        {
            //Просто копируем текст в буфер обмена
            if (rumTextBox.Text != null & rumTextBox.Text != string.Empty)
            {
                string text = rumTextBox.Text ?? string.Empty;
                Clipboard.SetText(text);
            }
        }
        #endregion

        #region [---=Кнопка свапа=---]

        private void swapTextFromTextBoxes(IGTextBox t1, IGTextBox t2)
        {
            string t1text = t1.Text;
            t1.Text = t2.Text;
            t2.Text = t1text;
        }

        string moldLabelText = string.Empty;
        string rumLabelText = string.Empty;
        int seconds = 0,k = 0;
        bool working = false;
        
        private void InitializeTimer()
        {
            labelSwapTimer.Enabled = true;
            labelSwapTimer.Interval = 35;
            
            labelSwapTimer.Tick += LabelSwapTimer_Tick;
        }

        private void doSwapLabelAnimation()
        {
            working = true;
            if (swapLang)
            {
                moldLabelText = "Румынский";
                rumLabelText = "Молдавский";
            }
            else
            {
                moldLabelText = "Молдавский";
                rumLabelText = "Румынский";
            }
            
            seconds = 0;
            k = 0;

            labelSwapTimer.Start();
        }

        private void LabelSwapTimer_Tick(object sender, EventArgs e)
        {
            if (!working)
                return;

            if (seconds <= 9)
            {
                if (moldLabel.Text.Length > 0)
                    moldLabel.Text = moldLabel.Text.Remove(moldLabel.Text.Length - 1);
                if (rumLabel.Text.Length > 0)
                    rumLabel.Text = rumLabel.Text.Remove(rumLabel.Text.Length - 1);
            }

            else
            {
                if (k == 10)
                {
                    labelSwapTimer.Stop();
                    working = false;
                    return;
                }

                if (k == 9 & moldLabelText.Length == 10)
                    moldLabel.Text += moldLabelText[k];
                
                else if (k == 9 & rumLabelText.Length == 10)
                    rumLabel.Text += rumLabelText[k];
                
                else
                {
                    moldLabel.Text += moldLabelText[k];
                    rumLabel.Text += rumLabelText[k];
                }

                k++;
            }

            seconds++;
        }

        private void swapLangButton_Click(object sender, EventArgs e)
        {
            swapLang = !swapLang;
            Globals.settings._swappedLang = swapLang;

            if (working)
                return;

            rumTextBox.ForeColor = Color.White;
            moldTextBox.ForeColor = Color.White;

            if(highlightMistakes)
                HighlightMistakes();

            highlightMistakesButton.Enabled = !highlightMistakesButton.Enabled;

            swapTextFromTextBoxes(rumTextBox,moldTextBox);
            
            doSwapLabelAnimation();
        }
        #endregion

        #region [--=Контекстные меню=--]

        private void изменитьПереводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTranslationGUI CreateUNTGui;

            if (!Globals.translator.PMWInit)
                return;

            foreach (var item in Globals.rules.potentialMisspelledWords)
            {
                if (item.CheckPosition(moldTextBox.SelectionStart))
                {
                    CreateUNTGui = new ChangeTranslationGUI(item._originalPMW, item._PMW);
                    CreateUNTGui.ShowDialog();
                    item._PMW = CreateUNTGui.getNewTranslation();
                }
            }

        }

        private void показатьIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"M {moldTextBox.SelectionStart} | R {rumTextBox.SelectionStart}");
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(moldTextBox.SelectedText))
            {
                Clipboard.SetText(moldTextBox.SelectedText);
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                moldTextBox.Text
                    += Clipboard.GetText(TextDataFormat.Text).ToString();

                moldTextBox.SelectionStart = moldTextBox.Text.Length;
                moldTextBox.ScrollToCaret();
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moldTextBox.Cut();
        }

        //Копировать румын. меню
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(rumTextBox.SelectedText))
            {
                Clipboard.SetText(rumTextBox.SelectedText);
            }
        }

        //Вставить румын. меню
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                rumTextBox.Text
                    += Clipboard.GetText(TextDataFormat.Text).ToString();

                rumTextBox.SelectionStart = rumTextBox.Text.Length;
                rumTextBox.ScrollToCaret();

            }
        }

        //Вырезать румын. меню
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            rumTextBox.Cut();
        }

        #endregion

        #region [-------=Ивенты=-------]
        private void moldTextBox__TextChanged(object sender, EventArgs e)
        {
            moldTextLengthLabel.Text = moldTextBox.Text.Length.ToString();
        }

        private void rumTextBox__TextChanged(object sender, EventArgs e)
        {
            rumTextLengthLabel.Text = rumTextBox.Text.Length.ToString();
        }
        #endregion

    }
}
