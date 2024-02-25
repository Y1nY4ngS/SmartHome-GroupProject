using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class WeatherDataMock
    {
        public WeatherData GetWeatherDataMock(double mockTemp, bool mockRain, double mockWind)
        {
            var rain = mockRain;
            var wind = mockWind;
            var currentTemp = mockTemp;

            return new WeatherData { OutsideTemp = currentTemp, WindSpeed = wind, Rain = rain };
        }
    }
}
