using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_Image_to_Scenario_Converter
{
    public class ImgUtils
    {
        public static Bitmap PosterizeImage(Bitmap image, int colorLevels)
        {
            int scale = 256 / colorLevels,
                w = image.Width, h = image.Height;
            Bitmap newImage = new(w,h);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Color originalColor = image.GetPixel(x, y);

                    int r = PosterizeChannel(originalColor.R, scale);
                    int g = PosterizeChannel(originalColor.G, scale);
                    int b = PosterizeChannel(originalColor.B, scale);

                    Color newColor = Color.FromArgb(r, g, b);
                    newImage.SetPixel(x, y, newColor);
                }
            }

            return newImage;
        }

        static int PosterizeChannel(int channelValue, int scale)
        {
            int lowerBound = (channelValue / scale) * scale;
            int upperBound = lowerBound + scale;
            int midpoint = (lowerBound + upperBound) / 2;

            return Math.Min(255, midpoint);
        }

        public static Color FindNeighours(Bitmap image,int x, int y)
        {
            int h = image.Height;
            int w = image.Width;
            Point target = new(x, y);
            Color current;

            List<Point> neighbours = 
                [
                new Point(Math.Max(0,x-1),Math.Max(0,y-1)),
                new Point(x,Math.Max(0,y-1)),
                new Point(Math.Min(w-1,x+1),Math.Max(0,y-1)),

                new Point(Math.Max(0,x-1),y),
                new Point(Math.Min(w-1,x+1),y),

                new Point(Math.Max(0,x-1),Math.Min(h-1,y+1)),
                new Point(x,Math.Min(h-1,y+1)),
                new Point(Math.Min(w-1,x+1),Math.Min(h-1,y+1)),
                ];
            while (neighbours.Remove(target)) { }

            List<Color> neighbourcolors = [];
            foreach (Point p in neighbours.Distinct())
            {
                current = image.GetPixel(p.X, p.Y);
                neighbourcolors.Add(current);
            }
            return neighbourcolors.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;
        }

        public static Bitmap GetFlags(List<int[]> countries)
        {
            int h = Math.Min(countries.Count, 10) * 24;
            Bitmap output = new Bitmap(((countries.Count-1)/10+1)*36,h);
            foreach (int[] c in countries)
            {
                c[0]--;
            }

            foreach (int[] c in countries)
            {
                for (int y = h - 24 * (c[0]%10+1); y < h - 24 * (c[0]%10); y++)
                {
                    for(int x = 36*(c[0] / 10); x<36* (c[0] / 10+1); x++)
                    {
                        output.SetPixel(x, y, Color.FromArgb(c[3], c[4], c[5]));
                    }
                }
            }
            foreach (int[] c in countries)
            {
                c[0]++;
            }
            return output;
        }
    }
}