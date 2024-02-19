using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class Blind : RoomDecorator
    {
        private bool Blind;

        public override void LowerBlinds(){
        Blind = true;
        }

        public void ProcessWeatherData()
        {

        }
    }
}
