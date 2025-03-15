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
            try
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
                List<int> OwnerRaw = [], OwnerValues = [], OwnerAmounts = [];



                output.Write($"{{\"version\":\"4.0.1\",\"width\":{w},\"height\":{h},\"startingYear\":0,\"currentGameTime\":0,\"nations\":[");

                //finding unique colors and creating countires
                for (int y = h - 1; y >= 0; y--)
                {
                    for (int x = 0; x < w; x++)
                    {
                        CurrentRGB = PosterizedInput.GetPixel(x, y);
                        if (!UniqueColors.Contains(CurrentRGB))
                        {
                            UniqueColors.Add(CurrentRGB);
                            countries.Add([id, x, h - y - 1, CurrentRGB.R, CurrentRGB.G, CurrentRGB.B]);
                            id++;
                        }
                    }
                    progress.Report((h - y) / (double)h * 15);
                }

                foreach (int[] country in countries)
                {
                    output.Write($"{{\"id\":{country[0]},\"name\":\"\",\"destroyed\":false,\"pos\":{{\"x\":{country[1]},\"y\":{country[2]}}}," +
                        $"\"originalPos\":{{\"x\":{country[1]},\"y\":{country[2]}}},\"gold\":50,\"flagId\":0," +
                        $"\"color\":{{\"r\":{(float)country[3] / 255},\"g\":{(float)country[4] / 255},\"b\":{(float)country[5] / 255},\"a\":1.0}}," +
                        $"\"startYear\":0,\"endYear\":0,\"killerId\":0,\"originId\":0,\"revoltIds\":[],\"killedIds\":[],\"combatEfficiency\":0,\"maxArea\":0," +
                        $"\"aiDisabled\":false,\"stress\":0,\"totalWars\":0,\"lives\":[],\"liegeId\":0,\"puppetIds\":[],\"puppetIntegration\":0}}");
                    if (country[0] < countries.Count) output.Write(",");
                    progress.Report(country[0] / countries.Count * 5 + 15);
                }


                output.Write("],\"cities\":[");
                //creating cities
                foreach (int[] country in countries)
                {
                    output.Write($"{{\"x\":{country[1]},\"y\":{country[2]},\"n\":\"\",\"r\":{country[0]},\"rp\":0}}");
                    if (country[0] < countries.Count) output.Write(",");
                    progress.Report(country[0] / countries.Count * 20 + 20);
                }


                output.Write($"],\"alliances\":[],\"wars\":[],\"terrain2\":{{\"amounts\":[{w*h}],\"values\":[1]}}");


                output.Write(",\"owner2\":");
                p = 0;

                //assigning ownership
                for (int y = h - 1; y >= 0; y--)
                {
                    for (int x = 0; x < w; x++)
                    {
                        CurrentRGB = PosterizedInput.GetPixel(x, y);
                        for (int i = 0; i < countries.Count; i++)
                        {
                            if (countries[i][3] == CurrentRGB.R &&
                                countries[i][4] == CurrentRGB.G &&
                                countries[i][5] == CurrentRGB.B)
                            {
                                OwnerRaw.Add(countries[i][0]);
                                break;
                            }
                            if (i == countries.Count - 1) OwnerRaw.Add(0);
                        }
                    }
                    progress.Report((h - y) / (double)h * 15 + 60);
                }

                int currentValue = OwnerRaw[0];
                int currentAmount = 1;
                for (int n = 0; n < OwnerRaw.Count - 1; n++)
                {
                    if (OwnerRaw[n] == OwnerRaw[n + 1])
                    {
                        currentAmount++;
                    }
                    else
                    {
                        OwnerAmounts.Add(currentAmount);
                        OwnerValues.Add(currentValue);
                        currentValue = OwnerRaw[n + 1];
                        currentAmount = 1;
                    }
                    progress.Report(n / OwnerRaw.Count * 5 + 75);
                }
                OwnerAmounts.Add(currentAmount);
                OwnerValues.Add(currentValue);

                output.Write("{\"amounts\":[");
                foreach (int a in OwnerAmounts)
                {
                    output.Write(a);
                    p++;
                    if (p < OwnerAmounts.Count) output.Write(",");
                }
                p = 0;

                output.Write("],\"values\":[");
                foreach (int v in OwnerValues)
                {
                    output.Write(v);
                    p++;
                    if (p < OwnerValues.Count) output.Write(",");
                }

                output.Write($"]}},\"occupations\":{{\"amounts\":[{w * h}],\"values\":[0]}},\"terrain\":[],\"owner\":[],\"history\":[]}}");
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
