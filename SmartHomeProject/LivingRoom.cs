using System.Drawing;

namespace SmartHomeProject
{
    public class LivingRoom : Room
    {
        public RgbColor AmbientLighting { get; set; }
        public LivingRoom() : base("Living") { }
    }
}