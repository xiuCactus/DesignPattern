namespace Strategy;

public class ServeInCup: IServeStrategy
{
    public void Serve()
    {
        Console.WriteLine("Serving ice cream as a milkshake.");
    }
}