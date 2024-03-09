using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace NewDesignedTranslator.Classes
{
    public class BackgroundProcesses
    {
        //Переменные
        private static bool blockedKey = true;

        //WebClient
        public static WebClient client = new WebClient();

        public static void Start()
        {
            InitializeSettings();

            CheckUpdate();
        }

        //Проверяем обновление
        private static async void CheckUpdate()
        {
            //Open source version
            if (Globals.OP == true)
            {

                Globals.downloaded = true;

                Globals.update_uc.downloadPanel.Visible = false;
                Globals.update_uc.downloadPanel.Dispose();

                Globals.update_uc.actualVersionPanel.Visible = true;

                Globals.update_uc.patchNotesTextBox.Text = Globals.patchNotes;
                
                return;
            }

            await Task.Run(() =>
            {
                client.Encoding = System.Text.Encoding.UTF8;

                Globals.SettingsDB.InitializeSettings();
            });

            Globals.downloaded = true;

            Globals.update_uc.downloadPanel.Visible = false;
            Globals.update_uc.downloadPanel.Dispose();

            //Показываем что есть обнова,хы
            if (Globals.newVer != String.Empty & Globals.newVer != Globals.settings._version)
            {
                Globals.mainForm.setImageNotifSize(16, 18);
                Globals.outdatedVersion = true;
            }

            else
                Globals.update_uc.actualVersionPanel.Visible = true;

            string PatchNotes = Globals.patchNotes;

            //Вставляем загруженные патчноуты в боксик
            if (PatchNotes != null & PatchNotes != String.Empty)
                Globals.update_uc.patchNotesTextBox.Text = PatchNotes;

        }

        //Инициализируем настройки
        private static void InitializeSettings()
        {
            if(!Directory.Exists("config"))
                Directory.CreateDirectory("config");

            //Получаем настройки
            Globals.settings = Settings.GetSettings();
        }
        
    }
}
