using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class WC : Room
    {
        Appartment appartment = new Appartment();
        
        public double Humidity;

        public new string Name = "WC";

        public new bool PersonInRoom = appartment.SetPersonInRoom();

        public new double TempSet = 22.5;

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
