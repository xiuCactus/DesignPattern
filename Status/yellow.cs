public class YellowState : ITrafficLightState
{
    public void Change(TrafficLight trafficLight)
    {
        trafficLight.SetState(new RedState());
    }

    public string GetColor()
    {
        return "Yellow";
    }
}