using Xunit;

namespace CalculatorApp.Tests;

/// <summary>
/// Testit Calculator-luokalle.
/// TEHTÄVÄ: Kirjoita testit jokaiselle Calculator-luokan metodille.
/// </summary>
public class CalculatorTests
{
    // TEHTÄVÄ 1.1: Kirjoita testit Add-metodille
    // - Testi positiivisille luvuille
    // - Testi negatiivisille luvuille
    // - Testi nollalla
    // Muista käyttää AAA-mallia: Arrange, Act, Assert

    // TEHTÄVÄ 1.2: Kirjoita testit Subtract-metodille
    // - Testi normaalille vähennyslaskulle
    // - Testi kun tulos on negatiivinen
    // - Testi nollalla

    // TEHTÄVÄ 1.3: Kirjoita testit Multiply-metodille
    // - Testi positiivisille luvuille
    // - Testi nollalla
    // - Testi negatiivisella ja positiivisella

    // TEHTÄVÄ 1.4: Kirjoita testit Divide-metodille
    // - Testi normaalille jakolaskulle
    // - Testi kun tulos on desimaaliluku
    // - Testi että heittää DivideByZeroException kun jaetaan nollalla
    //   Vihje: Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));

    // TEHTÄVÄ 1.5: Kirjoita testit IsEven-metodille
    // - Testi parilliselle luvulle
    // - Testi parittomalle luvulle
    // - Testi nollalle
    // - Testi negatiiviselle parilliselle

    // TEHTÄVÄ 1.6: Kirjoita testit Square-metodille
    // - Testi positiiviselle luvulle
    // - Testi nollalle
    // - Testi negatiiviselle luvulle

    // TEHTÄVÄ 1.7: Kirjoita testit Max-metodille
    // - Testi kun ensimmäinen on suurempi
    // - Testi kun toinen on suurempi
    // - Testi kun molemmat ovat yhtä suuria
}
