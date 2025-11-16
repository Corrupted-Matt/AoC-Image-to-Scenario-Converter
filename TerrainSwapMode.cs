using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AoC_Image_to_Scenario_Converter
{
    internal class TerrainSwapMode
    {
        public static StreamWriter Generate(Bitmap Input1, string TargetScenarioPath, string destination, string name, IProgress<double> progress)
        {
            
            

            Directory.CreateDirectory(destination + $"\\{name}");
            StreamWriter output = new(destination + $"\\{name}\\{name}.aoc");

            

            return output;
        }
    }
}
