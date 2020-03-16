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
        public enum Color
        {
            B = 0,
            G = 1,
            R = 2
        }
        public static Bitmap[] GetRGBGraph(Bitmap bmp)
        {

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
            bmp.Dispose();
            Debug.WriteLine("RBG Max: {0}, {1}, {2}", redMax, greenMax, blueMax);

            // round to 0~100
            for (int i = 0; i < 256; i++)
            {
                red[i] = red[i] * 100 / redMax;
                green[i] = green[i] * 100 / greenMax;
                blue[i] = blue[i] * 100 / blueMax;
            }

            Bitmap[] retBmp = new Bitmap[3]; // init bmp
            for (int i = 0; i < retBmp.Length; i++)
                retBmp[i] = new Bitmap(256, 100);

            // draw
            Graphics g = null;
            int baseY = retBmp[0].Height - 1;
            Point basePoint = new Point(0, retBmp[0].Height);
            Point endPoint = new Point(retBmp[0].Width, retBmp[0].Height);
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
            red = null;

            points.Clear();
            points.Add(basePoint);
            g = Graphics.FromImage(retBmp[1]);
            for (int i = 0; i < 256; i++) // G
            {
                points.Add(new Point(i, baseY - (int)green[i]));
            }
            points.Add(endPoint);
            g.FillClosedCurve(Brushes.Green, points.ToArray());
            green = null;

            points.Clear();
            points.Add(basePoint);
            g = Graphics.FromImage(retBmp[2]);
            for (int i = 0; i < 256; i++) // B
            {
                points.Add(new Point(i, baseY - (int)blue[i]));
            }
            points.Add(endPoint);
            g.FillClosedCurve(Brushes.Blue, points.ToArray());
            blue = null;

            return retBmp;
        }
    
    public static Bitmap GetRGBImage(Bitmap bmp, Color color)
    {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Bitmap retBmp = new Bitmap(bmp.Width, bmp.Height);
            unsafe
            {
                //original bmp
                BitmapData bd = bmp.LockBits(new Rectangle(new Point(), bmp.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                byte* imgPtr = (byte*)bd.Scan0.ToPointer();
                int bytesPerPixel = Bitmap.GetPixelFormatSize(bd.PixelFormat) / 8;
                byte[] rawBmp = new byte[bd.Stride * bmp.Height];
                //new bmp
                BitmapData newBD = retBmp.LockBits(new Rectangle(new Point(), retBmp.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                byte* newImgPtr = (byte*)newBD.Scan0.ToPointer();
                int newBytesPerPixel = Bitmap.GetPixelFormatSize(newBD.PixelFormat) / 8;
                byte[] newRawBmp = new byte[newBD.Stride * retBmp.Height];
                //start processing
                for (int y = 0; y < bd.Height; y++)
                {
                    for (int x = 0; x < bd.Width; x++)
                    {
                        byte* pixel = imgPtr + x * bytesPerPixel + y * bd.Stride;
                        byte* newPixel = newImgPtr + x * newBytesPerPixel + y * newBD.Stride;
                        byte pixelColor = 0;
                        for (int i = 0; i < 4; i++)
                            newPixel[i] = 255;
                        switch (color)
                        {
                            case Color.B:
                                pixelColor = pixel[0];
                                break;
                            case Color.G:
                                pixelColor = pixel[1];
                                break;
                            case Color.R:
                                pixelColor = pixel[2];
                                break;
                        }
                        for (int i = 0; i < 3; i++)
                            newPixel[i] = pixelColor;
                    }
                }
                
                bmp.UnlockBits(bd);
                retBmp.UnlockBits(newBD);
            }
            sw.Stop();
            Debug.Print("GetRGBImage(Bitmap bmp, Color color): {0}", sw.Elapsed);
            return retBmp;
        } 
    }
}
