using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal struct WeatherData
    {
        double OutsideTemp;
        bool Rain;
        double WindSpeed;

        //Instead of using public class, use a struct. With that all data is public by default. 
    }
}
