namespace observer;

public class CityCarService: IObserver
{
    public void Update(float temperature, float humidity)
    {
        if (temperature < 3)
        {
            Console.WriteLine("change the car tier");
        }
    }
}