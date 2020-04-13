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
    class Grayscale
    {
        public static Bitmap MeanWeight(Bitmap input)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Bitmap retBmp = new Bitmap(input.Width, input.Height);
            unsafe
            {
                //original bmp
                BitmapData bd = input.LockBits(new Rectangle(new Point(), input.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                byte* imgPtr = (byte*)bd.Scan0.ToPointer();
                int bytesPerPixel = Bitmap.GetPixelFormatSize(bd.PixelFormat) / 8;
                //new bmp
                BitmapData newBD = retBmp.LockBits(new Rectangle(new Point(), retBmp.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                byte* newImgPtr = (byte*)newBD.Scan0.ToPointer();
                int newBytesPerPixel = Bitmap.GetPixelFormatSize(newBD.PixelFormat) / 8;
                //start processing
                for (int y = 0; y < bd.Height; y++)
                {
                    for (int x = 0; x < bd.Width; x++)
                    {
                        byte* pixel = imgPtr + x * bytesPerPixel + y * bd.Stride;
                        byte* newPixel = newImgPtr + x * newBytesPerPixel + y * newBD.Stride;
                        int mean = (int)Math.Round(pixel[2] * 0.299 + pixel[1] * 0.587 + pixel[0] * 0.114);
                        if (mean > 255) mean = 255;
                        for (int i = 0; i < 4; i++)
                            newPixel[i] = 255;
                        for (int i = 0; i < 3; i++)
                            newPixel[i] = (byte)mean;
                    }
                }
                input.UnlockBits(bd);
                retBmp.UnlockBits(newBD);

            }
            sw.Stop();
            Debug.Print("Grayscale.MeanWeight(Bitmap bmp): {0}", sw.Elapsed);
            return retBmp;
            throw new NotImplementedException();
        }

        public static Bitmap MeanValue(Bitmap input)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Bitmap retBmp = new Bitmap(input.Width, input.Height);
            unsafe
            {
                //original bmp
                BitmapData bd = input.LockBits(new Rectangle(new Point(), input.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                byte* imgPtr = (byte*)bd.Scan0.ToPointer();
                int bytesPerPixel = Bitmap.GetPixelFormatSize(bd.PixelFormat) / 8;
                //new bmp
                BitmapData newBD = retBmp.LockBits(new Rectangle(new Point(), retBmp.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                byte* newImgPtr = (byte*)newBD.Scan0.ToPointer();
                int newBytesPerPixel = Bitmap.GetPixelFormatSize(newBD.PixelFormat) / 8;
                //start processing
                for (int y = 0; y < bd.Height; y++)
                {
                    for (int x = 0; x < bd.Width; x++)
                    {
                        byte* pixel = imgPtr + x * bytesPerPixel + y * bd.Stride;
                        byte* newPixel = newImgPtr + x * newBytesPerPixel + y * newBD.Stride;
                        int mean = (int)Math.Round((double)(pixel[2] + pixel[1] + pixel[0])/3.0, MidpointRounding.AwayFromZero);
                        if (mean > 255) mean = 255;
                        for (int i = 0; i < 4; i++)
                            newPixel[i] = 255;
                        for (int i = 0; i < 3; i++)
                            newPixel[i] = (byte)mean;
                    }
                }
                input.UnlockBits(bd);
                retBmp.UnlockBits(newBD);

            }
            sw.Stop();
            Debug.Print("Grayscale.MeanValue(Bitmap bmp): {0}", sw.Elapsed);
            return retBmp;
            throw new NotImplementedException();
        }
        public static Bitmap Max(Bitmap bmp)
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
                //new bmp
                BitmapData newBD = retBmp.LockBits(new Rectangle(new Point(), retBmp.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                byte* newImgPtr = (byte*)newBD.Scan0.ToPointer();
                int newBytesPerPixel = Bitmap.GetPixelFormatSize(newBD.PixelFormat) / 8;
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
                        for (int i = 0; i < 3; i++)
                            if (pixelColor < pixel[i]) pixelColor = pixel[i];
                        for (int i = 0; i < 3; i++)
                            newPixel[i] = pixelColor;
                    }
                }

                bmp.UnlockBits(bd);
                retBmp.UnlockBits(newBD);
            }
            sw.Stop();
            Debug.Print("Grayscale.Max(Bitmap bmp): {0}", sw.Elapsed);
            return retBmp;

            throw new NotImplementedException();
        }


    }
}
