class Program
{
    static void Main(string[] args)
    {
        var trafficLight = new TrafficLight(new GreenState()); // the traffic in the defult color 

        Console.WriteLine(trafficLight.GetColor()); // Output: Green
        trafficLight.Change();//change to the next state 

        Console.WriteLine(trafficLight.GetColor()); // Output: Yellow
        trafficLight.Change();

        Console.WriteLine(trafficLight.GetColor()); // Output: Red
        trafficLight.Change();

        Console.WriteLine(trafficLight.GetColor()); // Output: Green
    }
}
