using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public struct WeatherData
    {
        public double OutsideTemp {  get; set; }
        public bool Rain {  get; set; }
        public double WindSpeed { get; set; }

        //Instead of using public class, use a struct. With that all data is public by default. 
    }
}
