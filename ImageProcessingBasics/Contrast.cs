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
                
                
            }
            throw new NotImplementedException();
        }
    }
}
