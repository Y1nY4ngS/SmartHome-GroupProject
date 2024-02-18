using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class WeatherSensor
    {
        private double ActualTemp = 22;
        private Random Random;
        private const int maxTemp = 30;
        private const int minTemp = -10;

        public WeatherData GetWeatherdata()
        {
            WeatherData weatherdata = new WeatherData();

            return weatherdata;
        }
    }
}
