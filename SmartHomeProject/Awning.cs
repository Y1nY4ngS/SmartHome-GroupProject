using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class Awning : RoomDecorator
    {
        private bool Awning;

        public override void ExtendAwning()
        {
            Awning = true;
        }

        public override void ProcessWeatherData()
        {
            
        }
    }
}
