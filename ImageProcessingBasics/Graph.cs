using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace ImageProcessingBasics
{
    class Graph
    {
        public static Bitmap[] getRGBGraph(Bitmap bmp)
        {
            Bitmap[] retBmp = new Bitmap[3]; // init bmp
            for (int i = 0; i < retBmp.Length; i++)
                retBmp[i] = new Bitmap(256, 100);

            ulong[] red = new ulong[256];
            ulong[] green = new ulong[256];
            ulong[] blue = new ulong[256];

            ulong redMax = 0;
            ulong greenMax = 0;
            ulong blueMax = 0;

            // read max rgb value
            unsafe
            {
                BitmapData bd = bmp.LockBits(new Rectangle(new Point(), bmp.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                byte* imgPtr = (byte*)bd.Scan0.ToPointer();
                int bytesPerPixel = Bitmap.GetPixelFormatSize(bd.PixelFormat) / 8;
                byte[] rawBmp = new byte[bd.Stride * bmp.Height];
                for (int y = 0; y < bd.Height; y++)
                {
                    for (int x = 0; x < bd.Width; x++)
                    {
                        byte* pixel = imgPtr + x * bytesPerPixel + y * bd.Stride;
                        red[pixel[2]]++;
                        green[pixel[1]]++;
                        blue[pixel[0]]++;
                        if (redMax < red[pixel[2]]) redMax = red[pixel[2]];
                        if (greenMax < green[pixel[1]]) greenMax = green[pixel[1]];
                        if (blueMax < blue[pixel[0]]) blueMax = blue[pixel[0]];
                    }
                }
                bmp.UnlockBits(bd);
            }

            Debug.WriteLine("RBG Max: {0}, {1}, {2}", redMax, greenMax, blueMax);

            // round to 0~100
            for (int i = 0; i < 256; i++)
            {
                red[i] = red[i] * 100 / redMax;
                green[i] = green[i] * 100 / greenMax;
                blue[i] = blue[i] * 100 / blueMax;
            }

            // draw
            Graphics g = null;
            int baseY = retBmp[0].Height - 1;
            Point basePoint = new Point(0, retBmp[0].Height - 1);
            Point endPoint = new Point(retBmp[0].Width - 1, retBmp[0].Height - 1);
            List<Point> points = new List<Point>();

            points.Clear();
            points.Add(basePoint);
            g = Graphics.FromImage(retBmp[0]);
            for (int i = 0; i < 256; i++) // R
            {
                points.Add(new Point(i, baseY - (int)red[i]));
            }
            points.Add(endPoint);
            g.FillClosedCurve(Brushes.Red, points.ToArray());

            points.Clear();
            points.Add(basePoint);
            g = Graphics.FromImage(retBmp[1]);
            for (int i = 0; i < 256; i++) // G
            {
                points.Add(new Point(i, baseY - (int)green[i]));
            }
            points.Add(endPoint);
            g.FillClosedCurve(Brushes.Green, points.ToArray());

            points.Clear();
            points.Add(basePoint);
            g = Graphics.FromImage(retBmp[2]);
            for (int i = 0; i < 256; i++) // B
            {
                points.Add(new Point(i, baseY - (int)blue[i]));
            }
            points.Add(endPoint);
            g.FillClosedCurve(Brushes.Blue, points.ToArray());

            return retBmp;
        }
    }
}
