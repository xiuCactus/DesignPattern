

public interface ITrafficLightState
{
    //send the stand 
    void Change(TrafficLight trafficLight);
    //get the current color 
    string GetColor();
}
