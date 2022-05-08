using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;
using System.Threading;

namespace Data_Sorter_Base
{
    static class Core
    {
        public static int Threads = 0;

        public static void Start()
        {
            #region UI

            Console.Title = "Emilis Druteika 2022";
            Console.WriteLine("Inferno time data sorter", Globals.colorBase);

            Functions.LoadLines();

            Console.WriteLine($"{Globals.line.Count} Lines Loaded.", Globals.colorSecondary);

            Console.WriteLine("How many Threads would you like to use?", Globals.colorSecondary);
            Console.Write("> ", Color.GhostWhite);

            Threads = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Threads; i++)
            {
                NewThread(); //Starting new threads, amount = threads the user input before
            }


            #endregion
        }
        //Added multithreading to test performance
        public static void NewThread()
        {
            new Thread(delegate ()
            {
                while (Globals.line.Count > 0)
                {
                    Request.Modify(Functions.GetLines()); //Passes a line to modifier
                }
                //Leave a few lines unformatted, to prevent null exception caused by race condition
                Console.WriteLine("THREAD FINISHED!");
                return;
            })
            {
                IsBackground = true
            }.Start();
        }
    }
}
