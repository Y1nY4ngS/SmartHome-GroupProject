namespace SmartHomeProject.Tests
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
    }
}