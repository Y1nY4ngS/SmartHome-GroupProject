using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class Awning : RoomDecorator
    {
        private bool AwningIn;

        public Awning(IRoom room) : base(room) { }

        public override void ProcessWeatherData(WeatherData weatherdata)
        {
            base.ProcessWeatherData(weatherdata);
            if(weatherdata.OutsideTemp > TempSet)
            {
                if (AwningIn)
                {
                    if (weatherdata.Rain)
                    {
                        Console.WriteLine("Awning can't be extended");
                    } else
                    {
                        Console.WriteLine("Awning is extending");
                        AwningIn = false;
                    }
                } else if(weatherdata.Rain && !AwningIn) 
                {
                    Console.WriteLine("Awning is retracting because of rain");
                    AwningIn = true;
                }
            } else
            {
                if(!AwningIn)
                {
                    Console.WriteLine("Awning is retracting");
                    AwningIn=true;
                }
            }
        }
    }
}
