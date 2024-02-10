// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using observer;

class Program
{
    static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();

        Farmer farmer = new Farmer();
        weatherData.RegisterObserver(farmer);
        
        CityCarService cityCarService = new CityCarService();
        weatherData.RegisterObserver(cityCarService);
        
        NASA nasa = new NASA();
        weatherData.RegisterObserver(nasa);
        
        weatherData.SetMeasurements(20,60);
        weatherData.SetMeasurements(10,40);
        weatherData.SetMeasurements(0,20);
        weatherData.SetMeasurements(100,20);

    }
}