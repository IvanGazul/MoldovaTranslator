using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDesignedTranslator.Forms.Messages
{
    public partial class TranslationManager : Form
    {
        public string translation = string.Empty;
        private string text = string.Empty;
        bool switched = false;
        public TranslationManager(string text,bool switched)
        {
            InitializeComponent();
            this.text = text;
            this.switched = switched;
        }

        private async void WaitForTranlsation()
        {
            if (!switched)
            {
                await Task.Run(() =>
                {
                    Globals.mistakeHandler.ReadUNT();
                    translation = Globals.translator.Translate(text);
                });
            }
            else
            {
                await Task.Run(() => 
                { 
                    translation = Globals.translator.TranslateFromMold(text);
                });
            }

            Globals.Programm_uc.translationLoading = false;

            this.Close();
        }

        private void TranlsationManager_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.ShowIcon = true;
            this.TopMost = true;
            
            WaitForTranlsation(); 
        }
    }
}
