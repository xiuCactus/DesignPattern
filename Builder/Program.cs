// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ConsoleAppBuilder;

var car = new Car.Builder()
    .SetMarke("Toyota")
    .SetModell("Corolla")
    .SetFarbe("Rot")
    .SetPS(150)
    .SetBaujahr(2021)
    .Build();

var car1 = new Car.Builder()
    .SetMarke("BMW")
    .SetModell("X5")
    .SetFarbe("schwarz")
    .SetPS(150)
    .SetBaujahr(2020)
    .Build();

Console.WriteLine(car);
Console.WriteLine(car1);