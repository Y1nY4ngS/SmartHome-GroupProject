using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class Kitchen : Room
    {
        Appartment appartment = new Appartment()

        public bool PersonInRoom = appartment.SetPersonInRoom();

        public double TempSet = 22.8;

        public void TempProcess(WeatherData weatherData)
        {
            Heater heater = new Heater();
            AwningControl awningControl = new AwningControl();
            BlindControl blindControl = new BlindControl();

            Name = "Kitchen";

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

// Take data from Room, not create new one in Kitchen.