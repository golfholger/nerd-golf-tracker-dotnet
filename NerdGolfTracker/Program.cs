using System;
using System.Diagnostics;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var tracker = new Tracker(new EinfacherInterpreter(), new Lochbegruessung(new Lochausgabe()));
            Console.WriteLine(tracker.Starte());
            while (true)
            {
                var befehl = Console.ReadLine();
                Console.WriteLine(tracker.ReagiereAuf(befehl));                
            }
        }
    }
}
