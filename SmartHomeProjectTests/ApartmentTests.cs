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
            // Arrange
            double mockTemp = 10; // Set the mock temperature
            bool mockRain = false; // Set the mock rain status
            double mockWind = 5; // Set the mock wind speed
            WeatherData mockWeatherData = weatherDataMock.GetWeatherDataMock(mockTemp, mockRain, mockWind);

            // Act
            apartment.GenerateWeatherData();

            // Assert
            // Add your assertions here based on the expected behavior of the heater
        }
    }
}