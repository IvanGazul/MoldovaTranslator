using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace NewDesignedTranslator.Forms.Messages.Information
{
    public partial class reportABugGUI : Form
    {
        public reportABugGUI()
        {
            InitializeComponent();

            messageSubjectTextBox.ContextMenuStrip = new ContextMenuStrip();
            messageBodyTextBox.ContextMenuStrip = new ContextMenuStrip();

        }

        //My e-mail>
        private readonly string Reciever = "papichb@yandex.com";

        //Bot settings
        private readonly string From = "FROM WHO?";
        private readonly string BotPassword = "WHAT PASSWORD?";
        
        //Message body
        private string Message = string.Empty;
        private string Subject = string.Empty;
        
        private async void SendEmail()
        {
            if (Globals.OP == true)
            {
                infoBox.Show("У вас Open Source версия программы,бот не может отправить сообщение,модифицируйте это сообщение в файле reportABugGUI.cs!");
                return;
            }

            var fromAddress = new MailAddress(From, "Переводчик");
            var toAddress = new MailAddress(Reciever, "Разработчику");
            
            await Task.Run(() =>
            {
                try
                {
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.YOURSERVER.com",
                        Port = -1, //YOUR PORT
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, BotPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = Subject,
                        Body = Message
                    })
                    {
                        smtp.Send(message);
                    }
                }
                catch
                {
                    errorBox.ShowDialog("Не удалось отправить сообщение..");
                }
            });

            errorBox.ShowDialog("Сообщение успешно отправлено!");

            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(messageBodyTextBox.Text) || string.IsNullOrEmpty(messageSubjectTextBox.Text))
            {
                errorBox.Show("Одно из полей не заполнено!");
                return;
            }

            if(messageSubjectTextBox.TextLength < 5)
            {
                errorBox.Show("Слишком короткий текст темы сообщения");
                return;
            }

            if (messageBodyTextBox.TextLength < 20)
            {
                errorBox.Show("Слишком короткий текст сообщения");
                return;
            }

            Message = messageBodyTextBox.Text;
            Subject = messageSubjectTextBox.Text;

            SendEmail();           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void reportABugGUI_Load(object sender, EventArgs e)
        {
            Appear();
        }

        private void messageBodyTextBox_TextChanged(object sender, EventArgs e)
        {
            messageSubjectLength.Text = messageSubjectTextBox.Text.Length + "/" + "40";
        }

        private void messageSubjectTextBox_TextChanged(object sender, EventArgs e)
        {
            messageLength.Text = messageBodyTextBox.Text.Length + "/" + messageBodyTextBox.MaxLength;
        }

        bool messageSubjectTextBoxIsFocused = false;
        bool messageBodyTextBoxIsFocused = false;
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
            if(e.Modifiers == Keys.Control && e.KeyCode == Keys.V) 
            {
                e.SuppressKeyPress = true;
            }
            if(e.KeyCode == Keys.Space)
            {
                if(!messageSubjectTextBoxIsFocused && messageBodyTextBox.TextLength >= 1 && messageBodyTextBox.Text[messageBodyTextBox.Text.Length - 1] == ' ')
                    e.SuppressKeyPress = true;
                if (!messageBodyTextBoxIsFocused && messageSubjectTextBox.TextLength >= 1 && messageSubjectTextBox.Text[messageSubjectTextBox.Text.Length - 1] == ' ')
                    e.SuppressKeyPress = true;
            }

            messageSubjectLength.Text = messageSubjectTextBox.Text.Length + "/" + messageSubjectTextBox.MaxLength;
            messageLength.Text = messageBodyTextBox.Text.Length + "/" + messageBodyTextBox.MaxLength;
        }

        private void messageSubjectTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            messageSubjectTextBoxIsFocused = true;
            messageBodyTextBoxIsFocused = false;
        }

        private void messageBodyTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            messageSubjectTextBoxIsFocused = false;
            messageBodyTextBoxIsFocused = true;
        }
    }
}
