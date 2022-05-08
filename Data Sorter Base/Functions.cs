using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;
using System.Threading;

namespace Data_Sorter_Base
{
    static class Functions
    {   
       
        public static void LoadLines()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\input.txt");
                while ((line = sr.ReadLine()) != null) //Read the Text file line by line and add every line to the list
                {
                    Globals.line.Add(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No file containing lines found. Make sure that input.txt exists in your Program Folder.", Globals.colorError);
                Thread.Sleep(5000); // Wait before exiting the application so that the user can read the message.
                Environment.Exit(0);
            }

        }
        public static string GetLines()
        {
            string result = null;
            int index = 0;
            if (Globals.line.Count > 0) // Error handling
            {
                result = Globals.line[index]; // Grab a line that corresponds to the index
                Globals.line.Remove(result); //...and then remove it 
                index++;
            }
            return result;
        }

        public static string Between(this string value, string a, string b)
        {
            int posA = value.IndexOf(a);
            int posB = value.LastIndexOf(b);
            if (posA == -1)
            {
                return "";
            }
            if (posB == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= posB)
            {
                return "";
            }
            return value.Substring(adjustedPosA, posB - adjustedPosA);
        }
    }
}
