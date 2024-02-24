namespace SmartHomeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weathersensor = new Weathersensor();
            var apartment = new Apartment(weathersensor);

            apartment.SetTempSet("WC", 23);
            apartment.SetTempSet("Kitchen", 22);
            apartment.SetTempSet("Bedroom", 19);
            apartment.SetTempSet("LivingRoom", 22);
            apartment.SetTempSet("Wintergarden", 17);

            apartment.SetPersonInRoom("WC", false);
            apartment.SetPersonInRoom("kitchen", true);
            apartment.SetPersonInRoom("Bedroom", false);
            apartment.SetPersonInRoom("LivinRoom", true);
            apartment.SetPersonInRoom("Wintergarden", true);

            for(var i = 0; i < TimeSpan.FromHours(1).TotalMinutes; i++)
            {
                apartment.GenerateWeatherData();
                Console.WriteLine("\n >>> Continue with Enter <<<");
                Console.ReadLine();
            }

        }
    }
}