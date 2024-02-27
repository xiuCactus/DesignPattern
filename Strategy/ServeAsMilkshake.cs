namespace Strategy;

public class ServeAsMilkshake: IServeStrategy
{
    public void Serve()
    {
        Console.WriteLine("Serving ice cream as a milkshake.");
    }
}