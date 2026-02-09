using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace AoC_Image_to_Scenario_Converter
{
    internal class TerrainSwapMode
    {
        public static void Generate(Bitmap Input1, string TargetScenarioPath, string destination, string name, IProgress<double> progress)
        {
            try
            {
                int w = Input1.Width;
                int h = Input1.Height;
                int p = 0;
                Color CurrentRGB;
                List<int> TerrainRaw = [], TerrainValues = [], TerrainAmounts = [];
                var target = JsonNode.Parse(File.ReadAllText(TargetScenarioPath))
                    ?? throw new Exception("Scenario parsing error. Please select a .aoc file");

                if (w != ((int?)target["width"]) || h != ((int?)target["height"]))
                    throw new Exception("Target scenario and replacement terrain need to be the same size");

                for (int y = h - 1; y >= 0; y--)
                {
                    for (int x = 0; x < w; x++)
                    {
                        CurrentRGB = Input1.GetPixel(x, y);
                        float currentBrightness = CurrentRGB.GetBrightness();

                        if (currentBrightness <= 0.06) TerrainRaw.Add(1);
                        else if (currentBrightness <= 0.16) TerrainRaw.Add(6);
                        else if (currentBrightness <= 0.25) TerrainRaw.Add(4);
                        else if (currentBrightness <= 0.35) TerrainRaw.Add(8);
                        else if (currentBrightness <= 0.45) TerrainRaw.Add(3);
                        else if (currentBrightness <= 0.55) TerrainRaw.Add(7);
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
                    progress.Report(n / TerrainRaw.Count * 5 + 55);
                }
                TerrainAmounts.Add(currentAmount);
                TerrainValues.Add(currentValue);

                var NewTerrain = new JsonObject
                {
                    ["amounts"] = JsonSerializer.SerializeToNode(TerrainAmounts),
                    ["values"] = JsonSerializer.SerializeToNode(TerrainValues)
                };
                target["terrain2"] = NewTerrain;

                Directory.CreateDirectory(destination + $"\\{name}");
                if (File.Exists(Directory.GetParent(TargetScenarioPath) + "flags.png"))
                    File.Copy(Directory.GetParent(TargetScenarioPath) + "flags.png", destination + $"\\{name}\\flags.png");
                if (File.Exists(Directory.GetParent(TargetScenarioPath) + "flagNames.txt"))
                    File.Copy(Directory.GetParent(TargetScenarioPath) + "flags.png", destination + $"\\{name}\\flagNames.txt");
                File.WriteAllText(destination + $"\\{name}\\{name}.aoc", target.ToJsonString());

                MessageBox.Show("Your scenario has been generated");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Exception occured:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
