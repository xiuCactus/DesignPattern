namespace observer;

public class NASA: IObserver
{
    public void Update(float temperature, float humidity)
    {
        if (temperature > 50)
        {
            Console.WriteLine("tow hot to walk out side ");
        }
    }
}