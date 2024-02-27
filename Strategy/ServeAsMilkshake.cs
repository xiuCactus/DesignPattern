namespace Strategy;

public class ServeAsMilkshake: IServeStrategy
{
    public void Serve()
    {
        Console.WriteLine("ServeAsMilkshake");
    }
}