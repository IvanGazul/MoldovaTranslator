using System;
using System.Windows.Forms;

namespace NewDesignedTranslator.Forms.Messages
{
    public partial class infoBox : Form
    {
        public infoBox(string text)
        {
            InitializeComponent();

            textLabel.Text = text;

            Initialize();
        }

        public static void Show(string Text)
        {
            infoBox box = new infoBox(Text);
            box.Show();
        }

        public static void ShowDialog(string Text)
        {
            infoBox box = new infoBox(Text);
            box.ShowDialog();
        }


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

        private void infoBox_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.ShowIcon = true;
            this.TopMost = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

    }
}
