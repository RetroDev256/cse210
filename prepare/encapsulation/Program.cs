class Program
{
    public static void Main()
    {
        Fraction pi_approx = new Fraction(333, 106);
        string fract = pi_approx.GetFractionString();
        double value = pi_approx.GetDecimalValue();
        Console.WriteLine($"{fract}: {value}");
    }
}

class Fraction
{
    private int _top;
    private int _bot;

    public Fraction()
    {
        this._top = 0;
        this._bot = 1;
    }

    public Fraction(int wholeNumber)
    {
        this._top = wholeNumber;
        this._bot = 1;
    }

    public Fraction(int top, int bottom)
    {
        this._top = top;
        this._bot = bottom;
    }

    public int GetTop()
    {
        return this._top;
    }

    public void SetTop(int top)
    {
        this._top = top;
    }

    public int GetBottom()
    {
        return this._bot;
    }

    public void SetBottom(int bottom)
    {
        this._bot = bottom;
    }

    public string GetFractionString()
    {
        return $"{this._top}/{this._bot}";
    }

    public double GetDecimalValue()
    {
        return (double)this._top / this._bot;
    }
}