using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal abstract class RoomDecorator
        private IRoom room;
    {
        protected IRoom Room;
        public string Name { get; set; }
        public bool PersonInRoom { get; set; }
        public double TempSet { get; set; }
        public void TempProcess(WeatherData weatherData)
        {
            
        }
        public virtual void HeaterOn() { }
        public virtual void ExtendAwning() { }
        public virtual void LowerBlinds() { }
    }
}
public RoomDecorator(IRoom ProcessWeather())
{
    this.wetterProcessor = wetterProcessor;
}