namespace Strategy;

public class ServeInCup: IServeStrategy
{
    public void Serve()
    {
        Console.WriteLine("Serving ice cream in a cup.");
    }
}