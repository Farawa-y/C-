using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate.Heater
{
    public class Alarm
    {
        public Heater heater;

        public Alarm(Heater h)
        {
            this.heater = h;
            h.boiled += BoilAlarm;
        }
        public void BoilAlarm(object sender,BoiledEventArgs e )
        {
            Console.WriteLine($"logo:{heater.logo},type:{heater.type}");
            Console.WriteLine(e.temperature);
            Console.WriteLine();
        }
    }
}
