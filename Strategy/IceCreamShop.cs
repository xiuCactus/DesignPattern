namespace Strategy;

public class IceCreamShop
{
    private IServeStrategy _serveStrategy;
    
    //Constructor
    public IceCreamShop(IServeStrategy serveStrategy)
    {
        _serveStrategy = serveStrategy;
    }
    
    //chang serve Strategy
    public void SetServeStrategy(IServeStrategy serveStrategy)
    {
        _serveStrategy = serveStrategy;
    }
    
    // Method to serve ice cream using the current serving strategy
    public void ServeIceCream()
    {
        _serveStrategy.Serve();
    }
}