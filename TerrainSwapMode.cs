using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace AoC_Image_to_Scenario_Converter
{
    internal class TerrainSwapMode
    {
        public static void Generate(Bitmap Input1, string TargetScenarioPath, int Xoffset, int Yoffset, string destination, string name, IProgress<double> progress)
        {
            try
            {
                progress.Report(0);
                var target = JsonNode.Parse(File.ReadAllText(TargetScenarioPath))
                    ?? throw new Exception("Scenario parsing error. Please select a .aoc file");
                int scW = (int)target["width"];
                int scH = (int)target["height"];
                int imgW = Input1.Width;
                int imgH = Input1.Height;
                Rectangle sc = new Rectangle(Xoffset,imgH-scH-Yoffset,scW,scH), img = new Rectangle(0,0,imgW,imgH);

                Color CurrentRGB;
                List<int> 
                    TerrainRaw = [], TerrainValues = [], TerrainAmounts = [],
                    OwnerRaw = [], OwnerValues = [], OwnerAmounts = [],
                    OccupationRaw = [], OccupationValues = [], OccupationAmounts = [];

                target["width"] = imgW;
                target["height"] = imgH;
                int nationCount = target["nations"].AsArray().Count;

                if(!(Xoffset==0&&Yoffset==0))
                {
                    //adjusting city and country coordinates
                    for (int n = 0; n < nationCount; n++)
                    {
                        int x = (int)target["nations"].AsArray()[n]["pos"]["x"];
                        x += Xoffset;
                        target["nations"].AsArray()[n]["pos"]["x"] = x;

                        int y = (int)target["nations"].AsArray()[n]["pos"]["y"];
                        y += Yoffset;
                        target["nations"].AsArray()[n]["pos"]["y"] = y;


                        int ox = (int)target["nations"].AsArray()[n]["originalPos"]["x"];
                        target["nations"].AsArray()[n]["originalPos"]["x"] = x;

                        int oy = (int)target["nations"].AsArray()[n]["originalPos"]["y"];
                        target["nations"].AsArray()[n]["originalPos"]["y"] = y;

                        progress.Report((double)n / nationCount * 20);
                    }

                    int citiesCount = target["cities"].AsArray().Count;
                    for (int n = 0; n < citiesCount; n++)
                    {
                        int x = (int)target["cities"].AsArray()[n]["x"];
                        x += Xoffset;
                        target["cities"].AsArray()[n]["x"] = x;

                        int y = (int)target["cities"].AsArray()[n]["y"];
                        y += Yoffset;
                        target["cities"].AsArray()[n]["y"] = y;

                        progress.Report((double)n / citiesCount * 20 + 20);
                    }

                    for (int n = 0; n < citiesCount; n++)
                    {
                        int x = (int)target["cities"].AsArray()[n]["x"];
                        int y = (int)target["cities"].AsArray()[n]["y"];

                        if (x > imgW || y > imgH || x < 0 || y < 0)
                        {
                            target["cities"].AsArray().RemoveAt(n);
                            citiesCount--;
                            n--;
                        }
                    }
                }

                List<int>
                    NewTerrainRaw = [], NewTerrainValues = [], NewTerrainAmounts = [],
                    NewOwnerRaw = [], NewOwnerValues = [], NewOwnerAmounts = [],
                    NewOccupationRaw = [], NewOccupationValues = [], NewOccupationAmounts = [];

                for (int y = imgH - 1; y >= 0; y--)
                {
                    for (int x = 0; x < imgW; x++)
                    {
                        CurrentRGB = Input1.GetPixel(x, y);
                        float currentBrightness = CurrentRGB.GetBrightness();

                        if (currentBrightness <= 0.06) NewTerrainRaw.Add(1);
                        else if (currentBrightness <= 0.16) NewTerrainRaw.Add(6);
                        else if (currentBrightness <= 0.25) NewTerrainRaw.Add(4);
                        else if (currentBrightness <= 0.35) NewTerrainRaw.Add(8);
                        else if (currentBrightness <= 0.45) NewTerrainRaw.Add(3);
                        else if (currentBrightness <= 0.55) NewTerrainRaw.Add(7);
                        else if (currentBrightness <= 0.7) NewTerrainRaw.Add(5);
                        else if (currentBrightness <= 0.9) NewTerrainRaw.Add(2);
                        else NewTerrainRaw.Add(0);
                    }
                    progress.Report((imgH - y) / (double)imgH * 20 + 40);
                }

                int Tsize = NewTerrainRaw.Count;
                int currentValue = NewTerrainRaw[0];
                int currentAmount = 1;
                for (int n = 0; n < Tsize - 1; n++)
                {
                    if (NewTerrainRaw[n] == NewTerrainRaw[n + 1])
                    {
                        currentAmount++;
                    }
                    else
                    {
                        NewTerrainAmounts.Add(currentAmount);
                        NewTerrainValues.Add(currentValue);
                        currentValue = NewTerrainRaw[n + 1];
                        currentAmount = 1;
                    }
                }
                NewTerrainAmounts.Add(currentAmount);
                NewTerrainValues.Add(currentValue);

                //extracting other maps

                OwnerAmounts = (List<int>)JsonSerializer.Deserialize(target["owner2"]["amounts"], typeof(List<int>));
                OwnerValues = (List<int>)JsonSerializer.Deserialize(target["owner2"]["values"], typeof(List<int>));

                int i = 0;
                foreach (int a in OwnerAmounts)
                {
                    for (int n = 0; n < a; n++)
                    {
                        OwnerRaw.Add(OwnerValues[i]);
                    }
                    i++;
                }

                OccupationAmounts = (List<int>)JsonSerializer.Deserialize(target["occupations"]["amounts"], typeof(List<int>));
                OccupationValues = (List<int>)JsonSerializer.Deserialize(target["occupations"]["values"], typeof(List<int>));

                i = 0;
                foreach (int a in OccupationAmounts)
                {
                    for (int n = 0; n < a; n++)
                    {
                        OccupationRaw.Add(OccupationValues[i]);
                    }
                    i++;
                }

                //adjusting other maps

                for (int y = imgH - 1; y >= 0; y--)
                {
                    for (int x = 0; x < imgW; x++)
                    {
                        if(sc.Contains(x,y))
                        {
                            NewOwnerRaw.Add(OwnerRaw[(imgH - 1 - (y + Yoffset)) * scW + (x - Xoffset)]);
                            NewOccupationRaw.Add(OccupationRaw[(imgH - 1 - (y + Yoffset)) * scW + (x - Xoffset)]);
                        }
                        else
                        {
                            NewOwnerRaw.Add(0);
                            NewOccupationRaw.Add(0);
                        }
                    }
                    progress.Report((imgH - y) / (double)imgH * 40 + 60);
                }

                //reassembling other maps

                int Osize = NewOwnerRaw.Count;
                currentValue = NewOwnerRaw[0];
                currentAmount = 1;
                for (int n = 0; n < Osize - 1; n++)
                {
                    if (NewOwnerRaw[n] == NewOwnerRaw[n + 1])
                    {
                        currentAmount++;
                    }
                    else
                    {
                        NewOwnerAmounts.Add(currentAmount);
                        NewOwnerValues.Add(currentValue);
                        currentValue = NewOwnerRaw[n + 1];
                        currentAmount = 1;
                    }
                }
                NewOwnerAmounts.Add(currentAmount);
                NewOwnerValues.Add(currentValue);

                int OCsize = NewOccupationRaw.Count;
                currentValue = NewOccupationRaw[0];
                currentAmount = 1;
                for (int n = 0; n < OCsize - 1; n++)
                {
                    if (NewOccupationRaw[n] == NewOccupationRaw[n + 1])
                    {
                        currentAmount++;
                    }
                    else
                    {
                        NewOccupationAmounts.Add(currentAmount);
                        NewOccupationValues.Add(currentValue);
                        currentValue = NewOccupationRaw[n + 1];
                        currentAmount = 1;
                    }
                }
                NewOccupationAmounts.Add(currentAmount);
                NewOccupationValues.Add(currentValue);


                //replacing map layers in target scenario
                target["terrain2"] = new JsonObject
                {
                    ["amounts"] = JsonSerializer.SerializeToNode(NewTerrainAmounts),
                    ["values"] = JsonSerializer.SerializeToNode(NewTerrainValues)
                };
                target["owner2"] = new JsonObject
                {
                    ["amounts"] = JsonSerializer.SerializeToNode(NewOwnerAmounts),
                    ["values"] = JsonSerializer.SerializeToNode(NewOwnerValues)
                };
                target["occupations"] = new JsonObject
                {
                    ["amounts"] = JsonSerializer.SerializeToNode(NewOccupationAmounts),
                    ["values"] = JsonSerializer.SerializeToNode(NewOccupationValues)
                };

                Directory.CreateDirectory(destination + $"\\{name}");
                if (File.Exists(Directory.GetParent(TargetScenarioPath) + "\\flags.png"))
                    File.Copy(Directory.GetParent(TargetScenarioPath) + "\\flags.png", destination + $"\\{name}\\flags.png");
                if (File.Exists(Directory.GetParent(TargetScenarioPath) + "\\flagNames.txt"))
                    File.Copy(Directory.GetParent(TargetScenarioPath) + "\\flagNames.txt", destination + $"\\{name}\\flagNames.txt");
                File.WriteAllText(destination + $"\\{name}\\{name}.aoc", target.ToJsonString());


                SystemSounds.Beep.Play();
                MessageBox.Show("Your scenario has been exported successfully");
                return;
            }
            catch (Exception ex)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(ex.Message, "An Exception occured:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
