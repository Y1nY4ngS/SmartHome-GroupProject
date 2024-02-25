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
        private WeatherDataMock sensor;
        [TestMethod()]
        public void HeaterTest()
        {
            sensor.GetWeatherDataMock(20, false, 21);
            apartment = new Apartment(sensor);

            // Arrange
            Apartment.SetTempSet("Living room", 19);
            sensor.GetWeatherDataMock(18, false, 0);

            // Act
            apartment.ProcessWeatherData();

            // Assert
            Assert.IsTrue(apartment.IsHeaterOn("Living room"));
        }
        [TestMethod()]
        public void SetTempSetTest()
        {
            Assert.Fail();
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