namespace NewDesignedTranslator.UserControls
{
    partial class Programm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programm));
            this.toolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.translateButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.swapLangButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.highlightMistakesButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.rumLabel = new System.Windows.Forms.Label();
            this.msgBoxInformation = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MoldTextBoxMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПереводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftHalf = new System.Windows.Forms.Panel();
            this.rumTextLengthLabel = new System.Windows.Forms.Label();
            this.rumTextBox = new NewDesignedTranslator.UserControls.IGTextBox();
            this.RumTextBoxMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRum = new Guna.UI2.WinForms.Guna2Button();
            this.pasteRum = new Guna.UI2.WinForms.Guna2Button();
            this.copyRum = new Guna.UI2.WinForms.Guna2Button();
            this.moldLabel = new System.Windows.Forms.Label();
            this.RightHalf = new System.Windows.Forms.Panel();
            this.moldTextBox = new NewDesignedTranslator.UserControls.IGTextBox();
            this.moldTextLengthLabel = new System.Windows.Forms.Label();
            this.clearMold = new Guna.UI2.WinForms.Guna2Button();
            this.copyMold = new Guna.UI2.WinForms.Guna2Button();
            this.pasteMold = new Guna.UI2.WinForms.Guna2Button();
            this.Content = new System.Windows.Forms.Panel();
            this.labelSwapTimer = new System.Windows.Forms.Timer(this.components);
            this.MoldTextBoxMenu.SuspendLayout();
            this.LeftHalf.SuspendLayout();
            this.RumTextBoxMenu.SuspendLayout();
            this.RightHalf.SuspendLayout();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.AllowLinksHandling = true;
            this.toolTip.BackColor = System.Drawing.Color.SlateBlue;
            this.toolTip.BorderColor = System.Drawing.Color.SlateBlue;
            this.toolTip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolTip.ForeColor = System.Drawing.Color.White;
            this.toolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // translateButton
            // 
            this.translateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.translateButton.CheckedState.ImageSize = new System.Drawing.Size(12, 12);
            this.translateButton.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.translateButton.Image = ((System.Drawing.Image)(resources.GetObject("translateButton.Image")));
            this.translateButton.ImageOffset = new System.Drawing.Point(0, 2);
            this.translateButton.ImageRotate = 0F;
            this.translateButton.ImageSize = new System.Drawing.Size(32, 32);
            this.translateButton.Location = new System.Drawing.Point(365, 318);
            this.translateButton.Name = "translateButton";
            this.translateButton.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.translateButton.Size = new System.Drawing.Size(66, 45);
            this.translateButton.TabIndex = 16;
            this.toolTip.SetToolTip(this.translateButton, "Перевести");
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // swapLangButton
            // 
            this.swapLangButton.AnimatedGIF = true;
            this.swapLangButton.CheckedState.ImageSize = new System.Drawing.Size(12, 12);
            this.swapLangButton.HoverState.ImageSize = new System.Drawing.Size(18, 18);
            this.swapLangButton.Image = ((System.Drawing.Image)(resources.GetObject("swapLangButton.Image")));
            this.swapLangButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.swapLangButton.ImageRotate = 0F;
            this.swapLangButton.ImageSize = new System.Drawing.Size(15, 15);
            this.swapLangButton.Location = new System.Drawing.Point(388, 5);
            this.swapLangButton.Name = "swapLangButton";
            this.swapLangButton.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.swapLangButton.Size = new System.Drawing.Size(20, 20);
            this.swapLangButton.TabIndex = 15;
            this.toolTip.SetToolTip(this.swapLangButton, "Меняет перевод(Молд на Рум)");
            this.swapLangButton.Click += new System.EventHandler(this.swapLangButton_Click);
            // 
            // highlightMistakesButton
            // 
            this.highlightMistakesButton.AnimatedGIF = true;
            this.highlightMistakesButton.CheckedState.ImageSize = new System.Drawing.Size(12, 12);
            this.highlightMistakesButton.HoverState.ImageSize = new System.Drawing.Size(18, 18);
            this.highlightMistakesButton.Image = ((System.Drawing.Image)(resources.GetObject("highlightMistakesButton.Image")));
            this.highlightMistakesButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.highlightMistakesButton.ImageRotate = 0F;
            this.highlightMistakesButton.ImageSize = new System.Drawing.Size(15, 15);
            this.highlightMistakesButton.Location = new System.Drawing.Point(260, 5);
            this.highlightMistakesButton.Name = "highlightMistakesButton";
            this.highlightMistakesButton.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.highlightMistakesButton.Size = new System.Drawing.Size(20, 20);
            this.highlightMistakesButton.TabIndex = 27;
            this.toolTip.SetToolTip(this.highlightMistakesButton, "Выделяет все возможные ошибки в тексте");
            this.highlightMistakesButton.Click += new System.EventHandler(this.highlightMistakesButton_Click);
            // 
            // rumLabel
            // 
            this.rumLabel.AutoSize = true;
            this.rumLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rumLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.rumLabel.Location = new System.Drawing.Point(151, 5);
            this.rumLabel.Name = "rumLabel";
            this.rumLabel.Size = new System.Drawing.Size(101, 19);
            this.rumLabel.TabIndex = 11;
            this.rumLabel.Text = "Румынский";
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
            // MoldTextBoxMenu
            // 
            this.MoldTextBoxMenu.BackColor = System.Drawing.Color.Azure;
            this.MoldTextBoxMenu.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoldTextBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.изменитьПереводToolStripMenuItem,
            this.показатьIDToolStripMenuItem});
            this.MoldTextBoxMenu.Name = "TextBoxMenu";
            this.MoldTextBoxMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.MoldTextBoxMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.MoldTextBoxMenu.RenderStyle.ColorTable = null;
            this.MoldTextBoxMenu.RenderStyle.RoundedEdges = true;
            this.MoldTextBoxMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.MoldTextBoxMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MoldTextBoxMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MoldTextBoxMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.MoldTextBoxMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.MoldTextBoxMenu.Size = new System.Drawing.Size(203, 124);
            this.MoldTextBoxMenu.Text = "Меню";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripMenuItem.Image")));
            this.копироватьToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вставитьToolStripMenuItem.Image")));
            this.вставитьToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripMenuItem.Image")));
            this.вырезатьToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // изменитьПереводToolStripMenuItem
            // 
            this.изменитьПереводToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.изменитьПереводToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.изменитьПереводToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.изменитьПереводToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьПереводToolStripMenuItem.Image")));
            this.изменитьПереводToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.изменитьПереводToolStripMenuItem.Name = "изменитьПереводToolStripMenuItem";
            this.изменитьПереводToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.изменитьПереводToolStripMenuItem.Text = "Изменить перевод";
            this.изменитьПереводToolStripMenuItem.Click += new System.EventHandler(this.изменитьПереводToolStripMenuItem_Click);
            // 
            // показатьIDToolStripMenuItem
            // 
            this.показатьIDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("показатьIDToolStripMenuItem.Image")));
            this.показатьIDToolStripMenuItem.Name = "показатьIDToolStripMenuItem";
            this.показатьIDToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.показатьIDToolStripMenuItem.Text = "Показать ID";
            this.показатьIDToolStripMenuItem.Click += new System.EventHandler(this.показатьIDToolStripMenuItem_Click);
            // 
            // LeftHalf
            // 
            this.LeftHalf.Controls.Add(this.rumTextLengthLabel);
            this.LeftHalf.Controls.Add(this.rumTextBox);
            this.LeftHalf.Controls.Add(this.rumLabel);
            this.LeftHalf.Controls.Add(this.clearRum);
            this.LeftHalf.Controls.Add(this.pasteRum);
            this.LeftHalf.Controls.Add(this.copyRum);
            this.LeftHalf.Location = new System.Drawing.Point(0, 0);
            this.LeftHalf.Name = "LeftHalf";
            this.LeftHalf.Size = new System.Drawing.Size(400, 371);
            this.LeftHalf.TabIndex = 26;
            // 
            // rumTextLengthLabel
            // 
            this.rumTextLengthLabel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rumTextLengthLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rumTextLengthLabel.Location = new System.Drawing.Point(3, 5);
            this.rumTextLengthLabel.Name = "rumTextLengthLabel";
            this.rumTextLengthLabel.Size = new System.Drawing.Size(115, 19);
            this.rumTextLengthLabel.TabIndex = 15;
            this.rumTextLengthLabel.Text = "0";
            // 
            // rumTextBox
            // 
            this.rumTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(49)))));
            this.rumTextBox.BorderColor = System.Drawing.Color.SlateBlue;
            this.rumTextBox.BorderFocusColor = System.Drawing.Color.DarkViolet;
            this.rumTextBox.BorderSize = 2;
            this.rumTextBox.ContextMenuStrip = this.RumTextBoxMenu;
            this.rumTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rumTextBox.ForeColor = System.Drawing.Color.White;
            this.rumTextBox.Location = new System.Drawing.Point(2, 28);
            this.rumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rumTextBox.Name = "rumTextBox";
            this.rumTextBox.Padding = new System.Windows.Forms.Padding(9);
            this.rumTextBox.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(49)))));
            this.rumTextBox.SelectionLength = 0;
            this.rumTextBox.SelectionStart = 0;
            this.rumTextBox.Size = new System.Drawing.Size(393, 283);
            this.rumTextBox.TabIndex = 14;
            this.rumTextBox.UnderlinedStyle = false;
            this.rumTextBox._TextChanged += new System.EventHandler(this.rumTextBox__TextChanged);
            // 
            // RumTextBoxMenu
            // 
            this.RumTextBoxMenu.BackColor = System.Drawing.Color.Azure;
            this.RumTextBoxMenu.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RumTextBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.RumTextBoxMenu.Name = "TextBoxMenu";
            this.RumTextBoxMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.RumTextBoxMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.RumTextBoxMenu.RenderStyle.ColorTable = null;
            this.RumTextBoxMenu.RenderStyle.RoundedEdges = true;
            this.RumTextBoxMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.RumTextBoxMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RumTextBoxMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.RumTextBoxMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.RumTextBoxMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.RumTextBoxMenu.Size = new System.Drawing.Size(160, 76);
            this.RumTextBoxMenu.Text = "Меню";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 24);
            this.toolStripMenuItem1.Text = "Копировать";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 24);
            this.toolStripMenuItem2.Text = "Вставить";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 24);
            this.toolStripMenuItem3.Text = "Вырезать";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // clearRum
            // 
            this.clearRum.Animated = true;
            this.clearRum.BackColor = System.Drawing.Color.White;
            this.clearRum.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.clearRum.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.clearRum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearRum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearRum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearRum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearRum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.clearRum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearRum.ForeColor = System.Drawing.Color.White;
            this.clearRum.HoverState.ForeColor = System.Drawing.Color.Crimson;
            this.clearRum.Image = ((System.Drawing.Image)(resources.GetObject("clearRum.Image")));
            this.clearRum.Location = new System.Drawing.Point(2, 318);
            this.clearRum.Name = "clearRum";
            this.clearRum.Size = new System.Drawing.Size(115, 45);
            this.clearRum.TabIndex = 3;
            this.clearRum.Text = "Очистить";
            this.clearRum.Click += new System.EventHandler(this.clearRum_Click);
            // 
            // pasteRum
            // 
            this.pasteRum.Animated = true;
            this.pasteRum.BackColor = System.Drawing.Color.White;
            this.pasteRum.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.pasteRum.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.pasteRum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pasteRum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pasteRum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pasteRum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pasteRum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.pasteRum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasteRum.ForeColor = System.Drawing.Color.White;
            this.pasteRum.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pasteRum.Image = ((System.Drawing.Image)(resources.GetObject("pasteRum.Image")));
            this.pasteRum.Location = new System.Drawing.Point(123, 318);
            this.pasteRum.Name = "pasteRum";
            this.pasteRum.Size = new System.Drawing.Size(115, 45);
            this.pasteRum.TabIndex = 4;
            this.pasteRum.Text = "Вставить";
            this.pasteRum.Click += new System.EventHandler(this.pasteRum_Click);
            // 
            // copyRum
            // 
            this.copyRum.Animated = true;
            this.copyRum.BackColor = System.Drawing.Color.White;
            this.copyRum.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.copyRum.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.copyRum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.copyRum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.copyRum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copyRum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.copyRum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.copyRum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.copyRum.ForeColor = System.Drawing.Color.White;
            this.copyRum.HoverState.ForeColor = System.Drawing.Color.LawnGreen;
            this.copyRum.Image = ((System.Drawing.Image)(resources.GetObject("copyRum.Image")));
            this.copyRum.Location = new System.Drawing.Point(244, 318);
            this.copyRum.Name = "copyRum";
            this.copyRum.Size = new System.Drawing.Size(115, 45);
            this.copyRum.TabIndex = 5;
            this.copyRum.Text = "Копировать";
            this.copyRum.Click += new System.EventHandler(this.copyRum_Click);
            // 
            // moldLabel
            // 
            this.moldLabel.AutoSize = true;
            this.moldLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moldLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.moldLabel.Location = new System.Drawing.Point(151, 5);
            this.moldLabel.Name = "moldLabel";
            this.moldLabel.Size = new System.Drawing.Size(111, 19);
            this.moldLabel.TabIndex = 10;
            this.moldLabel.Text = "Молдавский";
            // 
            // RightHalf
            // 
            this.RightHalf.Controls.Add(this.highlightMistakesButton);
            this.RightHalf.Controls.Add(this.moldLabel);
            this.RightHalf.Controls.Add(this.moldTextBox);
            this.RightHalf.Controls.Add(this.moldTextLengthLabel);
            this.RightHalf.Controls.Add(this.clearMold);
            this.RightHalf.Controls.Add(this.copyMold);
            this.RightHalf.Controls.Add(this.pasteMold);
            this.RightHalf.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightHalf.Location = new System.Drawing.Point(400, 0);
            this.RightHalf.Name = "RightHalf";
            this.RightHalf.Size = new System.Drawing.Size(400, 371);
            this.RightHalf.TabIndex = 25;
            // 
            // moldTextBox
            // 
            this.moldTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(49)))));
            this.moldTextBox.BorderColor = System.Drawing.Color.SlateBlue;
            this.moldTextBox.BorderFocusColor = System.Drawing.Color.DarkViolet;
            this.moldTextBox.BorderSize = 2;
            this.moldTextBox.ContextMenuStrip = this.MoldTextBoxMenu;
            this.moldTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moldTextBox.ForeColor = System.Drawing.Color.White;
            this.moldTextBox.Location = new System.Drawing.Point(2, 28);
            this.moldTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.moldTextBox.Name = "moldTextBox";
            this.moldTextBox.Padding = new System.Windows.Forms.Padding(9);
            this.moldTextBox.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(49)))));
            this.moldTextBox.SelectionLength = 0;
            this.moldTextBox.SelectionStart = 0;
            this.moldTextBox.Size = new System.Drawing.Size(390, 283);
            this.moldTextBox.TabIndex = 15;
            this.moldTextBox.UnderlinedStyle = false;
            this.moldTextBox._TextChanged += new System.EventHandler(this.moldTextBox__TextChanged);
            // 
            // moldTextLengthLabel
            // 
            this.moldTextLengthLabel.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moldTextLengthLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.moldTextLengthLabel.Location = new System.Drawing.Point(271, 5);
            this.moldTextLengthLabel.Name = "moldTextLengthLabel";
            this.moldTextLengthLabel.Size = new System.Drawing.Size(115, 19);
            this.moldTextLengthLabel.TabIndex = 16;
            this.moldTextLengthLabel.Text = "0";
            this.moldTextLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // clearMold
            // 
            this.clearMold.Animated = true;
            this.clearMold.BackColor = System.Drawing.Color.White;
            this.clearMold.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.clearMold.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.clearMold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearMold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearMold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearMold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearMold.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.clearMold.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearMold.ForeColor = System.Drawing.Color.White;
            this.clearMold.HoverState.ForeColor = System.Drawing.Color.Crimson;
            this.clearMold.Image = ((System.Drawing.Image)(resources.GetObject("clearMold.Image")));
            this.clearMold.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clearMold.ImageOffset = new System.Drawing.Point(5, 0);
            this.clearMold.Location = new System.Drawing.Point(279, 318);
            this.clearMold.Name = "clearMold";
            this.clearMold.Size = new System.Drawing.Size(113, 45);
            this.clearMold.TabIndex = 6;
            this.clearMold.Text = "Очистить";
            this.clearMold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.clearMold.Click += new System.EventHandler(this.clearMold_Click);
            // 
            // copyMold
            // 
            this.copyMold.Animated = true;
            this.copyMold.BackColor = System.Drawing.Color.White;
            this.copyMold.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.copyMold.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.copyMold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.copyMold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.copyMold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copyMold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.copyMold.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.copyMold.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.copyMold.ForeColor = System.Drawing.Color.White;
            this.copyMold.HoverState.ForeColor = System.Drawing.Color.LawnGreen;
            this.copyMold.Image = ((System.Drawing.Image)(resources.GetObject("copyMold.Image")));
            this.copyMold.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.copyMold.ImageOffset = new System.Drawing.Point(-3, 0);
            this.copyMold.Location = new System.Drawing.Point(37, 318);
            this.copyMold.Name = "copyMold";
            this.copyMold.Size = new System.Drawing.Size(115, 45);
            this.copyMold.TabIndex = 8;
            this.copyMold.Text = "Копировать";
            this.copyMold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.copyMold.Click += new System.EventHandler(this.copyMold_Click);
            // 
            // pasteMold
            // 
            this.pasteMold.Animated = true;
            this.pasteMold.BackColor = System.Drawing.Color.White;
            this.pasteMold.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.pasteMold.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.pasteMold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pasteMold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pasteMold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pasteMold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pasteMold.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.pasteMold.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasteMold.ForeColor = System.Drawing.Color.White;
            this.pasteMold.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pasteMold.Image = ((System.Drawing.Image)(resources.GetObject("pasteMold.Image")));
            this.pasteMold.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pasteMold.ImageOffset = new System.Drawing.Point(7, 0);
            this.pasteMold.Location = new System.Drawing.Point(158, 318);
            this.pasteMold.Name = "pasteMold";
            this.pasteMold.Size = new System.Drawing.Size(115, 45);
            this.pasteMold.TabIndex = 7;
            this.pasteMold.Text = "Вставить";
            this.pasteMold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pasteMold.Click += new System.EventHandler(this.pasteMold_Click);
            // 
            // Content
            // 
            this.Content.Controls.Add(this.translateButton);
            this.Content.Controls.Add(this.swapLangButton);
            this.Content.Controls.Add(this.LeftHalf);
            this.Content.Controls.Add(this.RightHalf);
            this.Content.Location = new System.Drawing.Point(3, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(800, 371);
            this.Content.TabIndex = 16;
            // 
            // Programm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.Content);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Programm";
            this.Size = new System.Drawing.Size(810, 370);
            this.MoldTextBoxMenu.ResumeLayout(false);
            this.LeftHalf.ResumeLayout(false);
            this.LeftHalf.PerformLayout();
            this.RumTextBoxMenu.ResumeLayout(false);
            this.RightHalf.ResumeLayout(false);
            this.RightHalf.PerformLayout();
            this.Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlToolTip toolTip;
        private Guna.UI2.WinForms.Guna2Button clearRum;
        private Guna.UI2.WinForms.Guna2Button copyRum;
        private Guna.UI2.WinForms.Guna2Button pasteRum;
        private Guna.UI2.WinForms.Guna2ImageButton swapLangButton;
        private Guna.UI2.WinForms.Guna2ImageButton translateButton;
        private System.Windows.Forms.Label rumLabel;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxInformation;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip MoldTextBoxMenu;
        private System.Windows.Forms.ToolStripMenuItem изменитьПереводToolStripMenuItem;
        private System.Windows.Forms.Panel LeftHalf;
        private System.Windows.Forms.ToolStripMenuItem показатьIDToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button clearMold;
        private Guna.UI2.WinForms.Guna2Button pasteMold;
        private Guna.UI2.WinForms.Guna2Button copyMold;
        private System.Windows.Forms.Label moldLabel;
        private System.Windows.Forms.Panel RightHalf;
        private IGTextBox rumTextBox;
        private IGTextBox moldTextBox;
        private System.Windows.Forms.Label rumTextLengthLabel;
        private System.Windows.Forms.Label moldTextLengthLabel;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip RumTextBoxMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private Guna.UI2.WinForms.Guna2ImageButton highlightMistakesButton;
        private System.Windows.Forms.Timer labelSwapTimer;
    }
}
