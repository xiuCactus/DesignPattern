using Adapter;

class Program
{
    static void Main(string[] args)
    {
        IBakery localBakery = new LocalBakery();
        localBakery.Bake("Cake");
        localBakery.Sell("Cake");
     
        FrenchBakery frenchBakery = new FrenchBakery();
        IBakery adapterFrenchBakery = new FrenchBakeryAdapter(frenchBakery);
        adapterFrenchBakery.Bake("Croissant");
        adapterFrenchBakery.Sell("Croissant");
    }
}


