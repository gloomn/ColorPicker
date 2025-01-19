using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            screen_timer.Enabled = true;
            Load += main_Load;
            FormClosing += main_FormClosing;
        }

        private delegate void SetColorDelegate(int x, int y, Color color);
        private Thread thread;

        private void ProcessThread()
        {
            while (true)
            {
                Point mousePoint = Control.MousePosition;
                int x = mousePoint.X;
                int y = mousePoint.Y;
                Color color = GetMousePointColor(mousePoint);
                SetColor(x, y, color);
            }
        }

        private string GetHexadecimalString(int value)
        {
            byte[] byteArray = BitConverter.GetBytes(value);
            int byteArrayLength = byteArray.Length;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < byteArrayLength; i++)
            {
                stringBuilder.Append(byteArray[i].ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public (double H, double S, double L) RGBToHSL(int R, int G, int B)
        {
            // Normalize the RGB values to the range 0-1
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            // Get the max and min RGB values
            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            // Calculate Lightness (L)
            double L = (max + min) / 2.0;

            // Calculate Saturation (S)
            double S = 0;
            if (max != min)
            {
                if (L < 0.5)
                {
                    S = (max - min) / (max + min);
                }
                else
                {
                    S = (max - min) / (2.0 - max - min);
                }
            }

            // Calculate Hue (H)
            double H = 0;
            if (max == min)
            {
                // If max == min, Hue is undefined, so we assign a default value (0 or 360)
                H = 0;
            }
            else if (max == r)
            {
                H = (g - b) / (max - min);
            }
            else if (max == g)
            {
                H = (b - r) / (max - min) + 2;
            }
            else if (max == b)
            {
                H = (r - g) / (max - min) + 4;
            }

            // Convert Hue to degrees (0 to 360)
            H *= 60;
            if (H < 0)
            {
                H += 360;
            }

            // Round H, S, and L to the first decimal place
            H = Math.Round(H, 1);
            S *= 100;
            S = Math.Round(S, 1);
            L *= 100;
            L = Math.Round(L, 1);

            return (H, S, L);
        }

        public (double H, double S, double V) RGBToHSV(int R, int G, int B)
        {
            // Normalize the RGB values to the range 0-1
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            // Get the max and min RGB values
            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            // Calculate Value (V)
            double V = max;

            // Calculate Saturation (S)
            double S = 0;
            if (max != 0)
            {
                S = (max - min) / max;
            }

            // Calculate Hue (H)
            double H = 0;
            if (max == min)
            {
                H = 0; // If max == min, Hue is undefined, so we assign a default value (0)
            }
            else if (max == r)
            {
                H = (g - b) / (max - min);
            }
            else if (max == g)
            {
                H = (b - r) / (max - min) + 2;
            }
            else if (max == b)
            {
                H = (r - g) / (max - min) + 4;
            }

            // Convert Hue to degrees (0 to 360)
            H *= 60;
            if (H < 0)
            {
                H += 360;
            }

            // Round H, S, and V to the first decimal place
            H = Math.Round(H, 1);
            S *= 100;
            S = Math.Round(S, 1);
            V *= 100;
            V = Math.Round(V, 1);

            return (H, S, V);
        }

        public (double C, double M, double Y, double K) RGBToCMYK(int R, int G, int B)
        {
            // Normalize the RGB values to the range 0-1
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            // Calculate K (Black)
            double K = 1 - Math.Max(r, Math.Max(g, b));

            // If K is 1, CMY values will be 0
            double C = 0;
            double M = 0;
            double Y = 0;

            if (K < 1)
            {
                C = (1 - r - K) / (1 - K);
                M = (1 - g - K) / (1 - K);
                Y = (1 - b - K) / (1 - K);
            }

            // Convert C, M, Y, K to percentages (0-100)
            C *= 100;
            M *= 100;
            Y *= 100;
            K *= 100;

            // Round C, M, Y, K to 1 decimal place
            C = Math.Round(C, 1);
            M = Math.Round(M, 1);
            Y = Math.Round(Y, 1);
            K = Math.Round(K, 1);

            return (C, M, Y, K);
        }




        private void SetColor(int x, int y, Color color)
        {
            if (InvokeRequired)
            {
                SetColorDelegate setColorDelegate = new SetColorDelegate(SetColor);
                Invoke(setColorDelegate, x, y, color);
            }
            else
            {
                var (HSL_H, HSL_S, HSL_L) = RGBToHSL(color.R, color.G, color.B);
                var (HSV_H, HSV_S, HSV_V) = RGBToHSV(color.R, color.G, color.B);
                var (CMYK_C, CMYK_M, CMYK_Y, CMYK_K) = RGBToCMYK(color.R, color.G, color.B);

                this.screen_color.BackColor = color;
                this.rgbText.Text = "RGB:   " + color.R.ToString() + " , " + color.G.ToString() + " , " + color.B.ToString();
                this.hexText.Text = "HEX:   " + GetHexadecimalString(color.R).Substring(0, 2) + GetHexadecimalString(color.G).Substring(0, 2) + GetHexadecimalString(color.B).Substring(0, 2);
                this.hslText.Text = "HSL:   " + HSL_H.ToString() + "°" + " , " + HSL_S.ToString() + "%" +  ", "+ HSL_L.ToString() + "%";
                this.hsvText.Text = "HSV:   " + HSV_H.ToString() + "°" + " , " + HSV_S.ToString() + "%" + ", " + HSV_V.ToString() + "%";
                this.cmykText.Text = "CMYK:   " + CMYK_C.ToString() + " , " + CMYK_M.ToString() + " , " + CMYK_Y.ToString() + " , " + CMYK_K.ToString();
            }
        }

        private void screen_timer_Tick(object sender, EventArgs e)
        {
            Size size = new Size(screen.Width, screen.Height);

            // 두 배 크기의 비트맵 생성
            Bitmap bitmap = new Bitmap(size.Width * 2, size.Height * 2);
            Graphics graphics = Graphics.FromImage(bitmap);

            // 원본 화면을 캡처
            Bitmap original = new Bitmap(size.Width, size.Height);
            Graphics originalGraphics = Graphics.FromImage(original);
            originalGraphics.CopyFromScreen(MousePosition.X - 34, MousePosition.Y - 34, 0, 0, size, CopyPixelOperation.SourceCopy);

            // 캡처한 이미지를 두 배 크기로 확대하여 새 이미지에 그리기
            graphics.DrawImage(original, 0, 0, original.Width * 2, original.Height * 2);

            // 확대된 이미지를 화면에 표시
            screen.Image = bitmap;

            // 마우스 좌표 표시
            xPosition.Text = "X: " + MousePosition.X.ToString();
            yPosition.Text = "Y: " + MousePosition.Y.ToString();
        }



        private void screen_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.DrawLine(Pens.Red, 69, 138, 69, 0);
            g.DrawLine(Pens.Red, -69, 69, 138, 69);
            g.DrawLine(Pens.Red, 0, 0, 138, 0);
            g.DrawLine(Pens.Red, 0, 0, 0, 138);
            g.DrawLine(Pens.Red, 0, 137, 137, 137);
            g.DrawLine(Pens.Red, 137, 0, 137, 137);
        }

        private void screen_color_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.DrawLine(Pens.Red, 0, 0, screen_color.Size.Width, 0);
            g.DrawLine(Pens.Red, 0, 0, 0, screen_color.Size.Width);
            g.DrawLine(Pens.Red, 0, screen_color.Size.Height - 1, screen_color.Size.Width - 1, screen_color.Size.Height - 1);
            g.DrawLine(Pens.Red, screen_color.Size.Width - 1, 0, screen_color.Size.Width - 1, screen_color.Size.Width - 1);
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.thread = new Thread(new ThreadStart(ProcessThread));
            this.thread.Start();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.thread != null && this.thread.IsAlive)
            {
                this.thread.Abort();
            }
        }

        private Color GetMousePointColor(Point mousePoint)
        {
            Size size = new Size(1, 1);
            Bitmap bitmap = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(mousePoint.X, mousePoint.Y, 0, 0, size);
            return bitmap.GetPixel(0, 0);
        }
    }
}
