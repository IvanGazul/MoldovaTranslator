using System;
using System.Windows.Forms;
using System.Threading;
using NewDesignedTranslator.Forms.Messages;

namespace NewDesignedTranslator
{
    internal static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(Exception1);
            Application.Run(new TranslatorForm());
        }

        static void Exception1(object sender, ThreadExceptionEventArgs e)
        {
            fatalErrorBox.Show($"{e.Exception.Message}");
        }
    }
}
