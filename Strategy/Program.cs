using Strategy;

class Program
{
    static void Main(string[] args)
    {
        // Creating an ice cream shop with a default serving strategy
        IceCreamShop shop = new IceCreamShop(new ServeInCone());

        // Serving ice cream with the default strategy
        shop.ServeIceCream();

        // Changing the serving strategy to ServeInCup
        shop.SetServeStrategy(new ServeInCup());
        shop.ServeIceCream();

        // Changing the serving strategy to ServeAsMilkshake
        shop.SetServeStrategy(new ServeAsMilkshake());
        shop.ServeIceCream();
    }
}