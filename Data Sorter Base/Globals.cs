using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Data_Sorter_Base
{
    static class Globals
    {
        public static int sorted = 0;
        public static int total = 0;
        public static int invalid = 0;

        public static List<string> line = new List<string>();
        public static Color colorError = Color.IndianRed;
        public static Color colorSecondary = Color.GhostWhite;
        public static Color colorBase = Color.MediumTurquoise; // Change this to easily change the color of the outputs

    }
}
