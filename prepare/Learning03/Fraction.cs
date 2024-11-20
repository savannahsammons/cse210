
class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        // idk
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public void GetBottom()
    {
        // idk
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public void GetFractionString()
    {
        // idk should return string not void
    }
    public void GetDecimalValue()
    {
        // idk should return double not void
    }
}