using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class Bedroom : Room
    {
        public DateTime AlarmClock;
        
        /*public void SetRooms()
        {
            Appartment appartment = new Appartment();

            Name = "Bedroom";
            PersonInRoom = appartment.SetPersonInRoom();
            TempSet = 23.2;
        }
        */
        
        Appartment appartment = new Appartment();

        public new string Name = "Bedroom";

        public new bool PersonInRoom = appartment.SetPersonInRoom();

        public new double TempSet = 23.2;

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
}
