namespace SmartHomeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kitchen = new Room();
            var kitchenWithBlind = new Blind(kitchen);
            var kitchenWithBlindAndHeating = new Heating(kitchenWithBlind);
            kitchenWithBlindAndHeating.ProcessWeather();
        }
    }
}