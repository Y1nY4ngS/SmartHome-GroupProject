using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal interface IZimmer
    {
        public string name { get; set; }
        public bool PersonenImZimmer { get; set; }
        public double TemparaturVorgabe { get; set; }

        public void VerarbeiteWetterdaten(wetterdaten Wetterdaten)
        {

        }
    }
}
