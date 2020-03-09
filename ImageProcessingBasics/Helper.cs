using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace ImageProcessingBasics
{
    class Helper
    {
        public static Bitmap deepCloneBMP(Bitmap bmp)
        {
            return new Bitmap(bmp.Clone(new Rectangle(new Point(), bmp.Size), bmp.PixelFormat), bmp.Size);
        }
        public static string GetImageFileFilter()
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty;
            string filter = "";
            foreach (var c in codecs)
            {
                string codecName = c.FormatDescription;
                filter = String.Format("{0}{1}{2} ({3})|{3}", filter, sep, codecName, c.FilenameExtension.ToLower());
                sep = "|";
            }
            filter = String.Format("{0}{1}{2} ({3})|{3}", filter, sep, "All Files", "*.*");
            return filter;
        }
        public static ImageFormat GetImageFormat(string fileName)
        {
            string extension = Path.GetExtension(fileName).ToLower();
            Debug.WriteLine("GetImageFormat: Extension: {0}", extension, null);
            string formatString = "";
            if (string.IsNullOrEmpty(extension))
                throw new ArgumentException(
                    string.Format("Unable to determine file extension for fileName: {0}", fileName));

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            foreach (var c in codecs)
                foreach (var f in c.FilenameExtension.ToLower().Split(';'))
                    if (extension == f.TrimStart('*'))
                        formatString = c.FormatDescription;

            switch (formatString)
            {
                case "BMP":
                    return ImageFormat.Bmp;
                case "JPG":
                    return ImageFormat.Jpeg;
                case "GIF":
                    return ImageFormat.Gif;
                case "TIFF":
                    return ImageFormat.Tiff;
                case "PNG":
                    return ImageFormat.Png;
                default:
                    throw new NotImplementedException();
            }
        }


    }
}
