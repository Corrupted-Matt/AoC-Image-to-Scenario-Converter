using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Image_to_Scenario_Converter.ImgUtils;

namespace AoC_Image_to_Scenario_Converter
{
    class AdvMode
    {
        public static StreamWriter Generate(Bitmap Input1, Bitmap Input2, string destination, string name, bool AdvCities, IProgress<double> progress)
        {
            try
            {
                if (Input1.Width != Input2.Width || Input1.Height != Input2.Height)
                    throw new Exception("Images need to have the same dimentions");
                Directory.CreateDirectory(destination + $"\\{name}");
                StreamWriter output = new(destination + $"\\{name}\\{name}.aoc");
                int w = Input1.Width;
                int h = Input1.Height;
                int p = 0;
                int id = 1;
                string mem = "";
                Color CurrentRGB;
                List<int[]> countries = [];
                List<Color> citycolors;
                List<Color> UniqueColors = [];

                if (AdvCities) citycolors = [Color.FromArgb(255, 0, 0), Color.FromArgb(0, 255, 0), Color.FromArgb(255, 255, 0)];
                else citycolors = [Color.FromArgb(255, 0, 0)];

                output.Write($"{{\"version\":\"3.4.2\",\"width\":{w},\"height\":{h},\"startingYear\":0,\"currentGameTime\":0,\"nations\":[");


                //finding unique colors and creating countires
                for (int y = h - 1; y >= 0; y--)
                {
                    for (int x = 0; x < w; x++)
                    {
                        CurrentRGB = Input2.GetPixel(x, y);
                        if (UniqueColors.Contains(CurrentRGB) || citycolors.Contains(CurrentRGB) || (CurrentRGB.R == CurrentRGB.G && CurrentRGB.R == CurrentRGB.B)) 
                            continue;
                        UniqueColors.Add(CurrentRGB);
                    }
                }


                for (int y = h - 1; y >= 0; y--)
                {
                    for (int x = 0; x < w; x++)
                    {
                        if (Input2.GetPixel(x, y) == Color.FromArgb(255, 0, 0))
                        {
                            CurrentRGB = FindNeighours(Input2, x, y);
                            if (CurrentRGB.R == CurrentRGB.G && CurrentRGB.R == CurrentRGB.B) continue;
                            countries.Add([id, x, h - y - 1, CurrentRGB.R, CurrentRGB.G, CurrentRGB.B]);
                            while (UniqueColors.Remove(CurrentRGB)) { }
                            id++;
                        }

                    }
                    progress.Report((h - y) / (double)h * 20);
                }

                if (UniqueColors.Count!=0)
                {
                    string MissingCapitals = "";
                    foreach (Color color in UniqueColors)
                    {
                        MissingCapitals += $"\n   #{color.R:X2}{color.G:X2}{color.B:X2}";
                    }
                    output.Close();
                    File.Delete(destination + $"\\{name}\\{name}.aoc");
                    Directory.Delete(destination + $"\\{name}");
                    throw new Exception($"The countries of following colors have no capital specified:{MissingCapitals}");
                }

                foreach (int[] country in countries)
                {
                    output.Write($"{{\"id\":{country[0]},\"name\":\"\",\"destroyed\":false,\"pos\":{{\"x\":{country[1]},\"y\":{country[2]}}},\"originalPos\":{{\"x\":{country[1]},\"y\":{country[2]}}},\"gold\":50,\"color\":{{\"r\":{(float)country[3] / 255},\"g\":{(float)country[4] / 255},\"b\":{(float)country[5] / 255},\"a\":1.0}},\"startYear\":0,\"endYear\":0,\"killerId\":0,\"originId\":0,\"revoltIds\":[],\"killedIds\":[],\"combatEfficiency\":0,\"landValue\":0,\"maxArea\":0,\"revoltPercent\":0.0,\"aiDisabled\":false,\"stress\":0,\"totalWars\":0,\"lives\":[],\"liegeId\":0,\"puppetIds\":[],\"puppetIntegration\":0}}");
                    if (country[0] < countries.Count) output.Write(",");
                    progress.Report(country[0] / countries.Count * 5 + 20);
                }

                output.Write("],\"cities\":[");
                //finding and creating cities

                if (AdvCities)
                {
                    foreach (int[] country in countries)
                    {
                        output.Write($"{{\"x\":{country[1]},\"y\":{country[2]},\"n\":\"\",\"r\":{country[0]}}},");
                    }
                    for (int y = h - 1; y >= 0; y--)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            CurrentRGB = Input2.GetPixel(x, y);
                            if (CurrentRGB == Color.FromArgb(0, 255, 0))
                            {
                                mem += $"{{\"x\":{x},\"y\":{h - y - 1},\"n\":\"\",\"r\":";
                                CurrentRGB = FindNeighours(Input2, x, y);
                                foreach (int[] country in countries)
                                {
                                    if (country[3] == CurrentRGB.R &&
                                    country[4] == CurrentRGB.G &&
                                    country[5] == CurrentRGB.B)
                                    {
                                        mem += country[0];
                                        break;
                                    }
                                    if (country[0]==countries.Count)
                                        mem += 0;
                                }
                                mem += $"}},";
                            }
                            else if (CurrentRGB == Color.FromArgb(255, 255, 0))
                            {
                                mem += $"{{\"x\":{x},\"y\":{h - y - 1},\"n\":\"\",\"r\":0}},";
                            }
                        }
                        progress.Report((h - y) / (double)h * 25 + 25);
                    }
                }
                else
                {
                    foreach (int[] country in countries)
                    {
                        output.Write($"{{\"x\":{country[1]},\"y\":{country[2]},\"n\":\"\",\"r\":{country[0]}}}");
                        if (country[0] < countries.Count) output.Write(",");
                    }
                }
                output.Write(mem.TrimEnd(','));
                output.Write("],\"alliances\":[],\"wars\":[],\"terrain\":[");


                //creating map
                for (int y = h - 1; y >= 0; y--)
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

                //assigning ownership
                for (int y = h - 1; y >= 0; y--)
                {
                    for (int x = 0; x < w; x++)
                    {
                        CurrentRGB = Input2.GetPixel(x, y);
                        if (citycolors.Contains(CurrentRGB))
                        {
                            CurrentRGB = FindNeighours(Input2, x, y);
                            foreach (int[] country in countries)
                            {
                                if (country[3] == CurrentRGB.R &&
                                    country[4] == CurrentRGB.G &&
                                    country[5] == CurrentRGB.B)
                                {
                                    output.Write(country[0]);
                                    break;
                                }
                                if (country[0] == countries.Count) output.Write("0");
                            }
                        }
                        else
                        {
                            for (int i = 0; i < countries.Count; i++)
                            {
                                if (countries[i][3] == CurrentRGB.R &&
                                    countries[i][4] == CurrentRGB.G &&
                                    countries[i][5] == CurrentRGB.B)
                                {
                                    output.Write(countries[i][0]);
                                    break;
                                }
                                if (i == countries.Count - 1) output.Write("0");
                            }
                        }
                        p++;
                        if (p < w * h) output.Write(",");
                    }
                    progress.Report((h - y) / (double)h * 25 + 75);
                }

                output.Write("]}");
                output.Close();
                progress.Report(100);

                MessageBox.Show("Your scenario has been generated");
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Exception occured:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return null;
            }
        }   
    }
}
