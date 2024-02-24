using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class Blind : RoomDecorator
    {
        private bool BlindOpen;

        public Blind(IRoom room) : base(room) { }

        public override void ProcessWeatherData(WeatherData weatherData)
        {
            base.ProcessWeatherData(weatherData);
            if(weatherData.OutsideTemp > TempSet)
            {
                if(BlindOpen)
                {
                    if(PersonInRoom)
                    {
                        Console.WriteLine("Blinds can't extend because trrhere are people in room");
                    } else
                    {
                        Console.WriteLine("Blinds are clossing");
                        BlindOpen = false;
                    }
                }
            } else
            {
                if (!BlindOpen)
                {
                    Console.WriteLine("Blinds are opening");
                    BlindOpen = true;
                }
            }
        }
    }
}
