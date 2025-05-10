using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace VeterinaryApp.Component
{
    [ToolboxItem(true)]
    public class GradientPanel : Panel
    {
        public Color Color1 { get; set; } = Color.MintCream;
        public Color Color2 { get; set; } = Color.LightGreen;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color1,
                Color2,
                LinearGradientMode.Vertical)) // Dikey gradyan, istersen Horizontal da yapabilirsin
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
