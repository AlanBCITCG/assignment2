using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace assignment2
{
    public partial class asgn2 : Form
    {
        private int s;

        public asgn2()
        {
            InitializeComponent();
            Text = "C4560: Assignment 2, Exercise 1 (Alan Lai Set R/2015)";
            BackColor = Color.Black;
            ResizeRedraw = true;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void setS()
        {
            s = Math.Min(this.Size.Height, this.Size.Width);
        }

        private void asgn2_Paint(object sender, PaintEventArgs e)
        {
            Graphics grfx = e.Graphics;
            grfx.SmoothingMode = SmoothingMode.HighQuality;
            grfx.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // Get value of s
            int s = Math.Min(ClientSize.Width, ClientSize.Height);
            // Set mid point of width and height
            int mx = ClientSize.Width / 2;
            int my = ClientSize.Height / 2;

            double r_small = s / 12.0;
            double r_large = s / 6.0;

            // Top left section, big circle
            double LT1x = mx - 5.0 / 12.0 * s;
            double LT1y = my - 5.0 / 12.0 * s;
            SolidBrush brush = new SolidBrush(Color.Blue);
            grfx.FillEllipse(brush, (int)LT1x, (int)LT1y, (int)r_large * 2, (int)r_large * 2);
            // small circle
            brush = new SolidBrush(Color.Green);
            double LT5x = mx - 1.0 / 3.0 * s;
            double LT5y = my - 1.0 / 3.0 * s;
            grfx.FillEllipse(brush, (int)LT5x, (int)LT5y, (int)r_small * 2, (int)r_small * 2);

            // Top right section, big circle
            brush = new SolidBrush(Color.Yellow);
            double LT3x = mx + 1.0 / 12.0 * s;
            double LT3y = my - 5.0 / 12.0 * s;
            grfx.FillEllipse(brush, (int)LT3x, (int)LT3y, (int)r_large * 2, (int) r_large * 2);
            // small circle
            brush = new SolidBrush(Color.Green);
            double LT7x = mx + s / 6.0;
            double LT7y = my - 1.0 / 3.0 * s;
            grfx.FillEllipse(brush, (int)LT7x, (int)LT7y, (int)r_small * 2, (int)r_small * 2);

            // Bottom left section, big circle
            brush = new SolidBrush(Color.Blue);
            double LT2x = mx - 5.0 / 12.0 * s;
            double LT2y = my + 1.0 / 12.0 * s;
            grfx.FillEllipse(brush, (int)LT2x, (int)LT2y, (int)r_large * 2, (int)r_large * 2);
            // small circle
            brush = new SolidBrush(Color.Red);
            double LT6x = mx - 1.0 / 3.0 * s;
            double LT6y = my + s / 6.0;
            grfx.FillEllipse(brush, (int)LT6x, (int)LT6y, (int)r_small * 2, (int)r_small * 2);


            // Bottom right section, big circle
            brush = new SolidBrush(Color.Yellow);
            double LT4x = mx + 1.0 / 12.0 * s;
            double LT4y = my + 1.0 / 12.0 * s;
            grfx.FillEllipse(brush, (int)LT4x, (int)LT4y, (int)r_large * 2, (int)r_large * 2);
            // small circle
            brush = new SolidBrush(Color.Red);
            double LT8x = mx + s / 6.0;
            double LT8y = my + s / 6.0;
            grfx.FillEllipse(brush, (int)LT8x, (int)LT8y, (int)r_small * 2, (int)r_small * 2);
        }
    }
}
