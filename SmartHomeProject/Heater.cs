using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class Heater : RoomDecorator
    {
        private bool HeatingValve;

        public override void HeaterOn()
        {
            HeatingValve = true;
        }

        public void TempProcess()
        {

        }
    }
}
