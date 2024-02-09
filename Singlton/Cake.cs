public class Cake
{
    private static Cake _choclateCake;

    private Cake() { }

    public static Cake GetCake()
    {
        if (_choclateCake == null)
        {
            _choclateCake = new Cake();
        }
        return _choclateCake;
    }
}