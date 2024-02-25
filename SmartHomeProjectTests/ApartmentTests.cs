using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartHomeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject.Tests
{
    [TestClass()]
    public class ApartmentTests
    {
        private WeatherDataMock weatherdatamock;
        private Apartment apartment;
        [TestMethod()]
        public void HeaterTest()
        {
            weatherdatamock.GetWeatherDataMock(20, false, 21);

            // Arrange
            apartment.SetTempSet("Living room", 19);
            weatherdatamock.GetWeatherDataMock(18, false, 0);

            // Act
            apartment.GenerateWeatherData();

            // Assert
            Assert.IsTrue(apartment.IsHeaterOn("Living room"));

        }
        [TestMethod()]
        public void SetTempSetTest()
        {
            string roomName = "Living room";
            int targetTemperature = 21;
            Assert.AreEqual(targetTemperature, apartment.GetTempSet(roomName);
        }

        [TestMethod()]
        public void SetPersonInRoomTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GenerateWeatherDataTest()
        {
            Assert.Fail();
        }

    }
}