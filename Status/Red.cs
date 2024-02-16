public class RedState : ITrafficLightState
{
    public void Change(TrafficLight trafficLight)
    {
        trafficLight.SetState(new GreenState());
    }

    public string GetColor()
    {
        return "Red";
    }
}