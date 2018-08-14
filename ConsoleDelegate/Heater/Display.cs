using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate.Heater
{
    class Display
    {
        public void BoilDisplay(object sender, BoiledEventArgs e)
        {
            Heater heater = (Heater)sender;
            Console.WriteLine($"logo:{heater.logo},type:{heater.type}");
            Console.WriteLine(e.temperature);
            Console.WriteLine();
        }
    }
}
