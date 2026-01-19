namespace CalculatorApp;

/// <summary>
/// Apuluokka merkkijonojen käsittelyyn.
/// VALMIS KOODI - Kirjoita testit tälle luokalle.
/// </summary>
public class StringHelper
{
    /// <summary>
    /// Kääntää merkkijonon ympäri.
    /// </summary>
    public string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    /// <summary>
    /// Tarkistaa onko merkkijono palindromi (sama molempiin suuntiin).
    /// Ei huomioi isoja/pieniä kirjaimia.
    /// </summary>
    public bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        string normalized = input.ToLower();
        string reversed = Reverse(normalized);
        return normalized == reversed;
    }

    /// <summary>
    /// Laskee sanojen määrän merkkijonossa.
    /// </summary>
    public int CountWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return 0;

        string[] words = input.Split(new[] { ' ', '\t', '\n', '\r' }, 
            StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    /// <summary>
    /// Muuttaa ensimmäisen merkin isoksi kirjaimeksi.
    /// </summary>
    public string Capitalize(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        if (input.Length == 1)
            return input.ToUpper();

        return char.ToUpper(input[0]) + input.Substring(1);
    }
}
