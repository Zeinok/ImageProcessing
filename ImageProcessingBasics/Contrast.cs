using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace ImageProcessingBasics
{
    class Contrast
    {
        public static Bitmap HistogramEqualization(Bitmap bmp)
        {
            Bitmap retBmp = new Bitmap(bmp.Width, bmp.Height);
            Dictionary<byte, long> Rcdf = new Dictionary<byte, long>(), Gcdf = new Dictionary<byte, long>(), Bcdf = new Dictionary<byte, long>();
            
            using (var bl = new BitmapLocker(bmp))
            using (var rbl = new BitmapLocker(retBmp))
            {
                unsafe
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        for (int x = 0; x < bmp.Width; x++)
                        {
                            Color c = bl.GetPixelColor(x, y);
                            if (!Rcdf.ContainsKey(c.R)) Rcdf.Add(c.R, 0);
                            Rcdf[c.R]++;
                            if (!Gcdf.ContainsKey(c.G)) Gcdf.Add(c.G, 0);
                            Gcdf[c.G]++;
                            if (!Bcdf.ContainsKey(c.B)) Bcdf.Add(c.B, 0);
                            Bcdf[c.B]++;
                        }
                    }
                }
                // actual cdf processing
                long sumR, sumG, sumB;
                sumB = sumG = sumR = 0;
                for(int i = 0; i < 256; ++i)
                {
                    byte bytei = (byte)i;
                    if (Rcdf.ContainsKey(bytei))
                    {
                        Rcdf[bytei] += sumR;
                        sumR = Rcdf[bytei];
                    }
                    if (Gcdf.ContainsKey(bytei))
                    {
                        Gcdf[bytei] += sumG;
                        sumG = Gcdf[bytei];
                    }
                    if (Bcdf.ContainsKey(bytei))
                    {
                        Bcdf[bytei] += sumB;
                        sumB = Bcdf[bytei];
                    }
                }
                // draw retBmp
                long totalPixels = retBmp.Width * retBmp.Height;
                unsafe
                {
                    for (int y = 0; y < retBmp.Height; y++)
                    {
                        for (int x = 0; x < retBmp.Width; x++)
                        {

                            Color oldColor = bl.GetPixelColor(x, y);
                            int* newColorIntPtr = rbl.GetPixelIntPtr(x, y);
                            int R, G, B;
                            R = (int)Math.Round(Rcdf[oldColor.R] * 255.0/ totalPixels);
                            G = (int)Math.Round(Gcdf[oldColor.G] * 255.0 / totalPixels);
                            B = (int)Math.Round(Bcdf[oldColor.B] * 255.0 / totalPixels);
                            Color newColor = Color.FromArgb(oldColor.A, R, G, B);
                            *newColorIntPtr = newColor.ToArgb();
                        }
                    }
                }
            }
            return retBmp;
        }
        public static Bitmap Negative(Bitmap bmp)
        {
            Bitmap retBmp = new Bitmap(bmp.Width, bmp.Height);

            using (var bl = new BitmapLocker(bmp))
            using (var rbl = new BitmapLocker(retBmp))
            {
                unsafe
                {
                    for(int y = 0; y < bmp.Height; y++)
                    {
                        for(int x = 0; x < bmp.Width; x++)
                        {
                            byte* oldPixel = bl.GetPixelPtr(x, y);
                            byte* newPixel = rbl.GetPixelPtr(x, y);
                            for (int i = 0; i < 3; i++) newPixel[i] = (byte)(255 - oldPixel[i]);
                            newPixel[3] = 255;
                        }
                    }
                }
                
            }
            return retBmp;
        }

        public static Bitmap LogTransform(double c, Bitmap bmp)
        {
            Bitmap retBmp = new Bitmap(bmp.Width, bmp.Height);

            using (var bl = new BitmapLocker(bmp))
            using (var rbl = new BitmapLocker(retBmp))
            {
                unsafe
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        for (int x = 0; x < bmp.Width; x++)
                        {
                            byte* oldPixel = bl.GetPixelPtr(x, y);
                            byte* newPixel = rbl.GetPixelPtr(x, y);
                            for (int i = 0; i < 3; i++)
                            {
                                double val = c * Math.Log(1 + oldPixel[i]);
                                if (val < 0) val = 0;
                                if (val > 255) val = 255;
                                newPixel[i] = (byte)(Math.Round(val));
                            }
                            newPixel[3] = 255;
                        }
                    }
                }

            }
            return retBmp;
        }

        public static Bitmap PowerLawTransform(double c, double gamma, Bitmap bmp)
        {
            Bitmap retBmp = new Bitmap(bmp.Width, bmp.Height);

            using (var bl = new BitmapLocker(bmp))
            using (var rbl = new BitmapLocker(retBmp))
            {
                unsafe
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        for (int x = 0; x < bmp.Width; x++)
                        {
                            byte* oldPixel = bl.GetPixelPtr(x, y);
                            byte* newPixel = rbl.GetPixelPtr(x, y);
                            for (int i = 0; i < 3; i++)
                            {
                                double val = c * Math.Pow(oldPixel[i],gamma);
                                if (val < 0) val = 0;
                                if (val > 255) val = 255;
                                newPixel[i] = (byte)(Math.Round(val));
                            }
                            newPixel[3] = 255;
                        }
                    }
                }

            }
            return retBmp;
        }
    }
}
