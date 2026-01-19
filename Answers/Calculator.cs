namespace CalculatorApp;

/// <summary>
/// Laskin-luokka peruslaskutoimituksille.
/// MALLIVASTAUS OPETTAJALLE
/// </summary>
public class Calculator
{
    /// <summary>
    /// Laskee kahden luvun summan.
    /// </summary>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Laskee kahden luvun erotuksen.
    /// </summary>
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    /// <summary>
    /// Laskee kahden luvun tulon.
    /// </summary>
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// Laskee kahden luvun osamäärän.
    /// </summary>
    /// <exception cref="DivideByZeroException">Heitetään jos jakaja on nolla</exception>
    public double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Jakaja ei voi olla nolla");
        
        return (double)a / b;
    }

    /// <summary>
    /// Tarkistaa onko luku parillinen.
    /// </summary>
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    /// <summary>
    /// Laskee luvun neliön.
    /// </summary>
    public int Square(int number)
    {
        return number * number;
    }

    /// <summary>
    /// Palauttaa suuremman kahdesta luvusta.
    /// </summary>
    public int Max(int a, int b)
    {
        return a > b ? a : b;
    }
}
