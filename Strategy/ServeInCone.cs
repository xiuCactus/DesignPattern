namespace Strategy;

public class ServeInCone: IServeStrategy
{
    public void Serve()
    {
        Console.WriteLine("Serving ice cream in a cone.");
    }
}