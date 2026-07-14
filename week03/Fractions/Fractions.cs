//ENGINE
//Defines a fraction

public class Fraction
{
    //ENGINE MEMORY
    //_top remembers the top number.
    //_bottom remembers the bottom number.
    //Private = protects the engine's memory 

    private int _top;
    private int _bottom;


    //START
    //If no numbers are given, start with 1/1 (default).

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //START
    //If one number is given, use it as the top number and make the bottom 1.

    public Fraction(int wholeNumber)
    {

        _top = wholeNumber;
        _bottom = 1;
    }

    //START
    //If two numbers are given, use them as the top and bottom numbers.

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //READ
    //Retrieves the top number.

    public int GetTop()
    {
        return _top;
    }

    //READ
    //Retrieves the bottom number.

    public int GetBottom()
    {
        return _bottom;
    }

    //UPDATE
    //Updates the top number upon entry.

    public void SetTop(int top)
    {
        _top = top;

    }

    //UPDATE
    //Updates the bottom number upon entry.
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //SHOW
    //Display the fraction entered

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    //CALCULATE
    //Find the decimal value.

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}