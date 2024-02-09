namespace Singlton;

public class CoffeMachinee
{
    public static CoffeMachinee instance = null;
    
    // Attribute present the coffee machine status
    private int CoffeeLeft;
    
    // constructor
    private CoffeMachinee()
    {
        CoffeeLeft = 20;
    }
    //get instance of coffee machine
    public static CoffeMachinee Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new CoffeMachinee();
            }
            return instance;
        }
    }
    //use coffee machine
    public void MakeCoffee()
    {
        if (CoffeeLeft > 0)
        {
            CoffeeLeft--;
            Console.WriteLine("Coffee left:"+CoffeeLeft);
        }
        else
        {
            Console.WriteLine("refill coffee machine");
        }
    }
    //refill the coffee machine
    public void Refill()
    {
        CoffeeLeft = 20;
        Console.WriteLine("machine refilled");
    }
}