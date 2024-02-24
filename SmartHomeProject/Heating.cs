using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class Heater : RoomDecorator
    {
        private bool heaterOn;

        public Heater(IRoom room) : base(room) { }

        public override void ProcessWeatherData(WeatherData weatherData)
        {
            base.ProcessWeatherData(weatherData);
            if(weatherData.OutsideTemp < TempSet)
            {
                if(!heaterOn)
                {
                    Console.WriteLine("Heater is turning on");
                    heaterOn = true;
                } else
                {
                    Console.WriteLine("Heater is turning off");
                    heaterOn = false;
                }
            }
        }
    }
}
