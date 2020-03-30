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
                            byte* oldPixel = bl.GetPixel(x, y);
                            byte* newPixel = rbl.GetPixel(x, y);
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
                            byte* oldPixel = bl.GetPixel(x, y);
                            byte* newPixel = rbl.GetPixel(x, y);
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
                            byte* oldPixel = bl.GetPixel(x, y);
                            byte* newPixel = rbl.GetPixel(x, y);
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
