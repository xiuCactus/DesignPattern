namespace observer;

public class Farmer: IObserver
{
    public void Update(float temperature, float humidity)
    {
        if (temperature < 10)
        {
            Console.WriteLine("bring animal inside ,it's cold out side");
        }

        if (humidity < 50)
        {
            Console.WriteLine("water the plant");

        }
    }
}