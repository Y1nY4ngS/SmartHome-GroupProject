using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class Apartment
    {
        private List<IRoom> _rooms = new List<IRoom>();
        private Weathersensor sensor;

        public Apartment(Weathersensor sensor)
        {
            this.sensor = sensor;

            _rooms.Add(new Heater(new WC()));
            _rooms.Add(new Blind(new Heater(new Kitchen())));
            _rooms.Add(new Blind(new Heater(new Bedroom())));
            _rooms.Add(new Blind(new Heater(new LivingRoom())));
            _rooms.Add(new Blind(new Awning( new Wintergarden())));
        }

        public void SetTempSet(string name, double TempSet)
        {
            var room = _rooms.FirstOrDefault(r => r.Name == name);
            if(room != null)
            {
                room.TempSet = TempSet;
            }
        }
        
        public void SetPersonInRoom(string name, bool PersonInRoom)
        {
            var room = _rooms.FirstOrDefault(r => r.Name == name);
            if(room != null)
            {
                room.PersonInRoom = PersonInRoom;
            }
        }

        public void GenerateWeatherData()
        {
            var weatherdata = sensor.GetWeatherData();

            Console.WriteLine($"\n*** Using Weatherdata:\n Outside temperature: {weatherdata.OutsideTemp}°C\n Rain: {(weatherdata.Rain ? "yes" : "no")}\n Windspeed: {weatherdata.WindSpeed}km/h");
            foreach(var room in _rooms)
            {
                room.ProcessWeatherData(weatherdata);
            }
        }
    }
}