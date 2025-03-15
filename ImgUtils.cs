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
            Bitmap newImage = new(image.Width, image.Height);
            int scale = 256 / colorLevels;

            // Iterate over each pixel of the image
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color originalColor = image.GetPixel(x, y);

                    int red = PosterizeChannel(originalColor.R, scale);
                    int green = PosterizeChannel(originalColor.G, scale);
                    int blue = PosterizeChannel(originalColor.B, scale);

                    Color newColor = Color.FromArgb(red, green, blue);
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
                if (current.R == current.G && current.R == current.B)
                    continue;
                neighbourcolors.Add(current);
            }
            if (neighbourcolors.Count == 0) return Color.Black;
            return neighbourcolors.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;
        }

        public static Bitmap GetFlags(List<int[]> countries)
        {
            Bitmap output = new Bitmap(((countries.Count-1)/10+1)*36,240);
            foreach (int[] c in countries)
            {
                c[0]--;
            }

            foreach (int[] c in countries)
            {
                for (int y = 240 - 24 * (c[0]%10+1); y < 240 - 24 * (c[0]%10); y++)
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