namespace FactoryDesign;

public class Factory
{
    public static IPizza CreatPizza(string type)
    {
        if (type == "cheese")
        {
            return new Margarita();
        }
        else if (type == "caprese")
        {
            return new caprese();
        }
        else
        {
            Console.WriteLine("Invalid pizza type");
            return null;
        }
    }
}