namespace NewDesignedTranslator.Forms.Messages.Information
{
    partial class reportABugGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportABugGUI));
            this.topPanel = new System.Windows.Forms.Panel();
            this.captionLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.okButton = new Guna.UI2.WinForms.Guna2Button();
            this.messageBodyTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.messageSubjectTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.messageLength = new System.Windows.Forms.Label();
            this.messageSubjectLength = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.topPanel.Controls.Add(this.captionLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(490, 39);
            this.topPanel.TabIndex = 0;
            // 
            // captionLabel
            // 
            this.captionLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.captionLabel.Location = new System.Drawing.Point(0, 0);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(490, 39);
            this.captionLabel.TabIndex = 2;
            this.captionLabel.Text = "Сообщить об ошибке";
            this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.cancelButton);
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 215);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(490, 39);
            this.bottomPanel.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Animated = true;
            this.cancelButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.cancelButton.BorderColor = System.Drawing.Color.Silver;
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.Crimson;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(373, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 32);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Animated = true;
            this.okButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.okButton.BorderColor = System.Drawing.Color.Silver;
            this.okButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okButton.FillColor = System.Drawing.Color.LimeGreen;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(253, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(114, 32);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Отправить";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // messageBodyTextBox
            // 
            this.messageBodyTextBox.BorderThickness = 0;
            this.messageBodyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messageBodyTextBox.DefaultText = "";
            this.messageBodyTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.messageBodyTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.messageBodyTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageBodyTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageBodyTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageBodyTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBodyTextBox.ForeColor = System.Drawing.Color.Black;
            this.messageBodyTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageBodyTextBox.Location = new System.Drawing.Point(12, 88);
            this.messageBodyTextBox.MaxLength = 750;
            this.messageBodyTextBox.Multiline = true;
            this.messageBodyTextBox.Name = "messageBodyTextBox";
            this.messageBodyTextBox.PasswordChar = '\0';
            this.messageBodyTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.messageBodyTextBox.PlaceholderText = "Опишите проблему,условия появления, последствия, частота и тд..";
            this.messageBodyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBodyTextBox.SelectedText = "";
            this.messageBodyTextBox.Size = new System.Drawing.Size(466, 116);
            this.messageBodyTextBox.TabIndex = 2;
            this.messageBodyTextBox.TextChanged += new System.EventHandler(this.messageBodyTextBox_TextChanged);
            this.messageBodyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.messageBodyTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.messageBodyTextBox_MouseClick);
            // 
            // messageSubjectTextBox
            // 
            this.messageSubjectTextBox.BorderThickness = 0;
            this.messageSubjectTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messageSubjectTextBox.DefaultText = "";
            this.messageSubjectTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.messageSubjectTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.messageSubjectTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageSubjectTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageSubjectTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageSubjectTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageSubjectTextBox.ForeColor = System.Drawing.Color.Black;
            this.messageSubjectTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageSubjectTextBox.Location = new System.Drawing.Point(12, 52);
            this.messageSubjectTextBox.MaxLength = 40;
            this.messageSubjectTextBox.Name = "messageSubjectTextBox";
            this.messageSubjectTextBox.PasswordChar = '\0';
            this.messageSubjectTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.messageSubjectTextBox.PlaceholderText = "Введите тему сообщения..";
            this.messageSubjectTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageSubjectTextBox.SelectedText = "";
            this.messageSubjectTextBox.Size = new System.Drawing.Size(259, 30);
            this.messageSubjectTextBox.TabIndex = 3;
            this.messageSubjectTextBox.TextChanged += new System.EventHandler(this.messageSubjectTextBox_TextChanged);
            this.messageSubjectTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.messageSubjectTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.messageSubjectTextBox_MouseClick);
            // 
            // drag
            // 
            this.drag.DockIndicatorTransparencyValue = 0.6D;
            this.drag.DragStartTransparencyValue = 1D;
            this.drag.TargetControl = this.topPanel;
            this.drag.UseTransparentDrag = true;
            // 
            // messageLength
            // 
            this.messageLength.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLength.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.messageLength.Location = new System.Drawing.Point(363, 66);
            this.messageLength.Name = "messageLength";
            this.messageLength.Size = new System.Drawing.Size(115, 19);
            this.messageLength.TabIndex = 17;
            this.messageLength.Text = "0/750";
            this.messageLength.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // messageSubjectLength
            // 
            this.messageSubjectLength.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageSubjectLength.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.messageSubjectLength.Location = new System.Drawing.Point(156, 35);
            this.messageSubjectLength.Name = "messageSubjectLength";
            this.messageSubjectLength.Size = new System.Drawing.Size(115, 19);
            this.messageSubjectLength.TabIndex = 18;
            this.messageSubjectLength.Text = "0/40";
            this.messageSubjectLength.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // reportABugGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(490, 254);
            this.Controls.Add(this.messageLength);
            this.Controls.Add(this.messageSubjectTextBox);
            this.Controls.Add(this.messageBodyTextBox);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.messageSubjectLength);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reportABugGUI";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сообщить об ошибке";
            this.Load += new System.EventHandler(this.reportABugGUI_Load);
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private Guna.UI2.WinForms.Guna2Button okButton;
        private Guna.UI2.WinForms.Guna2TextBox messageBodyTextBox;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2TextBox messageSubjectTextBox;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        private System.Windows.Forms.Label messageLength;
        private System.Windows.Forms.Label messageSubjectLength;
    }
}