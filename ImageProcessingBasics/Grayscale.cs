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
        static Bitmap Mean(Bitmap input)
        {
            Bitmap retBmp = new Bitmap(input.Width, input.Height);
            unsafe
            {
                //original bmp
                BitmapData bd = input.LockBits(new Rectangle(new Point(), input.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                byte* imgPtr = (byte*)bd.Scan0.ToPointer();
                int bytesPerPixel = Bitmap.GetPixelFormatSize(bd.PixelFormat) / 8;
                byte[] rawBmp = new byte[bd.Stride * input.Height];
                //new bmp
                BitmapData newBD = input.LockBits(new Rectangle(new Point(), retBmp.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                byte* newImgPtr = (byte*)newBD.Scan0.ToPointer();
                int newBytesPerPixel = Bitmap.GetPixelFormatSize(newBD.PixelFormat) / 8;
                byte[] newRawBmp = new byte[newBD.Stride * input.Height];
                //start processing
                for (int y = 0; y < bd.Height; y++)
                {
                    for (int x = 0; x < bd.Width; x++)
                    {
                        byte* pixel = imgPtr + x * bytesPerPixel + y * bd.Stride;
                        byte* newPixel = newImgPtr + x * bytesPerPixel + y * newBD.Stride;
                        int mean = pixel[2] + pixel[1] + pixel[0];
                        mean /= 3;
                        mean &= 0xFF;
                        for (int i = 0; i < 3; i++)
                            newPixel[i] = (byte)mean;
                    }
                }
                input.UnlockBits(bd);
                retBmp.UnlockBits(newBD);

            }
            return retBmp;
            throw new NotImplementedException();
        }
        static Bitmap Max(Bitmap bmp)
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
                        byte pixelColor = 0, R, G, B;
                        for (int i = 0; i < 4; i++)
                            newPixel[i] = 255;
                        B = pixel[0];
                        G = pixel[1];
                        R = pixel[2];

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

            throw new NotImplementedException();
        }
        static Bitmap Min(Bitmap input)
        {
            Bitmap retBmp = new Bitmap(input.Width, input.Height);
            unsafe
            {
                BitmapData bd = input.LockBits(new Rectangle(new Point(), input.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                byte* imgPtr = (byte*)bd.Scan0.ToPointer();
                int bytesPerPixel = Bitmap.GetPixelFormatSize(bd.PixelFormat) / 8;
                byte[] rawBmp = new byte[bd.Stride * input.Height];
                for (int y = 0; y < bd.Height; y++)
                {
                    for (int x = 0; x < bd.Width; x++)
                    {
                    }
                }
            }
            throw new NotImplementedException();
        }
    }
}
