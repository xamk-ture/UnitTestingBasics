namespace CalculatorApp;

/// <summary>
/// Apuluokka taulukoiden käsittelyyn.
/// MALLIVASTAUS - TDD-osioon (Part 4).
/// </summary>
public class ArrayHelper
{
    /// <summary>
    /// Laskee taulukon lukujen summan.
    /// Palauttaa 0 jos taulukko on tyhjä tai null.
    /// </summary>
    public int Sum(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return 0;

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    /// <summary>
    /// Laskee taulukon lukujen keskiarvon.
    /// Palauttaa 0 jos taulukko on tyhjä tai null.
    /// </summary>
    public double Average(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return 0.0;

        return (double)Sum(numbers) / numbers.Length;
    }

    /// <summary>
    /// Etsii suurimman luvun taulukosta.
    /// </summary>
    /// <exception cref="InvalidOperationException">Heitetään jos taulukko on tyhjä</exception>
    public int FindMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new InvalidOperationException("Taulukko ei voi olla tyhjä");

        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
        }
        return max;
    }

    /// <summary>
    /// Etsii pienimmän luvun taulukosta.
    /// </summary>
    /// <exception cref="InvalidOperationException">Heitetään jos taulukko on tyhjä</exception>
    public int FindMin(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new InvalidOperationException("Taulukko ei voi olla tyhjä");

        int min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];
        }
        return min;
    }

    /// <summary>
    /// Tarkistaa sisältääkö taulukko tietyn arvon.
    /// </summary>
    public bool Contains(int[] numbers, int value)
    {
        if (numbers == null || numbers.Length == 0)
            return false;

        foreach (int number in numbers)
        {
            if (number == value)
                return true;
        }
        return false;
    }

    /// <summary>
    /// Kääntää taulukon ympäri.
    /// </summary>
    public int[] Reverse(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return new int[0];

        int[] reversed = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            reversed[i] = numbers[numbers.Length - 1 - i];
        }
        return reversed;
    }

    /// <summary>
    /// Palauttaa taulukon parilliset luvut.
    /// </summary>
    public int[] GetEvenNumbers(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return new int[0];

        List<int> evenNumbers = new List<int>();
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
                evenNumbers.Add(number);
        }
        return evenNumbers.ToArray();
    }

    /// <summary>
    /// Laskee kuinka monta kertaa arvo esiintyy taulukossa.
    /// </summary>
    public int CountOccurrences(int[] numbers, int value)
    {
        if (numbers == null || numbers.Length == 0)
            return 0;

        int count = 0;
        foreach (int number in numbers)
        {
            if (number == value)
                count++;
        }
        return count;
    }

    /// <summary>
    /// Poistaa duplikaatit taulukosta.
    /// </summary>
    public int[] RemoveDuplicates(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return new int[0];

        List<int> unique = new List<int>();
        foreach (int number in numbers)
        {
            if (!unique.Contains(number))
                unique.Add(number);
        }
        return unique.ToArray();
    }
}
