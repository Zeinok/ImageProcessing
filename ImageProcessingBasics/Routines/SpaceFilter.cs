using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace ImageProcessingBasics
{
    class SpaceFilter
    {
        public static Bitmap Median(Bitmap bmp) {
            Bitmap retBmp = new Bitmap(bmp.Width, bmp.Height);
            Dictionary<byte, long> Rcdf = new Dictionary<byte, long>(), Gcdf = new Dictionary<byte, long>(), Bcdf = new Dictionary<byte, long>();

            using(var bl = new BitmapLocker(bmp))
            using(var rbl = new BitmapLocker(retBmp)) {
                unsafe {
                    for(int y = 0; y < bmp.Height; y++) {
                        for(int x = 0; x < bmp.Width; x++) {
                            List<Color> colors = new List<Color>();
                            List<int> A = new List<int>();
                            List<int> R = new List<int>();
                            List<int> G = new List<int>();
                            List<int> B = new List<int>();
                            for(int dy = -1; dy < 1; dy++) {
                                if(y + dy < 0 || y + dy >= bmp.Height) continue;
                                for(int dx = -1; dx < 1; dx++) {
                                    if(x + dx < 0 || x + dx >= bmp.Width) continue;
                                    Color color = bl.GetPixelColor(x + dx, y + dy);
                                    colors.Add(color);
                                }
                            }
                            //colors = colors.Distinct().ToList();
                            colors.ForEach(c => {
                                A.Add(c.A);
                                R.Add(c.R);
                                G.Add(c.G);
                                B.Add(c.B);
                            });
                            A.Sort(); R.Sort(); G.Sort(); B.Sort();
                            int middle = (colors.Count - 1) / 2;
                            Color newColor = Color.FromArgb(A[middle], R[middle], G[middle], B[middle]);
                            int* ptr = rbl.GetPixelIntPtr(x, y);
                            *ptr = newColor.ToArgb();
                        }
                    }
                }
            }

            return retBmp;
        }
        public static Bitmap Mean(Bitmap bmp) {
            Bitmap retBmp = new Bitmap(bmp.Width, bmp.Height);
            Dictionary<byte, long> Rcdf = new Dictionary<byte, long>(), Gcdf = new Dictionary<byte, long>(), Bcdf = new Dictionary<byte, long>();

            using(var bl = new BitmapLocker(bmp))
            using(var rbl = new BitmapLocker(retBmp)) {
                unsafe {
                    for(int y = 0; y < bmp.Height; y++) {
                        for(int x = 0; x < bmp.Width; x++) {
                            
                            List<int> A = new List<int>();
                            List<int> R = new List<int>();
                            List<int> G = new List<int>();
                            List<int> B = new List<int>();
                            for(int dy = -1; dy < 1; dy++) {
                                if(y + dy < 0 || y + dy >= bmp.Height) continue;
                                for(int dx = -1; dx < 1; dx++) {
                                    if(x + dx < 0 || x + dx >= bmp.Width) continue;
                                    Color color = bl.GetPixelColor(x + dx, y + dy);
                                    A.Add(color.A);
                                    R.Add(color.R);
                                    G.Add(color.G);
                                    B.Add(color.B);

                                }
                            }
                            Color newColor = Color.FromArgb((int)A.Average(), (int)R.Average(), (int)G.Average(), (int)B.Average());
                            *rbl.GetPixelIntPtr(x, y) = newColor.ToArgb();
                        }
                    }
                }
            }

            return retBmp;
        }
        public static Bitmap Min(Bitmap bmp) {
            Bitmap retBmp = new Bitmap(bmp.Width, bmp.Height);
            Dictionary<byte, long> Rcdf = new Dictionary<byte, long>(), Gcdf = new Dictionary<byte, long>(), Bcdf = new Dictionary<byte, long>();

            using(var bl = new BitmapLocker(bmp))
            using(var rbl = new BitmapLocker(retBmp)) {
                unsafe {
                    for(int y = 0; y < bmp.Height; y++) {
                        for(int x = 0; x < bmp.Width; x++) {

                            List<int> A = new List<int>();
                            List<int> R = new List<int>();
                            List<int> G = new List<int>();
                            List<int> B = new List<int>();
                            for(int dy = -1; dy < 1; dy++) {
                                if(y + dy < 0 || y + dy >= bmp.Height) continue;
                                for(int dx = -1; dx < 1; dx++) {
                                    if(x + dx < 0 || x + dx >= bmp.Width) continue;
                                    Color color = bl.GetPixelColor(x + dx, y + dy);
                                    A.Add(color.A);
                                    R.Add(color.R);
                                    G.Add(color.G);
                                    B.Add(color.B);

                                }
                            }
                            Color newColor = Color.FromArgb(A.Min(), R.Min(), G.Min(), B.Min());
                            *rbl.GetPixelIntPtr(x, y) = newColor.ToArgb();
                        }
                    }
                }
            }

            return retBmp;
        }
        public static Bitmap Max(Bitmap bmp) {
            Bitmap retBmp = new Bitmap(bmp.Width, bmp.Height);
            Dictionary<byte, long> Rcdf = new Dictionary<byte, long>(), Gcdf = new Dictionary<byte, long>(), Bcdf = new Dictionary<byte, long>();

            using(var bl = new BitmapLocker(bmp))
            using(var rbl = new BitmapLocker(retBmp)) {
                unsafe {
                    for(int y = 0; y < bmp.Height; y++) {
                        for(int x = 0; x < bmp.Width; x++) {

                            List<int> A = new List<int>();
                            List<int> R = new List<int>();
                            List<int> G = new List<int>();
                            List<int> B = new List<int>();
                            for(int dy = -1; dy < 1; dy++) {
                                if(y + dy < 0 || y + dy >= bmp.Height) continue;
                                for(int dx = -1; dx < 1; dx++) {
                                    if(x + dx < 0 || x + dx >= bmp.Width) continue;
                                    Color color = bl.GetPixelColor(x + dx, y + dy);
                                    A.Add(color.A);
                                    R.Add(color.R);
                                    G.Add(color.G);
                                    B.Add(color.B);

                                }
                            }
                            Color newColor = Color.FromArgb(A.Max(), R.Max(), G.Max(), B.Max());
                            *rbl.GetPixelIntPtr(x, y) = newColor.ToArgb();
                        }
                    }
                }
            }

            return retBmp;
        }
    }
}
