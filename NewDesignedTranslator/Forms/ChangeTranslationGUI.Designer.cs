namespace NewDesignedTranslator
{
    partial class ChangeTranslationGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeTranslationGUI));
            this.captionLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.originalWordLabel = new System.Windows.Forms.Label();
            this.okButton = new Guna.UI2.WinForms.Guna2Button();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.newTranslationForWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.infoPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.eraseButton = new Guna.UI2.WinForms.Guna2Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captionLabel
            // 
            this.captionLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.captionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captionLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLabel.ForeColor = System.Drawing.Color.White;
            this.captionLabel.Location = new System.Drawing.Point(0, 0);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(402, 33);
            this.captionLabel.TabIndex = 3;
            this.captionLabel.Text = "Изменение перевода";
            this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.captionLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(402, 33);
            this.topPanel.TabIndex = 5;
            // 
            // originalWordLabel
            // 
            this.originalWordLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.originalWordLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalWordLabel.ForeColor = System.Drawing.Color.White;
            this.originalWordLabel.Location = new System.Drawing.Point(138, 46);
            this.originalWordLabel.Name = "originalWordLabel";
            this.originalWordLabel.Size = new System.Drawing.Size(238, 20);
            this.originalWordLabel.TabIndex = 6;
            this.originalWordLabel.Text = "Cuvant";
            this.originalWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Animated = true;
            this.okButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.okButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okButton.FillColor = System.Drawing.Color.LimeGreen;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(260, 118);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(116, 32);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Применить";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Animated = true;
            this.cancelButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.Crimson;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(138, 118);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(116, 32);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // drag
            // 
            this.drag.DockIndicatorTransparencyValue = 0.6D;
            this.drag.DragStartTransparencyValue = 1D;
            this.drag.TargetControl = this.captionLabel;
            this.drag.UseTransparentDrag = true;
            // 
            // newTranslationForWord
            // 
            this.newTranslationForWord.BorderColor = System.Drawing.Color.Blue;
            this.newTranslationForWord.BorderThickness = 0;
            this.newTranslationForWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newTranslationForWord.DefaultText = "";
            this.newTranslationForWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newTranslationForWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newTranslationForWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newTranslationForWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newTranslationForWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newTranslationForWord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.newTranslationForWord.ForeColor = System.Drawing.Color.Black;
            this.newTranslationForWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newTranslationForWord.Location = new System.Drawing.Point(138, 81);
            this.newTranslationForWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newTranslationForWord.Name = "newTranslationForWord";
            this.newTranslationForWord.PasswordChar = '\0';
            this.newTranslationForWord.PlaceholderText = "Введите новый перевод..";
            this.newTranslationForWord.SelectedText = "";
            this.newTranslationForWord.Size = new System.Drawing.Size(238, 34);
            this.newTranslationForWord.TabIndex = 24;
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.FillColor = System.Drawing.Color.Transparent;
            this.infoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("infoPictureBox.Image")));
            this.infoPictureBox.ImageRotate = 0F;
            this.infoPictureBox.Location = new System.Drawing.Point(18, 52);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(100, 91);
            this.infoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoPictureBox.TabIndex = 4;
            this.infoPictureBox.TabStop = false;
            // 
            // eraseButton
            // 
            this.eraseButton.Animated = true;
            this.eraseButton.BackColor = System.Drawing.Color.White;
            this.eraseButton.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.eraseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.eraseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.eraseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.eraseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.eraseButton.FillColor = System.Drawing.SystemColors.Highlight;
            this.eraseButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.eraseButton.ForeColor = System.Drawing.Color.White;
            this.eraseButton.HoverState.ForeColor = System.Drawing.Color.Crimson;
            this.eraseButton.Image = ((System.Drawing.Image)(resources.GetObject("eraseButton.Image")));
            this.eraseButton.ImageOffset = new System.Drawing.Point(-7, 0);
            this.eraseButton.ImageSize = new System.Drawing.Size(30, 30);
            this.eraseButton.Location = new System.Drawing.Point(370, 81);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(49, 34);
            this.eraseButton.TabIndex = 23;
            this.eraseButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // ChangeTranslationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(402, 160);
            this.Controls.Add(this.newTranslationForWord);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.originalWordLabel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.infoPictureBox);
            this.Controls.Add(this.eraseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeTranslationGUI";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение перевода";
            this.Load += new System.EventHandler(this.ChangeTranslationGUI_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label captionLabel;
        private Guna.UI2.WinForms.Guna2PictureBox infoPictureBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label originalWordLabel;
        private Guna.UI2.WinForms.Guna2Button okButton;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        public Guna.UI2.WinForms.Guna2Button eraseButton;
        private Guna.UI2.WinForms.Guna2TextBox newTranslationForWord;
    }
}