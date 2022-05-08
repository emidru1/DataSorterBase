using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;

namespace Data_Sorter_Base
{
    class Request
    {
        public static void Modify(string line)
        {
            if (line != null)
            { 
                string[] values = line.Split(',');
                Console.WriteLine("{0} {1} {2}", values[0], values[1], values[2]);

                string formatted = String.Format("Wave: {0}, Split: {1}, Delta: {2}", values[0], values[1], values[2]);
                if (formatted != "Wave: wave, Split: split, Delta: time")
                {
                    Export.ExportLine(formatted, "output");
                    Globals.sorted++;
                }
                else
                {
                    Globals.invalid++;
                }
            }
            else
            {
                Console.WriteLine("Input line is null");
                return;
            }

            Console.Title = String.Concat(new object[]
               {
            "Emilis Druteika, 2022 Inferno split time line formatter |", // Header for sorter
            " Invalid: " + Globals.invalid,
            " Sorted: " + Globals.sorted,
            " Lines: " + Globals.line.Count()
               });



            
        }    
    }
}
