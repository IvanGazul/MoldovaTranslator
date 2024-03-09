using System;
using System.Windows.Forms;

namespace NewDesignedTranslator.Forms.Messages.Information
{
    public partial class TermsOfUseGUI : Form
    {
        private bool legalBypassed = false;

        public TermsOfUseGUI()
        {
            InitializeComponent();
        }

        private void Appear()
        {
            Opacity = 0;

            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) timer.Stop();
            });
            timer.Interval = 1;
            timer.Start();
        }

        private void TermsOfUseGUI_Load(object sender, EventArgs e)
        {
            okButton.Enabled = false;

            this.ShowInTaskbar = true;
            this.ShowIcon = true;
            this.TopMost = true;

            Appear();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            legalBypassed = true;
            this.Close();
        }

        private bool checkBoxChecked = false;
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxChecked = !checkBoxChecked;
            if (checkBoxChecked)
            {
                okButton.Enabled = true;
                cancelButton.Enabled = false;
            }
            else
            {
                okButton.Enabled = false;
                cancelButton.Enabled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            legalBypassed = true;
            Application.Exit();
        }

        private void TermsOfUseGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!legalBypassed)
                Application.Exit();
        }
    }
}
