using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class Weathersensor
    {
        private double currentTemp;
        private Random random;
        private const int maxTemp = 35;
        private const int minTemp = -15;

        public Weathersensor()
        {
            this.random = new Random(Guid.NewGuid().GetHashCode());
            this.currentTemp = random.Next(minTemp, maxTemp);
        }
        public WeatherData GetWeatherData()
        {
            var rand = this.random.NextDouble();

            var rain = rand > 0.5;

            var deltaTemp = rand * (rain ? -1 : 1);
            var newTemp = this.currentTemp + deltaTemp;
            if(newTemp < minTemp || newTemp > maxTemp)
            {
                deltaTemp *= -1;
            }
            this.currentTemp += deltaTemp;
            this.currentTemp = Math.Round(this.currentTemp, 1);
            var wind = Math.Round(35d * rand, 1);

            return new WeatherData{ OutsideTemp = this.currentTemp, WindSpeed = wind, Rain = rain };
        }
    }
}
