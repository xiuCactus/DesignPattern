namespace Adapter;

public class FrenchBakeryAdapter : IBakery
{
    public readonly FrenchBakery _frenchBakery;

    public FrenchBakeryAdapter(FrenchBakery frenchBakery)
    {
        _frenchBakery = frenchBakery;
    }
    public void Bake(string Item)
    {
        _frenchBakery.PrepareFrenchDessert(Item);
    }

    public void Sell(string Item)
    {
        _frenchBakery.Dispatch(Item);
    }
}