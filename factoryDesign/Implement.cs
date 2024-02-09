namespace FactoryDesign
{
    public static class implement
    {
        public static void OrderPizza(string type)
        {
            IPizza pizza = Factory.CreatPizza(type);
            pizza.Bake();
            System.Console.WriteLine("pizza is ready");
        }
    }
}