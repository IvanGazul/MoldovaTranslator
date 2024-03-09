using NewDesignedTranslator.Forms.Messages.Information;
using System;
using System.Media;
using System.Windows.Forms;

namespace NewDesignedTranslator.UserControls
{
    public partial class UC_info : UserControl
    {
        private SoundPlayer simpleSound;
  
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // отключаем двойную буферизацию для этого UserControl'а     
                return handleParam;
            }
        }

        public UC_info()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void UC_info_Load(object sender, EventArgs e)
        {
            versionLabel.Text += Globals.settings._version;
        }

        private void developerButton_Click(object sender, EventArgs e)
        {
            new AboutDeveloperGUI().Show();
        }

        private void termsOfUseButton_Click(object sender, EventArgs e)
        {
            new TermsOfUseGUI().ShowDialog();
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            
        }

        private void reportErrorButton_Click(object sender, EventArgs e)
        {
            new reportABugGUI().Show();
        }
    }
}
