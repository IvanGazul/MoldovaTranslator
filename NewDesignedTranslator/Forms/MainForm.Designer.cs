namespace NewDesignedTranslator
{
    partial class TranslatorForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.hideButton = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProgrammNameLabel = new System.Windows.Forms.Label();
            this.IconPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.informationButton = new Guna.UI2.WinForms.Guna2Button();
            this.mainProgramm = new Guna.UI2.WinForms.Guna2Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.msgBoxInformation = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgBoxQuestion = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.gunaToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Purple;
            this.HeaderPanel.Controls.Add(this.hideButton);
            this.HeaderPanel.Controls.Add(this.exitButton);
            this.HeaderPanel.Controls.Add(this.ProgrammNameLabel);
            this.HeaderPanel.Controls.Add(this.IconPicture);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 34);
            this.HeaderPanel.TabIndex = 0;
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.Color.Peru;
            this.hideButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hideButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hideButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hideButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hideButton.FillColor = System.Drawing.Color.Purple;
            this.hideButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hideButton.ForeColor = System.Drawing.Color.White;
            this.hideButton.Image = ((System.Drawing.Image)(resources.GetObject("hideButton.Image")));
            this.hideButton.Location = new System.Drawing.Point(714, 0);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(43, 34);
            this.hideButton.TabIndex = 3;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Peru;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.Purple;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(757, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(43, 34);
            this.exitButton.TabIndex = 2;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ProgrammNameLabel
            // 
            this.ProgrammNameLabel.AutoSize = true;
            this.ProgrammNameLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammNameLabel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.ProgrammNameLabel.Location = new System.Drawing.Point(42, 7);
            this.ProgrammNameLabel.Name = "ProgrammNameLabel";
            this.ProgrammNameLabel.Size = new System.Drawing.Size(113, 19);
            this.ProgrammNameLabel.TabIndex = 1;
            this.ProgrammNameLabel.Text = "Переводчик";
            // 
            // IconPicture
            // 
            this.IconPicture.Image = ((System.Drawing.Image)(resources.GetObject("IconPicture.Image")));
            this.IconPicture.ImageRotate = 0F;
            this.IconPicture.Location = new System.Drawing.Point(8, 0);
            this.IconPicture.Name = "IconPicture";
            this.IconPicture.Size = new System.Drawing.Size(32, 32);
            this.IconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPicture.TabIndex = 0;
            this.IconPicture.TabStop = false;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.NavigationPanel.Controls.Add(this.updateButton);
            this.NavigationPanel.Controls.Add(this.informationButton);
            this.NavigationPanel.Controls.Add(this.mainProgramm);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 34);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(800, 35);
            this.NavigationPanel.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.updateButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updateButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.updateButton.CustomBorderColor = System.Drawing.Color.Transparent;
            this.updateButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updateButton.ImageOffset = new System.Drawing.Point(6, -6);
            this.updateButton.ImageSize = new System.Drawing.Size(0, 0);
            this.updateButton.Location = new System.Drawing.Point(570, 0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 35);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Обновление";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // informationButton
            // 
            this.informationButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.informationButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.informationButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.informationButton.CustomBorderColor = System.Drawing.Color.Transparent;
            this.informationButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.informationButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.informationButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.informationButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.informationButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.informationButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.informationButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.informationButton.ForeColor = System.Drawing.Color.White;
            this.informationButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.informationButton.Location = new System.Drawing.Point(325, 0);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(150, 35);
            this.informationButton.TabIndex = 1;
            this.informationButton.Text = "Информация";
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // mainProgramm
            // 
            this.mainProgramm.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.mainProgramm.Checked = true;
            this.mainProgramm.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainProgramm.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.mainProgramm.CustomBorderColor = System.Drawing.Color.Transparent;
            this.mainProgramm.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.mainProgramm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.mainProgramm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.mainProgramm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mainProgramm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.mainProgramm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.mainProgramm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.mainProgramm.ForeColor = System.Drawing.Color.White;
            this.mainProgramm.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainProgramm.Location = new System.Drawing.Point(80, 0);
            this.mainProgramm.Name = "mainProgramm";
            this.mainProgramm.Size = new System.Drawing.Size(150, 35);
            this.mainProgramm.TabIndex = 0;
            this.mainProgramm.Text = "Приложение";
            this.mainProgramm.Click += new System.EventHandler(this.mainProgramm_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.ContentPanel.Location = new System.Drawing.Point(0, 69);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(800, 371);
            this.ContentPanel.TabIndex = 2;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.HeaderPanel;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // msgBoxInformation
            // 
            this.msgBoxInformation.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgBoxInformation.Caption = "";
            this.msgBoxInformation.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.msgBoxInformation.Parent = null;
            this.msgBoxInformation.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.msgBoxInformation.Text = "";
            // 
            // msgBoxQuestion
            // 
            this.msgBoxQuestion.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel;
            this.msgBoxQuestion.Caption = "";
            this.msgBoxQuestion.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.msgBoxQuestion.Parent = null;
            this.msgBoxQuestion.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.msgBoxQuestion.Text = "";
            // 
            // gunaToolTip
            // 
            this.gunaToolTip.AllowLinksHandling = true;
            this.gunaToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // TranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TranslatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переводчик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TranslatorForm_FormClosing);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Label ProgrammNameLabel;
        private Guna.UI2.WinForms.Guna2PictureBox IconPicture;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2Button hideButton;
        private Guna.UI2.WinForms.Guna2Button mainProgramm;
        private Guna.UI2.WinForms.Guna2Button informationButton;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxInformation;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxQuestion;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2HtmlToolTip gunaToolTip;
        public System.Windows.Forms.Panel ContentPanel;
    }
}

