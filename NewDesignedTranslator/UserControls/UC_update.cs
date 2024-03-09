using NewDesignedTranslator.Forms.Messages;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace NewDesignedTranslator.UserControls
{
    public partial class UC_update : UserControl
    {
        private bool _isUpdating = false;

        public UC_update()
        {
            InitializeComponent();

            progressIndicator.Start();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void UC_update_Load(object sender, EventArgs e)
        {
            if (Globals.patchNotes != string.Empty)
                patchNotesTextBox.Text = Globals.patchNotes;
        }

        private void startUpdateButton_Click(object sender, EventArgs e)
        {
            if (_isUpdating)
            {
                infoBox.Show("Загрузка уже началась!");
                return;
            }

            _isUpdating = true;
            updateStuffPanel.Visible = true;
            startDownload();
        }

        WebClient client = new WebClient();
        private void startDownload()
        {
            Thread thread = new Thread(() => {
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(Globals.DownloadUpdaterLink), "Updater.exe");
            });
            thread.Start();
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                downloadRemainingLabel.Text = "Загружено " + e.BytesReceived / 1024 + " КБ из " + e.TotalBytesToReceive / 1024 + " КБ";
                progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                downloadRemainingLabel.Text = "Отменено!";
                _isUpdating = false;
                infoBox.Show("Загрузка отменена");
            }
            else
            {
                this.BeginInvoke((MethodInvoker)delegate {
                    downloadRemainingLabel.Text = "Загружено";
                });

                Process process = new Process();
                process.StartInfo = new ProcessStartInfo("C:\\IvanGazul\\Updater.exe");
                process.Start();

                Application.Exit();
            }
        }

        private void forceUpdateButton_Click(object sender, EventArgs e)
        {
            if(Globals.OP == true)
            {
                infoBox.Show("У вас Open Source версия программы,модифицируйте все под ваши нужды!");
                return;
            }

            actualVersionPanel.Visible = false;
            downloadPanel.Visible = false;

            startUpdateButton.PerformClick();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            string command = "ping 8.8.8.8 -n 3 && cd config && move Переводчик.exe.bak .. && cd .. &&rename \"Переводчик.exe.bak\" \"Переводчик.exe.original\" && rename \"Переводчик.exe\" \"Переводчик.exe.bak\" && rename \"Переводчик.exe.original\" \"Переводчик.exe\"";
            
            if (!File.Exists("config/Переводчик.exe.bac"))
            {
                errorBox.Show("Невозможно сделать откат,возможно вы никогда не обновлялись.");
                return;
            }

            System.Diagnostics.Process.Start("CMD.exe", command);

            Application.Exit();
        }

        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
        }
    }
}
