using NewDesignedTranslator.Classes.TranslatorClasses.Mistakes;
using NewDesignedTranslator.Forms.Messages;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDesignedTranslator
{
    public partial class ChangeTranslationGUI : Form
    {
        private string wordToReplace;
        private string newTranlsation;
        public ChangeTranslationGUI(string originalWord,string translatedWord)
        {
            InitializeComponent();
            Initialize();

            newTranslationForWord.Text = translatedWord;
            
            foreach (var item in Globals.MisspelledWords)
            {
                if (originalWord.ToLower() == item._originalWord)
                    translatedWord = item.getRegString(originalWord);
            }

            wordToReplace = originalWord;

            newTranslationForWord.Text = translatedWord;
            originalWordLabel.Text = originalWord;
        }

        public string getNewTranslation()
        {
            return newTranslationForWord.Text;
        }

        //Appearance
        private void Initialize()
        {
            this.DoubleBuffered = true;
            Opacity = 0;

            Timer timer = new Timer();

            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) timer.Stop();
            });

            timer.Interval = 1;
            timer.Start();
        }

        private async void AddUNTtoDB()
        {
            await Task.Run(() =>
            {
                UNTDatabaseManager dBManager = new UNTDatabaseManager();
                dBManager.AddUNT(wordToReplace.ToLower(), newTranlsation.ToLower());
            });
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            newTranlsation = newTranslationForWord.Text;

            Globals.mistakeHandler.WriteToUNT(originalWordLabel.Text,newTranslationForWord.Text);
            Globals.Programm_uc.UpdateTranslation();

            AddUNTtoDB();

            this.Close();
        }

        public void ChangeText()
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            newTranslationForWord.Text = string.Empty;
        }

        private void ChangeTranslationGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
