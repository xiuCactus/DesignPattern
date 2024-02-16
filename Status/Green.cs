

public class GreenState : ITrafficLightState
{
    public void Change(TrafficLight trafficLight)
    {
        trafficLight.SetState(new YellowState());//move from green to yellow 
    }

    public string GetColor()
    {
        return "Green";//return to gerrn
    }
}
