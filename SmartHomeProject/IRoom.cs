using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public interface IRoom
    {
        string Name { get; set; }
        bool PersonInRoom { get; set; }
        double TempSet { get; set; }

        void ProcessWeatherData(WeatherData weatherdata);
    }
}
