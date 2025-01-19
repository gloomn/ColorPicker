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
            // GlobalKeyboardHook 인스턴스 생성
            // Initialize global keyboard hook
            _keyboardHook = new GlobalKeyboardHook();
            _keyboardHook.KeyDownEvent += OnGlobalKeyDown;

            this.FormClosing += MainForm_FormClosing;
        }

        private GlobalKeyboardHook _keyboardHook;
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _keyboardHook.Dispose();
            if (this.thread != null && this.thread.IsAlive)
            {
                this.thread.Abort();
            }
        }

        private void OnGlobalKeyDown(Keys key)
        {
            // Check for a specific key combination (e.g., Ctrl+Shift+C)
            if (key == Keys.C && ModifierKeys.HasFlag(Keys.Control) && ModifierKeys.HasFlag(Keys.Shift))
            {
                // Capture the current screen color under the mouse
                var color = GetColorAtCursor();

                // Display the color in a message box (or update a UI element)
                MessageBox.Show($"Color at cursor: {color}", "Color Picker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Color GetColorAtCursor()
        {
            // Get the cursor position
            var cursorPos = Cursor.Position;

            // Capture a single pixel at the cursor position
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(cursorPos, Point.Empty, new Size(1, 1));
                }

                return bitmap.GetPixel(0, 0);
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

            // Round C, M, Y, K to 2 decimal places
            C = Math.Round(C, 2);
            M = Math.Round(M, 2);
            Y = Math.Round(Y, 2);
            K = Math.Round(K, 2);

            return (C, M, Y, K);
        }


        public (double L, double A, double B) RGBToCIELAB(int rgb_r, int rgb_g, int rgb_b)
        {
            // Step 1: Normalize RGB to the range [0, 1]
            double r = rgb_r / 255.0;
            double g = rgb_g / 255.0;
            double b = rgb_b / 255.0;

            // Step 2: Apply the RGB to XYZ transformation
            r = (r > 0.04045) ? Math.Pow((r + 0.055) / 1.055, 2.4) : r / 12.92;
            g = (g > 0.04045) ? Math.Pow((g + 0.055) / 1.055, 2.4) : g / 12.92;
            b = (b > 0.04045) ? Math.Pow((b + 0.055) / 1.055, 2.4) : b / 12.92;

            // Convert RGB to XYZ (using D65 illuminant)
            double x = r * 0.4124564 + g * 0.3575761 + b * 0.1804375;
            double y = r * 0.2126729 + g * 0.7151522 + b * 0.0721750;
            double z = r * 0.0193339 + g * 0.1191920 + b * 0.9503041;

            // Step 3: Normalize XYZ to D65 reference white
            double refX = 0.95047;
            double refY = 1.00000;
            double refZ = 1.08883;

            x = x / refX;
            y = y / refY;
            z = z / refZ;

            // Step 4: Convert XYZ to CIE LAB
            double fX = (x > 0.008856) ? Math.Pow(x, 1.0 / 3.0) : (903.3 * x + 16) / 116.0;
            double fY = (y > 0.008856) ? Math.Pow(y, 1.0 / 3.0) : (903.3 * y + 16) / 116.0;
            double fZ = (z > 0.008856) ? Math.Pow(z, 1.0 / 3.0) : (903.3 * z + 16) / 116.0;

            double L = (116 * fY) - 16;
            double A = 500 * (fX - fY);
            double B = 200 * (fY - fZ);

            // Round L, A, and B to 2 decimal places
            L = Math.Round(L, 2);
            A = Math.Round(A, 2);
            B = Math.Round(B, 2);

            // Return CIE LAB values
            return (L, A, B);
        }

        public (double X, double Y, double Z) RGBToXYZ(int rgb_r, int rgb_g, int rgb_b)
        {
            // Normalize RGB values to the range 0-1
            double r = rgb_r / 255.0;
            double g = rgb_g / 255.0;
            double b = rgb_b / 255.0;

            // Apply gamma correction (sRGB to linear RGB)
            r = (r <= 0.04045) ? r / 12.92 : Math.Pow((r + 0.055) / 1.055, 2.4);
            g = (g <= 0.04045) ? g / 12.92 : Math.Pow((g + 0.055) / 1.055, 2.4);
            b = (b <= 0.04045) ? b / 12.92 : Math.Pow((b + 0.055) / 1.055, 2.4);

            // Convert to XYZ using the RGB to XYZ transformation matrix
            double X = (r * 0.4124564 + g * 0.3575761 + b * 0.1804375);
            double Y = (r * 0.2126729 + g * 0.7151522 + b * 0.0721750);
            double Z = (r * 0.0193339 + g * 0.1191920 + b * 0.9503041);

            // Round the results to 3 decimal places
            X = Math.Round(X, 3);
            Y = Math.Round(Y, 3);
            Z = Math.Round(Z, 3);

            return (X, Y, Z);
        }

        public (double Y, double U, double V) RGBToYUV(int R, int G, int B)
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            double Y = 0.299 * r + 0.587 * g + 0.114 * b;
            double U = -0.14713 * r - 0.28886 * g + 0.436 * b;
            double V = 0.615 * r - 0.51499 * g - 0.10001 * b;

            Y = Math.Round(Y * 255, 0);
            U = Math.Round(U * 255, 0);
            V = Math.Round(V * 255, 0);

            return (Y, U, V);
        }

        public (double Y, double Cb, double Cr) RGBToYCbCr(int R, int G, int B)
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            double Y = 0.299 * r + 0.587 * g + 0.114 * b;
            double Cb = -0.168736 * r - 0.331264 * g + 0.5 * b + 0.5;
            double Cr = 0.5 * r - 0.418688 * g - 0.081312 * b + 0.5;

            Y = Math.Round(Y * 255, 0);
            Cb = Math.Round(Cb * 255, 0);
            Cr = Math.Round(Cr * 255, 0);

            return (Y, Cb, Cr);
        }

        public (double L, double C, double H) RGBToLCH(int R, int G, int B)
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            double X = r * 0.4124564 + g * 0.3575761 + b * 0.1804375;
            double Y = r * 0.2126729 + g * 0.7151522 + b * 0.0721750;
            double Z = r * 0.0193339 + g * 0.1191920 + b * 0.9503041;

            double Xn = 0.95047;
            double Yn = 1.00000;
            double Zn = 1.08883;

            X /= Xn;
            Y /= Yn;
            Z /= Zn;

            X = X > 0.008856 ? Math.Pow(X, 1.0 / 3.0) : (X - 0.137931) / 7.787;
            Y = Y > 0.008856 ? Math.Pow(Y, 1.0 / 3.0) : (Y - 0.137931) / 7.787;
            Z = Z > 0.008856 ? Math.Pow(Z, 1.0 / 3.0) : (Z - 0.137931) / 7.787;

            double L = (116 * Y) - 16;
            double C = Math.Sqrt(Math.Pow((X - Y), 2) + Math.Pow((Y - Z), 2));
            double H = Math.Atan2(Y - Z, X - Y) * (180 / Math.PI);
            if (H < 0) H += 360;

            L = Math.Round(L, 1);
            C = Math.Round(C, 2);
            H = Math.Round(H, 2);

            return (L, C, H);
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
                var (CIELAB_L, CIELAB_A, CIELAB_B) = RGBToCIELAB(color.R, color.G, color.B);
                var (XYZ_X, XYZ_Y, XYZ_Z) = RGBToXYZ(color.R, color.G, color.B);
                var (YUV_Y, YUV_U, YUV_V) = RGBToYUV(color.R, color.G, color.B);
                var (YCbCr_Y, YCbCr_Cb, YCbCr_Cr) = RGBToYCbCr(color.R, color.G, color.B);
                var (LCH_L, LCH_C, LCH_H) = RGBToLCH(color.R, color.G, color.B);

                this.screen_color.BackColor = color;
                this.rgbText.Text = "RGB:   " + color.R.ToString() + " , " + color.G.ToString() + " , " + color.B.ToString();
                this.hexText.Text = "HEX:   " + GetHexadecimalString(color.R).Substring(0, 2) + GetHexadecimalString(color.G).Substring(0, 2) + GetHexadecimalString(color.B).Substring(0, 2);
                this.hslText.Text = "HSL:   " + HSL_H.ToString() + "°" + " , " + HSL_S.ToString() + "%" +  ", "+ HSL_L.ToString() + "%";
                this.hsvText.Text = "HSV:   " + HSV_H.ToString() + "°" + " , " + HSV_S.ToString() + "%" + ", " + HSV_V.ToString() + "%";
                this.cmykText.Text = "CMYK:   " + CMYK_C.ToString() + " , " + CMYK_M.ToString() + " , " + CMYK_Y.ToString() + " , " + CMYK_K.ToString();
                this.cielabText.Text = "CIELAB:   " + CIELAB_L.ToString() + " , " + CIELAB_A.ToString() + " , " + CIELAB_B.ToString();
                this.xyzText.Text = "XYZ:   " + XYZ_X.ToString() + " , " + XYZ_Y.ToString() + " , " + XYZ_Z.ToString();
                this.yuvText.Text = "YUV:   " + YUV_Y.ToString() + " , " + YUV_U.ToString() + " , " + YUV_V.ToString();
                this.ycbcrText.Text = "YCbCr:   " + YCbCr_Y.ToString() + " , " + YCbCr_Cb.ToString() + " , " + YCbCr_Cr.ToString();
                this.lchText.Text = "LCH:   " + LCH_L.ToString() + " , " + LCH_C.ToString() + " , " + LCH_H.ToString();
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
