using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public abstract class RoomDecorator : IRoom
    {
        protected IRoom room;

        public RoomDecorator(IRoom room)
        {
            this.room = room;
            this.Name = room.Name;
        }

        public string Name { get; set; }
        public bool PersonInRoom { get; set; }
        public double TempSet { get; set; }

        public virtual void ProcessWeatherData(WeatherData weatherData)
        {
            room.TempSet = TempSet;
            room.PersonInRoom = PersonInRoom;
            room.ProcessWeatherData(weatherData);
        }
    }

}