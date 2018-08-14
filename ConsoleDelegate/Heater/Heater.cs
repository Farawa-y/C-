using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate.Heater
{
    public class Heater
    {
        private int temperature = 0;
        public string logo = "ZYZ";
        public string type = "1995";

        public delegate void BoiledEventHandler(object sender, BoiledEventArgs e);
        public event BoiledEventHandler boiled;

        public void BoilWater()
        {
            for(int i = 0; i < 100; i++)
            {
                int temperature = i;
                if (temperature > 95)
                {
                    //boiled(this, new BoiledEventArgs(temperature));
                    OnBoiled(new BoiledEventArgs(temperature));
                    break;
                }
            }
        }

        protected virtual void OnBoiled(BoiledEventArgs e)
        {
            //boiled?.Invoke(this, e);
            if (boiled != null)
            {
                boiled(this, e);
            }
        }
    }


    public class BoiledEventArgs:EventArgs
    {
        public readonly int temperature;
        
        public BoiledEventArgs(int temp)
        {
            this.temperature = temp;
        }
    }
}
