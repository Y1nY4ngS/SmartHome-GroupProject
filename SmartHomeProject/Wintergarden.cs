using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class Wintergarden : Room
    {
        public double SolarIrridation;

        public new string Name = "Wintergarden";

        public new void TempProcess(WeatherData weatherData)
        {
            Heater heater = new Heater();
            AwningControl awningControl = new AwningControl();
            BlindControl blindControl = new BlindControl();

            if (weatherData.OutsideTemp > TempSet)
            {
                if (weatherData.WindSpeed <= 30)
                {
                    awningControl.ExtendAwning();
                }

                if (!PersonInRoom)
                {
                    blindControl.LowerBlinds();
                }
            }
        }
    }
}
