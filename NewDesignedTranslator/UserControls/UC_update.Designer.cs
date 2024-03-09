namespace NewDesignedTranslator.UserControls
{
    partial class UC_update
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_update));
            this.startUpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.changesLabel = new System.Windows.Forms.Label();
            this.DownloaderLabel = new System.Windows.Forms.Label();
            this.Tips = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.backupButton = new Guna.UI2.WinForms.Guna2Button();
            this.forceUpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.ScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.patchNotesTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DownloaderPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.changesPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.actualVersionPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.actualVersionPicture = new System.Windows.Forms.PictureBox();
            this.checkMarkPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.latestVersionLabel = new System.Windows.Forms.Label();
            this.cancelUpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.downloadRemainingLabel = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadPanel = new System.Windows.Forms.Panel();
            this.progressIndicator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.updateStuffPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DownloaderPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changesPictureBox)).BeginInit();
            this.actualVersionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualVersionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkMarkPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.downloadPanel.SuspendLayout();
            this.updateStuffPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startUpdateButton
            // 
            this.startUpdateButton.Animated = true;
            this.startUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startUpdateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.startUpdateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startUpdateButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.startUpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("startUpdateButton.Image")));
            this.startUpdateButton.Location = new System.Drawing.Point(119, 195);
            this.startUpdateButton.Name = "startUpdateButton";
            this.startUpdateButton.Size = new System.Drawing.Size(167, 45);
            this.startUpdateButton.TabIndex = 3;
            this.startUpdateButton.Text = "Обновить";
            this.startUpdateButton.Click += new System.EventHandler(this.startUpdateButton_Click);
            // 
            // changesLabel
            // 
            this.changesLabel.AutoSize = true;
            this.changesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.changesLabel.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changesLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.changesLabel.Location = new System.Drawing.Point(542, 19);
            this.changesLabel.Name = "changesLabel";
            this.changesLabel.Size = new System.Drawing.Size(140, 27);
            this.changesLabel.TabIndex = 16;
            this.changesLabel.Text = "Изменения";
            this.changesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DownloaderLabel
            // 
            this.DownloaderLabel.AutoSize = true;
            this.DownloaderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.DownloaderLabel.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloaderLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.DownloaderLabel.Location = new System.Drawing.Point(147, 18);
            this.DownloaderLabel.Name = "DownloaderLabel";
            this.DownloaderLabel.Size = new System.Drawing.Size(125, 27);
            this.DownloaderLabel.TabIndex = 26;
            this.DownloaderLabel.Text = "Загрузчик";
            this.DownloaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tips
            // 
            this.Tips.AllowLinksHandling = true;
            this.Tips.BackColor = System.Drawing.Color.SlateBlue;
            this.Tips.BorderColor = System.Drawing.Color.SlateBlue;
            this.Tips.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tips.ForeColor = System.Drawing.Color.White;
            this.Tips.MaximumSize = new System.Drawing.Size(0, 0);
            this.Tips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // backupButton
            // 
            this.backupButton.Animated = true;
            this.backupButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backupButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backupButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backupButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backupButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.backupButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backupButton.ForeColor = System.Drawing.Color.HotPink;
            this.backupButton.Image = ((System.Drawing.Image)(resources.GetObject("backupButton.Image")));
            this.backupButton.ImageSize = new System.Drawing.Size(32, 32);
            this.backupButton.Location = new System.Drawing.Point(72, 50);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(245, 30);
            this.backupButton.TabIndex = 34;
            this.backupButton.Text = "Отменить обновление";
            this.Tips.SetToolTip(this.backupButton, "Сделать откат на предыдущую вашу установленную версию.");
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // forceUpdateButton
            // 
            this.forceUpdateButton.Animated = true;
            this.forceUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.forceUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.forceUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.forceUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.forceUpdateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.forceUpdateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forceUpdateButton.ForeColor = System.Drawing.Color.Crimson;
            this.forceUpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("forceUpdateButton.Image")));
            this.forceUpdateButton.ImageSize = new System.Drawing.Size(32, 32);
            this.forceUpdateButton.Location = new System.Drawing.Point(72, 86);
            this.forceUpdateButton.Name = "forceUpdateButton";
            this.forceUpdateButton.Size = new System.Drawing.Size(245, 30);
            this.forceUpdateButton.TabIndex = 37;
            this.forceUpdateButton.Text = "Обновить прин.";
            this.Tips.SetToolTip(this.forceUpdateButton, "Обновляет приложение не проверив версию");
            this.forceUpdateButton.Click += new System.EventHandler(this.forceUpdateButton_Click);
            // 
            // ScrollBar
            // 
            this.ScrollBar.BindingContainer = this.patchNotesTextBox;
            this.ScrollBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.ScrollBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.ScrollBar.InUpdate = false;
            this.ScrollBar.LargeChange = 1;
            this.ScrollBar.Location = new System.Drawing.Point(746, 59);
            this.ScrollBar.Maximum = 1;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.ScrollbarSize = 18;
            this.ScrollBar.Size = new System.Drawing.Size(18, 276);
            this.ScrollBar.TabIndex = 31;
            this.ScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // patchNotesTextBox
            // 
            this.patchNotesTextBox.Animated = true;
            this.patchNotesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.patchNotesTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.patchNotesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patchNotesTextBox.DefaultText = "Загрузка..";
            this.patchNotesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.patchNotesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.patchNotesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patchNotesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patchNotesTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(49)))));
            this.patchNotesTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patchNotesTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patchNotesTextBox.ForeColor = System.Drawing.Color.White;
            this.patchNotesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patchNotesTextBox.Location = new System.Drawing.Point(409, 50);
            this.patchNotesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.patchNotesTextBox.Multiline = true;
            this.patchNotesTextBox.Name = "patchNotesTextBox";
            this.patchNotesTextBox.PasswordChar = '\0';
            this.patchNotesTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.patchNotesTextBox.PlaceholderText = "";
            this.patchNotesTextBox.ReadOnly = true;
            this.patchNotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.patchNotesTextBox.SelectedText = "";
            this.patchNotesTextBox.Size = new System.Drawing.Size(364, 294);
            this.patchNotesTextBox.TabIndex = 30;
            // 
            // DownloaderPicture
            // 
            this.DownloaderPicture.Image = ((System.Drawing.Image)(resources.GetObject("DownloaderPicture.Image")));
            this.DownloaderPicture.ImageRotate = 0F;
            this.DownloaderPicture.Location = new System.Drawing.Point(119, 17);
            this.DownloaderPicture.Name = "DownloaderPicture";
            this.DownloaderPicture.Size = new System.Drawing.Size(25, 28);
            this.DownloaderPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DownloaderPicture.TabIndex = 27;
            this.DownloaderPicture.TabStop = false;
            // 
            // changesPictureBox
            // 
            this.changesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("changesPictureBox.Image")));
            this.changesPictureBox.ImageRotate = 0F;
            this.changesPictureBox.Location = new System.Drawing.Point(504, 7);
            this.changesPictureBox.Name = "changesPictureBox";
            this.changesPictureBox.Size = new System.Drawing.Size(39, 38);
            this.changesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changesPictureBox.TabIndex = 20;
            this.changesPictureBox.TabStop = false;
            // 
            // actualVersionPanel
            // 
            this.actualVersionPanel.Controls.Add(this.actualVersionPicture);
            this.actualVersionPanel.Controls.Add(this.checkMarkPicture);
            this.actualVersionPanel.Controls.Add(this.latestVersionLabel);
            this.actualVersionPanel.Location = new System.Drawing.Point(16, 122);
            this.actualVersionPanel.Name = "actualVersionPanel";
            this.actualVersionPanel.Size = new System.Drawing.Size(386, 245);
            this.actualVersionPanel.TabIndex = 36;
            this.actualVersionPanel.Visible = false;
            // 
            // actualVersionPicture
            // 
            this.actualVersionPicture.Image = ((System.Drawing.Image)(resources.GetObject("actualVersionPicture.Image")));
            this.actualVersionPicture.Location = new System.Drawing.Point(0, 43);
            this.actualVersionPicture.Name = "actualVersionPicture";
            this.actualVersionPicture.Size = new System.Drawing.Size(383, 174);
            this.actualVersionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.actualVersionPicture.TabIndex = 39;
            this.actualVersionPicture.TabStop = false;
            // 
            // checkMarkPicture
            // 
            this.checkMarkPicture.Image = ((System.Drawing.Image)(resources.GetObject("checkMarkPicture.Image")));
            this.checkMarkPicture.ImageRotate = 0F;
            this.checkMarkPicture.Location = new System.Drawing.Point(16, 13);
            this.checkMarkPicture.Name = "checkMarkPicture";
            this.checkMarkPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.checkMarkPicture.Size = new System.Drawing.Size(20, 21);
            this.checkMarkPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkMarkPicture.TabIndex = 38;
            this.checkMarkPicture.TabStop = false;
            // 
            // latestVersionLabel
            // 
            this.latestVersionLabel.AutoSize = true;
            this.latestVersionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.latestVersionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latestVersionLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.latestVersionLabel.Location = new System.Drawing.Point(36, 13);
            this.latestVersionLabel.Name = "latestVersionLabel";
            this.latestVersionLabel.Size = new System.Drawing.Size(327, 21);
            this.latestVersionLabel.TabIndex = 37;
            this.latestVersionLabel.Text = "Установлена самая актуальная версия!";
            this.latestVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelUpdateButton
            // 
            this.cancelUpdateButton.Animated = true;
            this.cancelUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelUpdateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.cancelUpdateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelUpdateButton.ForeColor = System.Drawing.Color.Crimson;
            this.cancelUpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelUpdateButton.Image")));
            this.cancelUpdateButton.Location = new System.Drawing.Point(102, 75);
            this.cancelUpdateButton.Name = "cancelUpdateButton";
            this.cancelUpdateButton.Size = new System.Drawing.Size(167, 45);
            this.cancelUpdateButton.TabIndex = 38;
            this.cancelUpdateButton.Text = "Отменить";
            this.cancelUpdateButton.Click += new System.EventHandler(this.cancelUpdateButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar.Location = new System.Drawing.Point(15, 40);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(340, 30);
            this.progressBar.TabIndex = 39;
            this.progressBar.Text = "Загрузка..";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // downloadRemainingLabel
            // 
            this.downloadRemainingLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadRemainingLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.downloadRemainingLabel.Location = new System.Drawing.Point(12, 13);
            this.downloadRemainingLabel.Name = "downloadRemainingLabel";
            this.downloadRemainingLabel.Size = new System.Drawing.Size(170, 23);
            this.downloadRemainingLabel.TabIndex = 40;
            this.downloadRemainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(32, 161);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(20, 21);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 41;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(52, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "У вас установлена устаревшая версия!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downloadPanel
            // 
            this.downloadPanel.Controls.Add(this.progressIndicator);
            this.downloadPanel.Controls.Add(this.downloadLabel);
            this.downloadPanel.Location = new System.Drawing.Point(16, 125);
            this.downloadPanel.Name = "downloadPanel";
            this.downloadPanel.Size = new System.Drawing.Size(386, 219);
            this.downloadPanel.TabIndex = 42;
            // 
            // progressIndicator
            // 
            this.progressIndicator.Location = new System.Drawing.Point(127, 27);
            this.progressIndicator.Name = "progressIndicator";
            this.progressIndicator.ProgressColor = System.Drawing.Color.LimeGreen;
            this.progressIndicator.Size = new System.Drawing.Size(123, 116);
            this.progressIndicator.TabIndex = 44;
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.downloadLabel.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.downloadLabel.Location = new System.Drawing.Point(131, 161);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(125, 27);
            this.downloadLabel.TabIndex = 43;
            this.downloadLabel.Text = "Загрузка..";
            this.downloadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateStuffPanel
            // 
            this.updateStuffPanel.Controls.Add(this.progressBar);
            this.updateStuffPanel.Controls.Add(this.downloadRemainingLabel);
            this.updateStuffPanel.Controls.Add(this.cancelUpdateButton);
            this.updateStuffPanel.Location = new System.Drawing.Point(17, 240);
            this.updateStuffPanel.Name = "updateStuffPanel";
            this.updateStuffPanel.Size = new System.Drawing.Size(368, 130);
            this.updateStuffPanel.TabIndex = 43;
            this.updateStuffPanel.Visible = false;
            // 
            // UC_update
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.downloadPanel);
            this.Controls.Add(this.actualVersionPanel);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startUpdateButton);
            this.Controls.Add(this.updateStuffPanel);
            this.Controls.Add(this.forceUpdateButton);
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.patchNotesTextBox);
            this.Controls.Add(this.DownloaderPicture);
            this.Controls.Add(this.DownloaderLabel);
            this.Controls.Add(this.changesPictureBox);
            this.Controls.Add(this.changesLabel);
            this.Controls.Add(this.backupButton);
            this.DoubleBuffered = true;
            this.Name = "UC_update";
            this.Size = new System.Drawing.Size(800, 370);
            this.Load += new System.EventHandler(this.UC_update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DownloaderPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changesPictureBox)).EndInit();
            this.actualVersionPanel.ResumeLayout(false);
            this.actualVersionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualVersionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkMarkPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.downloadPanel.ResumeLayout(false);
            this.downloadPanel.PerformLayout();
            this.updateStuffPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label changesLabel;
        private System.Windows.Forms.Label DownloaderLabel;
        private Guna.UI2.WinForms.Guna2Button startUpdateButton;
        private Guna.UI2.WinForms.Guna2HtmlToolTip Tips;
        private Guna.UI2.WinForms.Guna2VScrollBar ScrollBar;
        private Guna.UI2.WinForms.Guna2PictureBox DownloaderPicture;
        private Guna.UI2.WinForms.Guna2PictureBox changesPictureBox;
        public Guna.UI2.WinForms.Guna2TextBox patchNotesTextBox;
        private Guna.UI2.WinForms.Guna2Button backupButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox checkMarkPicture;
        private System.Windows.Forms.Label latestVersionLabel;
        public Guna.UI2.WinForms.Guna2Panel actualVersionPanel;
        private System.Windows.Forms.PictureBox actualVersionPicture;
        private Guna.UI2.WinForms.Guna2Button forceUpdateButton;
        private Guna.UI2.WinForms.Guna2Button cancelUpdateButton;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.Windows.Forms.Label downloadRemainingLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label downloadLabel;
        private Guna.UI2.WinForms.Guna2ProgressIndicator progressIndicator;
        public System.Windows.Forms.Panel downloadPanel;
        private System.Windows.Forms.Panel updateStuffPanel;
    }
}
