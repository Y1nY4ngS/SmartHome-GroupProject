using SmartHomeProject;
using SmartHomeProject.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProjectTests
{
    public class WeatherSensorMock
    {
        private double currentTemp;
        public WeatherData GetWeatherDataMock(ApartmentTests data)
        {
            var rain = true; //change that the data is set in ApartmentUnitTests
            var wind = 20; //change that the data is set in ApartmentUnitTests


            return new WeatherData { OutsideTemp = currentTemp, WindSpeed = wind, Rain = rain };
        }
    }
}
