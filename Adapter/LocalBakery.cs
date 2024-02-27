namespace Adapter;

public class LocalBakery : IBakery
{
    public void Bake(string Item)
    {
        Console.WriteLine($"baking {Item} in local Bakry");
    }

    public void Sell(string Item)
    {
        Console.WriteLine($"selling {Item} in local Bakery");
    }
}