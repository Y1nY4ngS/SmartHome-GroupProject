using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    internal class BlindControl : RoomDecorator
    {
        private bool Blinds;

        public override void LowerBlinds(){
        Blinds = true;
        }

        public void TempProcess()
        {

        }
    }
}
