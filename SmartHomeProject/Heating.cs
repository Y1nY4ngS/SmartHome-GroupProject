using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class Heating : RoomDecorator
    {
        private bool heatingValveOpen;

        public HeatingValve(IRoom room) : base(room) { }

        public override void ProcessWeatherData(WeatherData weatherData)
        {
            base.ProcessWeatherData(weatherData);
            if (weatherData.OutsideTemp < TempSet)
            {
                if (!heatingValveOpen)
                {
                    Console.WriteLine("Opening Heating Valve.");
                    heatingValveOpen = true;
                }
            }
            else
            {
                if (heatingValveOpen)
                {
                    Console.WriteLine("Closing Heating Valve.");
                    heatingValveOpen = false;
                }
            }
        }
    }
}
