using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Sorter_Base
{
    class Export
    {
        private static object locker = new object();

        public static void ExportLine(string line, string name)
        {
            lock (locker)
            {
                TextWriter tw = new StreamWriter(Environment.CurrentDirectory + "\\" + name + ".txt", true);
                tw.WriteLine(line);
                tw.Flush();
                tw.Close();
            }
        }
    }
}
