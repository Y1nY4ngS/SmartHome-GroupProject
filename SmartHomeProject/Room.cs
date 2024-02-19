using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class Room : IRoom
    {
        public string Name { get; set; }

        public bool PersonInRoom { get; set; }

        public double TempSet { get; set; }

        public void ProcessWeatherData(WeatherData weatherData)
        {
            if (weatherData.OutsideTemp < TempSet)
            {
                HeaterOn();
            }
            else if (weatherData.OutsideTemp > TempSet)
            {
                if (weatherData.WindSpeed <= 30)
                {
                    ExtendAwning();
                }

                if (!PersonInRoom)
                {
                    LowerBlinds();
                }
            }
        }

        public virtual void HeaterOn() { }
        public virtual void ExtendAwning() { }
        public virtual void LowerBlinds() { }
    }
}