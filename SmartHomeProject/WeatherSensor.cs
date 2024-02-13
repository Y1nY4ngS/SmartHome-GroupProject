using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class WeatherSensor
    {
        private double ActualTemp;
        private Random Random;
        private const int MaxTemp;
        private const int MinTemp;

        public WeatherData GetWeatherdata()
        {
            return new WeatherData();
        }
    }
}
