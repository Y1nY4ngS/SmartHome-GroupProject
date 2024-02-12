using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal abstract class ZimmerDecorator
    {
        protected IZimmer zimmer;
        public string Name { get; set; }
        public bool PersonenImZimmer { get; set; }
        public double TemperaturVorgabe { get; set; }
        public void VerarbeiteWetterdaten(wetterdaten Wetterdaten)
        {

        }

    }
}
