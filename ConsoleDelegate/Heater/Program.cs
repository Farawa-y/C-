using ConsoleDelegate.Heater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater.Heater heater=new Heater.Heater();
            heater.boiled += (new Display().BoilDisplay);
            heater.BoilWater();
            Console.ReadKey();

        }
    }
}
