﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal interface IRoom
    {
        public string Name { get; set; }
        public bool PersonInRoom { get; set; }
        public double TempSet { get; set; }

        public void ProcessWeatherData(WeatherData weatherdata);
    }
}
