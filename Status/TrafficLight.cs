public class TrafficLight
{
    private ITrafficLightState _state;// crrent state of light 

    public TrafficLight(ITrafficLightState initialState)
    {
        _state = initialState; //give the state 
    }

    public void Change()
    {
        _state.Change(this);//changing the stat to the current state object 
    }

    public string GetColor()
    {
        return _state.GetColor();//changing the Colore to the current state object
    }

    public void SetState(ITrafficLightState state)
    {
        _state = state;// allow the changing to the current state 
    }
}
