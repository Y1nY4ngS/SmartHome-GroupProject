using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class Heating : RoomDecorator
    {
        private bool HeatingValve;

        public override void HeatingOn()
        {
            HeatingValve = true;
        }

        public void TempProcess()
        {

        }
    }
}
