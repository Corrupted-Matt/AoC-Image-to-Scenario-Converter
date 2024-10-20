using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AoC_Image_to_Scenario_Converter.MainUI;

namespace AoC_Image_to_Scenario_Converter
{
    internal class BasicMode
    {
        public static StreamWriter Generate(Bitmap Input1, string destination, string name, IProgress<double> progress)
        {
            Directory.CreateDirectory(destination + $"\\{name}");
            StreamWriter output = new(destination+ $"\\{name}\\{name}.aoc");
            int w = Input1.Width;
            int h = Input1.Height;
            int p = 0;
            Color CurrentRGB;

            output.Write($"{{\"version\":\"3.4.2\",\"width\":{Input1.Width},\"height\":{Input1.Height},\"startingYear\":0,\"currentGameTime\":0,\"nations\":[],\"cities\":[],\"alliances\":[],\"wars\":[],\"terrain\":[");

            for (int y = h-1; y >= 0; y--)
            {
                for (int x = 0; x < w; x++)
                {
                    CurrentRGB = Input1.GetPixel(x, y);
                    float currentBrightness = CurrentRGB.GetBrightness();

                    if (currentBrightness <= 0.061) output.Write("1");
                    else if (currentBrightness <= 0.161) output.Write("6");
                    else if (currentBrightness <= 0.3) output.Write("4");
                    else if (currentBrightness <= 0.5) output.Write("3");
                    else if (currentBrightness <= 0.7) output.Write("5");
                    else if (currentBrightness <= 0.9) output.Write("2");
                    else output.Write("0");
                    p++;
                    if (p < w * h) output.Write(",");
                }
                progress.Report((h - y) / (double)h * 25 + 50);
            }

            output.Write("],\"owner\":[");
            p = 0;

            for (int i = 1; i <= w * h; i++)
            {
                output.Write("0");
                p++;
                if (p < w * h) output.Write(",");
                progress.Report((double)i / (w * h) * 25 + 75);
            }

            output.Write("]}");
            output.Close();
            progress.Report(100);

            return output;
        }
    }
}
