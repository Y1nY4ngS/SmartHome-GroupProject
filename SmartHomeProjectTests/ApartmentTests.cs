﻿namespace SmartHomeProject.Tests
{
    [TestClass()]
    public class ApartmentTests
    {
        private Apartment apartment;
        private WeatherDataMock weatherDataMock;

        public ApartmentTests()
        {
            weatherDataMock = new WeatherDataMock();
            Weathersensor sensor = new Weathersensor(weatherDataMock);
            apartment = new Apartment(sensor);
        }

        [TestInitialize()]
        public void Setup()
        {
            weatherDataMock = new WeatherDataMock();
            Weathersensor sensor = new Weathersensor(weatherDataMock);
            apartment = new Apartment(sensor);
        }

        [TestMethod()]
        public void HeaterTest()
        {
            double mockTemp = 10;
            bool mockRain = false;
            double mockWind = 5;
            WeatherData mockWeatherData = weatherDataMock.GetWeatherDataMock(mockTemp, mockRain, mockWind);

            apartment.GenerateWeatherData();

            Assert.IsTrue(HeatingOn);
        }

        [TestMethod()]
        public void SetTempSetTest()
        {
            string roomName = "Living room";
            int targetTemperature = 21;
            Assert.AreEqual(targetTemperature, apartment.GetTempSet(roomName);
        }

        public void HeaterTest2()
        {
            double mockTemp = 15;
            bool mockRain = true;
            double mockWind = 1.3;
            WeatherData mockWeatherData = weatherDataMock.GetWeatherDataMock(mockTemp, mockRain, mockWind);

            apartment.GenerateWeatherData();

            Assert.IsTrue(HeatingOn);

            var kitchen = apartment.GetRoom<Heater>("Kitchen");
            Assert.IsTrue(kitchen.HeatingOn, "Heating should be turned on.");
        }

        public T GetZimmer<T>() where T : RoomDecorator
        {
            if(this is T)
            {
                return this as T;
            }
            if(this.room is RoomDecorator) { }
        }
    }
}