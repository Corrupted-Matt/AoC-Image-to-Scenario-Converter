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
            try
            {
                Directory.CreateDirectory(destination + $"\\{name}");
                StreamWriter output = new(destination + $"\\{name}\\{name}.aoc");
                int w = Input1.Width;
                int h = Input1.Height;
                int p = 0;
                Color CurrentRGB;
                List<int> TerrainRaw = [], TerrainValues = [], TerrainAmounts = [];

                output.Write($"{{\"version\":\"4.0.1\",\"width\":{w},\"height\":{h},\"startingYear\":0,\"currentGameTime\":0,\"nations\":[],\"cities\":[],\"alliances\":[],\"wars\":[],\"terrain2\":");

                for (int y = h - 1; y >= 0; y--)
                {
                    for (int x = 0; x < w; x++)
                    {
                        CurrentRGB = Input1.GetPixel(x, y);
                        float currentBrightness = CurrentRGB.GetBrightness();

                        if (currentBrightness <= 0.061) TerrainRaw.Add(1);
                        else if (currentBrightness <= 0.161) TerrainRaw.Add(6);
                        else if (currentBrightness <= 0.3) TerrainRaw.Add(4);
                        else if (currentBrightness <= 0.451) TerrainRaw.Add(3);
                        else if (currentBrightness <= 0.551) TerrainRaw.Add(7);
                        else if (currentBrightness <= 0.7) TerrainRaw.Add(5);
                        else if (currentBrightness <= 0.9) TerrainRaw.Add(2);
                        else TerrainRaw.Add(0);
                    }
                    progress.Report((h - y) / (double)h * 15 + 40);
                }

                int currentValue = TerrainRaw[0];
                int currentAmount = 1;
                for (int n = 0; n < TerrainRaw.Count - 1; n++)
                {
                    if (TerrainRaw[n] == TerrainRaw[n+1])
                    {
                        currentAmount++;
                    }
                    else
                    {
                        TerrainAmounts.Add(currentAmount);
                        TerrainValues.Add(currentValue);
                        currentValue = TerrainRaw[n+1];
                        currentAmount = 1;
                    }
                    progress.Report(n / TerrainRaw.Count * 5 + 55);
                }
                TerrainAmounts.Add(currentAmount);
                TerrainValues.Add(currentValue);

                output.Write("{\"amounts\":[");
                foreach(int a  in TerrainAmounts)
                {
                    output.Write(a);
                    p++;
                    if (p < TerrainAmounts.Count) output.Write(",");
                }
                p = 0;

                output.Write("],\"values\":[");
                foreach (int v in TerrainValues)
                {
                    output.Write(v);
                    p++;
                    if (p < TerrainValues.Count) output.Write(",");
                }


                output.Write($"]}},\"owner2\":{{\"amounts\":[{w*h}],\"values\":[0]}},\"occupations\":{{\"amounts\":[{w*h}],\"values\":[0]}},\"terrain\":[],\"owner\":[],\"history\":[]}}");
                output.Close();
                progress.Report(100);


                MessageBox.Show("Your scenario has been generated");
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Exception occured:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
