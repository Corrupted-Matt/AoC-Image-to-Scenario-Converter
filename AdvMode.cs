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
                List<int> TerrainRaw = [], TerrainValues = [], TerrainAmounts = [], OwnerRaw = [], OwnerValues = [], OwnerAmounts = [];

                if (AdvCities) citycolors = [Color.FromArgb(255, 0, 0), Color.FromArgb(0, 255, 0), Color.FromArgb(255, 255, 0)];
                else citycolors = [Color.FromArgb(255, 0, 0)];

                output.Write($"{{\"version\":\"4.0.1\",\"width\":{w},\"height\":{h},\"startingYear\":0,\"currentGameTime\":0,\"nations\":[");


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
                    output.Write($"{{\"id\":{country[0]},\"name\":\"\",\"destroyed\":false,\"pos\":{{\"x\":{country[1]},\"y\":{country[2]}}}," +
                        $"\"originalPos\":{{\"x\":{country[1]},\"y\":{country[2]}}},\"gold\":50,\"flagId\":0," +
                        $"\"color\":{{\"r\":{(float)country[3] / 255},\"g\":{(float)country[4] / 255},\"b\":{(float)country[5] / 255},\"a\":1.0}}," +
                        $"\"startYear\":0,\"endYear\":0,\"killerId\":0,\"originId\":0,\"revoltIds\":[],\"killedIds\":[],\"combatEfficiency\":0,\"maxArea\":0," +
                        $"\"aiDisabled\":false,\"stress\":0,\"totalWars\":0,\"lives\":[],\"liegeId\":0,\"puppetIds\":[],\"puppetIntegration\":0}}");
                    if (country[0] < countries.Count) output.Write(",");
                    progress.Report(country[0] / countries.Count * 5 + 20);
                }

                output.Write("],\"cities\":[");
                //finding and creating cities

                if (AdvCities)
                {
                    foreach (int[] country in countries)
                    {
                        mem += $"{{\"x\":{country[1]},\"y\":{country[2]},\"n\":\"\",\"r\":{country[0]},\"rp\":0}},";
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
                                mem += $",\"rp\":0}},";
                            }
                            else if (CurrentRGB == Color.FromArgb(255, 255, 0))
                            {
                                mem += $"{{\"x\":{x},\"y\":{h - y - 1},\"n\":\"\",\"r\":0,\"rp\":0}},";
                            }
                        }
                        progress.Report((h - y) / (double)h * 25 + 25);
                    }
                }
                else
                {
                    foreach (int[] country in countries)
                    {
                        output.Write($"{{\"x\":{country[1]},\"y\":{country[2]},\"n\":\"\",\"r\":{country[0]},\"rp\":0}}");
                        if (country[0] < countries.Count) output.Write(",");
                    }
                }
                output.Write(mem.TrimEnd(','));
                output.Write("],\"alliances\":[],\"wars\":[],\"terrain2\":");

                //creating map
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
                    progress.Report((h - y) / (double)h * 15 + 50);
                }

                int currentValue = TerrainRaw[0];
                int currentAmount = 1;
                for (int n = 0; n < TerrainRaw.Count - 1; n++)
                {
                    if (TerrainRaw[n] == TerrainRaw[n + 1])
                    {
                        currentAmount++;
                    }
                    else
                    {
                        TerrainAmounts.Add(currentAmount);
                        TerrainValues.Add(currentValue);
                        currentValue = TerrainRaw[n + 1];
                        currentAmount = 1;
                    }
                    progress.Report(n / TerrainRaw.Count * 10 + 65);
                }
                TerrainAmounts.Add(currentAmount);
                TerrainValues.Add(currentValue);

                output.Write("{\"amounts\":[");
                foreach (int a in TerrainAmounts)
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


                output.Write("]},\"owner2\":");
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
                                    OwnerRaw.Add(country[0]);
                                    break;
                                }
                                if (country[0] == countries.Count) OwnerRaw.Add(0);
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
                                    OwnerRaw.Add(countries[i][0]);
                                    break;
                                }
                                if (i == countries.Count - 1) OwnerRaw.Add(0);
                            }
                        }
                    }
                    progress.Report((h - y) / (double)h * 15 + 75);
                }

                currentValue = OwnerRaw[0];
                currentAmount = 1;
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
                    progress.Report(n / OwnerRaw.Count * 10 + 90);
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

                output.Write($"]}},\"occupations\":{{\"amounts\":[{w*h}],\"values\":[0]}},\"terrain\":[],\"owner\":[],\"history\":[]}}");
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
