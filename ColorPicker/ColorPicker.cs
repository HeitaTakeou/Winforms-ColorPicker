using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class ColorPicker : Form
    {
        public ColorPicker()
        {
            InitializeComponent();
            this.Opacity = 0;
            fadeIn.Start();
        }

        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Point previouspx = new Point(1, 11);

        private void rgbpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                var relativePoint = this.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
                if (e.Y < rgbpanel.Height && e.Y >= 0 && e.X >= 1 && e.X <= rgbpanel.Size.Width - 7 && e.X < rgbpanel.Width)
                {
                    Bitmap bmp = (Bitmap)rgbpanel.Image;
                    Color clr = bmp.GetPixel(e.X, e.Y);
                    whitegradientpanel.FillColor3 = clr;
                    whitegradientpanel.FillColor4 = clr;
                    blackgradientpanel.FillColor = clr;
                    rgbpanelpicker.Location = new Point(relativePoint.X, rgbpanelpicker.Location.Y);
                    updateColor();
                }
            }
        }

        private void blackgradientpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                if (e.Y < blackgradientpanel.Height && e.Y >= 0 && e.X >= 1 && e.X <= blackgradientpanel.Size.Width - 7 && e.X < blackgradientpanel.Width)
                {
                    Bitmap bmp = new Bitmap(blackgradientpanel.Width, blackgradientpanel.Height);
                    blackgradientpanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    Color clr = bmp.GetPixel(e.X, e.Y);
                    colorpreviewpanel.FillColor = clr;
                    previouspx = e.Location;
                    label3.Text = (e.X, e.Y).ToString();
                }
            }
        }

        private void whitegradientpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                var relativePoint = this.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
                if (e.Y < whitegradientpanel.Height && e.Y >= 1 && e.X >= 1 && e.X <= whitegradientpanel.Size.Width - 3 && e.Y <= whitegradientpanel.Height - 3)
                {
                    Bitmap bmp = new Bitmap(whitegradientpanel.Width, whitegradientpanel.Height);
                    whitegradientpanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    Color clr = bmp.GetPixel(e.X, e.Y);
                    blackgradientpanel.FillColor = clr;
                    updateColor();
                }
            }
        }

        private void updateColor()
        {
            Bitmap blackgradientpanelbmp = new Bitmap(blackgradientpanel.Width, blackgradientpanel.Height);
            blackgradientpanel.DrawToBitmap(blackgradientpanelbmp, new Rectangle(0, 0, blackgradientpanelbmp.Width, blackgradientpanelbmp.Height));
            Color clr = blackgradientpanelbmp.GetPixel(previouspx.X, previouspx.Y);
            colorpreviewpanel.FillColor = clr;
        }

        private void chromabutton_Click(object sender, EventArgs e)
        {
            if (chromabutton.Checked)
            {
                chromaRGB.Start();
            }
            else
            {
                chromaRGB.Stop();
            }
        }

        private void rgbcolorUpdate()
        {
            Point point = new Point(rgbpanelpicker.Location.X, rgbpanelpicker.Location.Y);
            Bitmap bmp = (Bitmap)rgbpanel.Image;
            Color clr = bmp.GetPixel(rgbpanelpicker.Location.X - rgbpanel.Left, rgbpanelpicker.Location.Y - rgbpanel.Top);
            whitegradientpanel.FillColor3 = clr;
            whitegradientpanel.FillColor4 = clr;
            blackgradientpanel.FillColor = clr;
            updateColor();
        }

        private void chromaRGB_Tick(object sender, EventArgs e)
        {
            if (rgbpanelpicker.Location.X > 218 && rgbpanelpicker.Location.X < rgbpanel.Location.X + rgbpanel.Size.Width - 6)
            {
                rgbpanelpicker.Location = new Point(rgbpanelpicker.Location.X + 1, rgbpanelpicker.Location.Y);
            }
            else
            {
                rgbpanelpicker.Location = new Point(rgbpanel.Location.X + 1, rgbpanelpicker.Location.Y);
            }
            rgbcolorUpdate();
        }

        private void fadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 100)
            {
                this.Opacity += 0.1F;
            }
            else if (this.Opacity == 100)
            {
                fadeIn.Stop();
            }
        }

        private void ColorPicker_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ColorPicker_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
