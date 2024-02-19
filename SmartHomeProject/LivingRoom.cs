using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class LivingRoom : Room
    {
        Appartment appartment = new Appartment();

        public new string Name = "Living Room";

        public new bool PersonInRoom = appartment.SetPersonInRoom();

        public new double TempSet = 24;

        public new void TempProcess(WeatherData weatherData)
        {
            Heater heater = new Heater();
            AwningControl awningControl = new AwningControl();
            BlindControl blindControl = new BlindControl();


            if (weatherData.OutsideTemp < TempSet)
            {
                heater.HeaterOn();
            }
            else if (weatherData.OutsideTemp > TempSet)
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
