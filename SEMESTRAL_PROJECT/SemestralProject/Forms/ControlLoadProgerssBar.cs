using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms
{
    /// <summary>
    /// Class which represents progress bar with orange color
    /// </summary>
    internal class ControlLoadProgerssBar: ProgressBar
    {
        public ControlLoadProgerssBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(new SolidBrush(Color.FromKnownColor(KnownColor.DarkOrange)), 2, 2, rec.Width, rec.Height);
        }
    }
}
