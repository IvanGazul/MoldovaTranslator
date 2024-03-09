using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NewDesignedTranslator.UserControls
{
    [DefaultEvent("_TextChanged")]
    public partial class IGTextBox : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.BlueViolet;

        private int borderSize = 2;

        private bool underlinedStyle = false;
        private bool isFocused = false;

        public event EventHandler _TextChanged;

        [Category("General Settings")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                textBox.BackColor = value;
            }
        }

        public int SelectionLength { get => textBox.SelectionLength; set => textBox.SelectionLength = value; }

        public Color SelectionBackColor { get => textBox.SelectionBackColor; set => textBox.SelectionColor = value; }

        public string SelectedText { get=> textBox.SelectedText ; }

        [Category("General Settings")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                textBox.ForeColor = value;
            }
        }

        [Category("General Settings")]
        public override ContextMenuStrip ContextMenuStrip { get => textBox.ContextMenuStrip; set => textBox.ContextMenuStrip = value; }

        [Category("General Settings")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set => borderFocusColor = value;
        }

        [Category("General Settings")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox.Font = value;

                if (this.DesignMode)
                    updateControlHeight();
            }
        }

        [Category("General Settings")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("General Settings")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("General Settings")]
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("General Settings")]
        public int SelectionStart
        {
            get => textBox.SelectionStart;
            set => textBox.SelectionStart = value;
        }

        [Category("General Settings")]
        public override string Text
        {
            get => textBox.Text;
            set=> textBox.Text = value;
        }

        public void ScrollToCaret()
        {
            textBox.ScrollToCaret();
        }

        public void SelectAll()
        {
            textBox.SelectAll();
        }

        public void Select(int start, int length)
        {
            textBox.Select(start, length);
        }

        public IGTextBox()
        {
            InitializeComponent();
        }

        public void Cut()
        {
            textBox.Cut();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(BorderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!isFocused)
                {
                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                }

            }
        }

        private void updateControlHeight()
        {
            if (textBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox.Multiline = true;
                textBox.MinimumSize = new Size(0, txtHeight);
                textBox.Multiline = true;

                this.Height = textBox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            updateControlHeight();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.DesignMode)
                updateControlHeight();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }
    }
}
