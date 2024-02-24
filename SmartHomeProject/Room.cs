namespace SmartHomeProject
{
    public class Room : IRoom
    {
        public Room(string name)
        {
            Name = name;
        }
        public double TemperaturePreset { get; set; }
        public bool PersonInRoom { get; set; }
        public string Name { get; set; }
        public virtual void ProcessWeatherData(WeatherData weatherData)
        {
            Console.WriteLine($"Weather data for {Name} is being calculated:" +
                $"Temperature preset: {TemperaturePreset}°C, People in the room: {(PersonInRoom ? "yes" : "no")}.");
        }
    }
}