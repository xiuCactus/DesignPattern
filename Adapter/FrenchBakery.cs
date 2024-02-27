namespace Adapter;

public class FrenchBakery
{
    public void PrepareFrenchDessert(string dessert)
    {
        Console.WriteLine($"Preparing French dessert: {dessert}");
    }

    public void Dispatch(string dessert)
    {
        Console.WriteLine($"Dispatching French dessert: {dessert}");
    }
}