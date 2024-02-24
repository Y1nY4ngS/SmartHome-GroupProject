using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class WC : Room
    {
        public double Humidity { get; set; }

        public WC() : base("WC") { }
    }
}
