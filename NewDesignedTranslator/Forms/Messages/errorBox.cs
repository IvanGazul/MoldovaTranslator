using System;
using System.Windows.Forms;

namespace NewDesignedTranslator
{
    public partial class errorBox : Form
    {
        public errorBox(string text)
        {
            InitializeComponent();

            textLabel.Text = text;

            Initialize();
        }

        public static void Show(string Text)
        {
            errorBox box = new errorBox(Text);
            box.Show();
        }

        public static void ShowDialog(string Text)
        {
            errorBox box = new errorBox(Text);
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

        private void errorBox_Load(object sender, EventArgs e)
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
