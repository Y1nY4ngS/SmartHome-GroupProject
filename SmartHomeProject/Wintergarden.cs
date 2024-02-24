using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class Wintergarden : Room
    {
        public double SunShinning { get; set; }

        public Wintergarden() : base("Wintergarden") { }
    }
}
