using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinaryApp.Components
{
    [ToolboxItem(true)]
    public partial class SidebarButton : Button
    {
        private PictureBox iconBox;
        private Label textLabel;

        public event EventHandler ButtonClick;

        public SidebarButton()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            this.Height = 50;
            this.Dock = DockStyle.Top;
            this.BackColor = Color.FromArgb(30, 30, 40);
            this.Cursor = Cursors.Hand;

            iconBox = new PictureBox
            {
                Size = new Size(24, 24),
                Location = new Point(10, 13),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            textLabel = new Label
            {
                AutoSize = false,
                Location = new Point(40, 15),
                Size = new Size(150, 20),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F),
                TextAlign = ContentAlignment.MiddleLeft
            };

            this.Controls.Add(iconBox);
            this.Controls.Add(textLabel);

            this.Click += OnClickAll;
            iconBox.Click += OnClickAll;
            textLabel.Click += OnClickAll;
        }

        private void OnClickAll(object? sender, EventArgs e)
        {
            ButtonClick?.Invoke(this, e);
        }

        // ---------- Public Özellikler ----------
        public Image Icon
        {
            get => iconBox.Image;
            set => iconBox.Image = value;
        }

        public string ButtonText
        {
            get => textLabel.Text;
            set => textLabel.Text = value;
        }

        public Color HoverColor { get; set; } = Color.FromArgb(50, 50, 70);
        public Color DefaultColor { get; set; } = Color.FromArgb(30, 30, 40);

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = HoverColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = DefaultColor;
        }
    }
}
