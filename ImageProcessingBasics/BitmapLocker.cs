﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessingBasics
{
    public unsafe class BitmapLocker : IDisposable
    {
        private Bitmap bmp;
        private BitmapData bitmapData;
        byte* _imgPtr;
        int _bytesPerPixel;


        public BitmapData BitmapData { get => bitmapData; set => bitmapData = value; }

        public BitmapLocker(Bitmap bmp)
        {
            this.bmp = bmp;
            BitmapData = this.bmp.LockBits(new Rectangle(new Point(), bmp.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            _imgPtr = (byte*)BitmapData.Scan0.ToPointer();
            _bytesPerPixel = Bitmap.GetPixelFormatSize(BitmapData.PixelFormat) / 8;
        }

        public byte* GetPixel(int x, int y)
        {
            byte* _ = _imgPtr + x * _bytesPerPixel + y * BitmapData.Stride;
            return _;
        }

        public void Dispose()
        {
            bmp.UnlockBits(BitmapData);
        }
    }
}
