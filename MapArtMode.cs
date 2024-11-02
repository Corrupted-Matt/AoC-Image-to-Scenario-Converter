using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static AoC_Image_to_Scenario_Converter.ImgUtils;

namespace AoC_Image_to_Scenario_Converter
{
    internal class MapArtMode
    {
        public static StreamWriter Generate(Bitmap Input1, string destination, string name, int ColorLevels, IProgress<double> progress)
        {
            Bitmap PosterizedInput = PosterizeImage(Input1, ColorLevels);
            Directory.CreateDirectory(destination + $"\\{name}");
            StreamWriter output = new(destination + $"\\{name}\\{name}.aoc");
            int w = Input1.Width;
            int h = Input1.Height;
            int id = 1;
            int p = 0;
            List<int[]> countries = [];
            List<Color> UniqueColors = [];
            Color CurrentRGB;


            output.Write($"{{\"version\":\"3.4.2\",\"width\":{w},\"height\":{h},\"startingYear\":0,\"currentGameTime\":0,\"nations\":[");

            //finding unique colors and creating countires
            for (int y = h - 1; y >= 0; y--)
            {
                for(int x = 0; x < w; x++)
                {
                    CurrentRGB = PosterizedInput.GetPixel(x, y);
                    if (!UniqueColors.Contains(CurrentRGB))
                    {
                        UniqueColors.Add(CurrentRGB);
                        countries.Add([id, x, h - y - 1, CurrentRGB.R, CurrentRGB.G, CurrentRGB.B]);
                        id++;
                    }
                }
                progress.Report((h - y) / (double)h * 20);
            }

            foreach(int[] country in countries)
            {
                output.Write($"{{\"id\":{country[0]},\"name\":\"\",\"destroyed\":false,\"pos\":{{\"x\":{country[1]},\"y\":{country[2]}}},\"originalPos\":{{\"x\":{country[1]},\"y\":{country[2]}}},\"gold\":50,\"color\":{{\"r\":{(float)country[3] / 255},\"g\":{(float)country[4] / 255},\"b\":{(float)country[5] / 255},\"a\":1.0}},\"startYear\":0,\"endYear\":0,\"killerId\":0,\"originId\":0,\"revoltIds\":[],\"killedIds\":[],\"combatEfficiency\":0,\"landValue\":0,\"maxArea\":0,\"revoltPercent\":0.0,\"aiDisabled\":false,\"stress\":0,\"totalWars\":0,\"lives\":[],\"liegeId\":0,\"puppetIds\":[],\"puppetIntegration\":0}}");
                if (country[0] < countries.Count) output.Write(",");
                progress.Report(country[0]/countries.Count*5+20);
            }


            output.Write("],\"cities\":[");
            //creating cities
            foreach (int[] country in countries)
            {
                output.Write($"{{\"x\":{country[1]},\"y\":{country[2]},\"n\":\"\",\"r\":{country[0]}}}");
                if (country[0] < countries.Count) output.Write(",");
            }


            output.Write("],\"alliances\":[],\"wars\":[],\"terrain\":[");
            //creating a flat map
            for (int i = 1; i <= w * h; i++)
            {
                output.Write("1");
                progress.Report((double)i / (w * h) * 25 + 50);
                if (i < w * h) output.Write(",");
            }

            
            output.Write("],\"owner\":[");
            //assigning ownership
            for (int y = h - 1; y >= 0; y--)
            {
                for (int x = 0; x < w; x++)
                {
                    foreach (int[] country in countries)
                    {
                        CurrentRGB = PosterizedInput.GetPixel(x, y);
                        if (country[3] == CurrentRGB.R &&
                            country[4] == CurrentRGB.G &&
                            country[5] == CurrentRGB.B)
                        {
                            output.Write(country[0]);
                            p++;
                            if (p < w * h) output.Write(",");
                            break;
                        }
                    }
                }
                progress.Report((h - y) / (double)h * 25 + 75);
            }

            output.Write("]}");
            output.Close();
            progress.Report(100);

            return output;
        }
    }
}
