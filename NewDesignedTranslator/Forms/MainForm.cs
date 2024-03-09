using NewDesignedTranslator.Classes;
using NewDesignedTranslator.Forms.Messages.Information;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NewDesignedTranslator
{
    public partial class TranslatorForm : Form
    {
        //Переменные нажатых UC
        private bool mainProgrammButtonClicked = true;
        private bool informationButtonClicked;
        private bool updateButtonClicked;

        //Устанавливает размер иконки оповещения возле обновления
        public void setImageNotifSize(int x,int y)
        {
            updateButton.ImageSize = new Size(x, y);
        }

        //Действия которые нада выполнить в первый запуск
        private void OnFirstStartup()
        {
            if (!Globals.settings._firstLaunch)
                return;
            Globals.settings._firstLaunch = !Globals.settings._firstLaunch;

            new TermsOfUseGUI().ShowDialog();
        }

        //Действия которые нада выполнить при запуске приложения
        private void OnStartup()
        {
            //Запускаем фоновые процессы
            BackgroundProcesses.Start();

            Globals.Programm_uc.setSavedText();

            //Добавляем на панель UC программы и проверяем обновление
            addUserControl(Globals.Programm_uc);
        }

        //Конструктор формы
        public TranslatorForm()
        {
            Globals.mainForm = this;

            InitializeComponent();

            OnStartup();

            OnFirstStartup();
        }

        //Выход из приложения
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Сохраняем настройки текста
            Globals.settings._savedTextMold = Globals.Programm_uc.getMoldText();
            Globals.settings._savedTextRum = Globals.Programm_uc.getRumText();
            
            //Сохраняем класс
            Globals.settings.Save();

            this.Close();
        }

        //Кнопка сворачивания окна
        private void hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Добавить контрол на панель
        public void addUserControl(UserControl userControl)
        {
            //Делаем контрол чтобы он заполнял все пространство
            userControl.Dock = DockStyle.Fill;
            //Очищаем панель и вставляем интересующий нас контрол на нее
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(userControl);

            //Показываем UC
            userControl.BringToFront();
        }

        //Установить значения для нажатых кнопок
        private void setValuesToButtons(bool mainProgrammClicked, bool informationClicked, bool updateClicked)
        {
            if (Globals.outdatedVersion)
                setImageNotifSize(16, 18);

            mainProgrammButtonClicked = mainProgrammClicked;
            informationButtonClicked = informationClicked;
            updateButtonClicked = updateClicked;
        }

        //Кнопка главной программы
        private void mainProgramm_Click(object sender, EventArgs e)
        {
            if (mainProgrammButtonClicked)
                return;

            //Обновляем значения нажатых кнопок
            setValuesToButtons(mainProgrammClicked: true, informationClicked: false, updateClicked: false);

            //Добавляем контрол на панель
            addUserControl(Globals.Programm_uc);
        }
        
        //Кнопка информации
        private void informationButton_Click(object sender, EventArgs e)
        {
            if (informationButtonClicked)
                return;

            //Обновляем значения нажатых кнопок
            setValuesToButtons(mainProgrammClicked: false, informationClicked: true, updateClicked: false);

            //Добавляем контрол на панель
            addUserControl(Globals.info_uc);
        }

        //Кнопка обновлений
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (updateButtonClicked)
                return;

            //Обновляем значения нажатых кнопок
            setValuesToButtons(mainProgrammClicked: false, informationClicked: false, updateClicked: true);

            //Убираем иконку уведомления
            setImageNotifSize(0, 0);

            //Добавляем контрол на панель
            addUserControl(Globals.update_uc);
        }

        private void TranslatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Выходим из приложения
            Application.Exit();
        } 

    }
}
