using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDesignedTranslator.Forms.Messages.Information
{
    public partial class AboutDeveloperGUI : Form
    {
        ProcessStartInfo sInfo;

        public AboutDeveloperGUI()
        {
            InitializeComponent();
        }

        private void Appear()
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

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutDeveloperGUI_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.ShowIcon = true;
            this.TopMost = true;

            Appear();
        }

        private void VKButton_Click(object sender, EventArgs e)
        {
            sInfo = new ProcessStartInfo("https://vk.com/ammortredka");
            Process.Start(sInfo);
        }

        private void intagramButton_Click(object sender, EventArgs e)
        {
            sInfo = new ProcessStartInfo("https://www.instagram.com/_mmalenia/");
            Process.Start(sInfo);
        }

        private void telegramButton_Click(object sender, EventArgs e)
        {
            sInfo = new ProcessStartInfo("https://t.me/mortredka");
            Process.Start(sInfo);
        }
    }
}
