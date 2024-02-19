using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class Appartment
    {
        private WeatherSensor weatherSensor;

        public Appartment()
        {
            weatherSensor = new WeatherSensor();
        }

        public void GenerateWeatherData()
        {
            WeatherData weatherdata = weatherSensor.GetWeatherdata();

            weatherdata.OutsideTemp = 22;
            weatherdata.Rain = true;
            weatherdata.WindSpeed = 5.55;

            Console.WriteLine("Generated Weather data:");
            Console.WriteLine("Outside Temperature: " + weatherdata.OutsideTemp + "°C");
            Console.WriteLine("Rain: " + weatherdata.Rain);
            Console.WriteLine("Wind Speed: " + weatherdata.WindSpeed + " km/h");

        }

        public void SetPersonInRoom(bool PersonInRoom)
        {

        }

        public void SetTempSpecification(double TempSpecification)
        {

        }
    }
}
