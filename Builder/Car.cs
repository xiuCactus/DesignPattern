namespace ConsoleAppBuilder;

public class Car
{
    public string Marke { get;  set; }
    public string Modell { get;  set; }
    public string Farbe { get;  set; }
    public int PS { get;  set; }
    public int Baujahr { get;  set; }
    public class Builder
    {
        string _marke;
        string _modell;
        string _farbe;
        int _ps;
        int _baujahr;
        public Builder SetMarke(string marke)
        {
            _marke = marke;
            return this;
        }
        public Builder SetModell(string modell)
        {
            _modell = modell;
            return this;
        }
        public Builder SetFarbe(string farbe)
        {
            _farbe = farbe;
            return this;
        }
        public Builder SetPS(int ps)
        {
            _ps = ps;
            return this;
        }
        public Builder SetBaujahr(int baujahr)
        {
            _baujahr = baujahr;
            return this;
        }
        public Car Build()
        {
            if (string.IsNullOrEmpty(_marke) || string.IsNullOrEmpty(_modell) || _ps <= 0 || _baujahr <= 0)
            {
                throw new InvalidOperationException("define all the required properties.");
            }

            return new Car
            {
                Marke = _marke,
                Modell = _modell,
                Farbe = _farbe,
                PS = _ps,
                Baujahr = _baujahr
            };
        }
    }
    public override string ToString()
    {
        return $"Car: Marke={Marke}, Modell={Modell}, Farbe={Farbe}, PS={PS}, Baujahr={Baujahr}";
    }
}