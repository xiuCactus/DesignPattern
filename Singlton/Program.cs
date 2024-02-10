// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// class Bakery
// {
//     static void Main(string[] args)
//     {
//         Cake VanilaCake = Cake.GetCake();
//         Cake CheesCake = Cake.GetCake();
//
//         Console.WriteLine(Object.ReferenceEquals(VanilaCake, CheesCake));
//     }
// }

using Singlton;

class Program
{
    static void Main(string[] args)
    {
        CoffeMachinee.Instance.MakeCoffee();
        CoffeMachinee.Instance.MakeCoffee();
        CoffeMachinee.Instance.MakeCoffee();
        
        CoffeMachinee.Instance.Refill();
        CoffeMachinee.Instance.MakeCoffee();
    }
}
