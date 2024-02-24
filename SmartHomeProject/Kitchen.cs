namespace SmartHomeProject
{
    public class Kitchen : Room
    {
        public Stove Stove { get; set; }
        public Kitchen() : base("Kitchen") { }
    }
}