namespace SmartHomeProject
{
    public class Bedroom : Room
    {
        public DateTime WakeTime { get; set; }
        public Bedroom() : base("sleep") { }
    }
}