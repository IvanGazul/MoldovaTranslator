namespace NewDesignedTranslator.UserControls
{
    partial class UC_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_info));
            this.versionLabel = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.msgBoxOk = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.FAQButton = new Guna.UI2.WinForms.Guna2Button();
            this.privacyPolicyLabel = new System.Windows.Forms.Label();
            this.termsOfUseButton = new Guna.UI2.WinForms.Guna2Button();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.aboutDeveloper = new Guna.UI2.WinForms.Guna2Button();
            this.reportErrorButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.versionLabel.Location = new System.Drawing.Point(93, 83);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(174, 18);
            this.versionLabel.TabIndex = 5;
            this.versionLabel.Text = "Версия приложения: ";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(62, 78);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(34, 29);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 21;
            this.guna2PictureBox3.TabStop = false;
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.ImageRotate = 0F;
            this.picture.Location = new System.Drawing.Point(412, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(371, 364);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 22;
            this.picture.TabStop = false;
            // 
            // msgBoxOk
            // 
            this.msgBoxOk.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgBoxOk.Caption = null;
            this.msgBoxOk.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msgBoxOk.Parent = null;
            this.msgBoxOk.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.msgBoxOk.Text = null;
            // 
            // FAQButton
            // 
            this.FAQButton.Animated = true;
            this.FAQButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FAQButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FAQButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FAQButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FAQButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.FAQButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.FAQButton.ForeColor = System.Drawing.Color.White;
            this.FAQButton.Location = new System.Drawing.Point(37, 156);
            this.FAQButton.Name = "FAQButton";
            this.FAQButton.Size = new System.Drawing.Size(287, 43);
            this.FAQButton.TabIndex = 23;
            this.FAQButton.Text = "FAQ и Возможности программы";
            this.FAQButton.Click += new System.EventHandler(this.FAQButton_Click);
            // 
            // privacyPolicyLabel
            // 
            this.privacyPolicyLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privacyPolicyLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.privacyPolicyLabel.Location = new System.Drawing.Point(39, 106);
            this.privacyPolicyLabel.Name = "privacyPolicyLabel";
            this.privacyPolicyLabel.Size = new System.Drawing.Size(279, 37);
            this.privacyPolicyLabel.TabIndex = 24;
            this.privacyPolicyLabel.Text = "Приложение собирает данные о переводе для дальнейшего его улучшения";
            this.privacyPolicyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // termsOfUseButton
            // 
            this.termsOfUseButton.Animated = true;
            this.termsOfUseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.termsOfUseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.termsOfUseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.termsOfUseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.termsOfUseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.termsOfUseButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.termsOfUseButton.ForeColor = System.Drawing.Color.White;
            this.termsOfUseButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.termsOfUseButton.Location = new System.Drawing.Point(37, 205);
            this.termsOfUseButton.Name = "termsOfUseButton";
            this.termsOfUseButton.Size = new System.Drawing.Size(287, 43);
            this.termsOfUseButton.TabIndex = 25;
            this.termsOfUseButton.Text = "Правила пользования";
            this.termsOfUseButton.Click += new System.EventHandler(this.termsOfUseButton_Click);
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Font = new System.Drawing.Font("Century Gothic", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programNameLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.programNameLabel.Location = new System.Drawing.Point(59, 17);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(244, 30);
            this.programNameLabel.TabIndex = 26;
            this.programNameLabel.Text = "MoldovaTranslator";
            // 
            // aboutDeveloper
            // 
            this.aboutDeveloper.Animated = true;
            this.aboutDeveloper.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aboutDeveloper.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aboutDeveloper.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aboutDeveloper.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aboutDeveloper.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.aboutDeveloper.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.aboutDeveloper.ForeColor = System.Drawing.Color.Gold;
            this.aboutDeveloper.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.aboutDeveloper.Location = new System.Drawing.Point(37, 254);
            this.aboutDeveloper.Name = "aboutDeveloper";
            this.aboutDeveloper.Size = new System.Drawing.Size(287, 43);
            this.aboutDeveloper.TabIndex = 27;
            this.aboutDeveloper.Text = "О разработчике";
            this.aboutDeveloper.Click += new System.EventHandler(this.developerButton_Click);
            // 
            // reportErrorButton
            // 
            this.reportErrorButton.Animated = true;
            this.reportErrorButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reportErrorButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reportErrorButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reportErrorButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reportErrorButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.reportErrorButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.reportErrorButton.ForeColor = System.Drawing.Color.Crimson;
            this.reportErrorButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportErrorButton.Location = new System.Drawing.Point(40, 303);
            this.reportErrorButton.Name = "reportErrorButton";
            this.reportErrorButton.Size = new System.Drawing.Size(287, 43);
            this.reportErrorButton.TabIndex = 28;
            this.reportErrorButton.Text = "Сообщить об ошибке";
            this.reportErrorButton.Click += new System.EventHandler(this.reportErrorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(89, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Copyright © 2023 Ivan Gazul";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportErrorButton);
            this.Controls.Add(this.aboutDeveloper);
            this.Controls.Add(this.programNameLabel);
            this.Controls.Add(this.termsOfUseButton);
            this.Controls.Add(this.privacyPolicyLabel);
            this.Controls.Add(this.FAQButton);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.versionLabel);
            this.Name = "UC_info";
            this.Size = new System.Drawing.Size(800, 370);
            this.Load += new System.EventHandler(this.UC_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label versionLabel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox picture;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxOk;
        private Guna.UI2.WinForms.Guna2Button FAQButton;
        private System.Windows.Forms.Label privacyPolicyLabel;
        private Guna.UI2.WinForms.Guna2Button termsOfUseButton;
        private System.Windows.Forms.Label programNameLabel;
        private Guna.UI2.WinForms.Guna2Button aboutDeveloper;
        private Guna.UI2.WinForms.Guna2Button reportErrorButton;
        private System.Windows.Forms.Label label1;
    }
}
