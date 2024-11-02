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
                new Point(Math.Min(w,x+1),Math.Max(0,y-1)),

                new Point(Math.Max(0,x-1),y),
                new Point(Math.Min(w,x+1),y),

                new Point(Math.Max(0,x-1),Math.Min(h,y+1)),
                new Point(x,Math.Min(h,y+1)),
                new Point(Math.Min(w,x+1),Math.Min(h,y+1)),
                ];
            while (neighbours.Contains(target))
            {
                neighbours.Remove(target);
            }

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
    }
}