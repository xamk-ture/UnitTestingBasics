# Yksikkötestausharjoitus - Perusharjoitus

Tämä harjoitus opettaa yksikkötestauksen perusteet ja Test-Driven Development (TDD) -menetelmän C#:ssa käyttäen xUnit-frameworkia.

## Tavoitteet

Tämän harjoituksen jälkeen osaat:
- Kirjoittaa yksikkötestejä xUnit:illa
- Soveltaa TDD-menetelmää (Test-Driven Development)
- Luoda uusia projekteja ja lisätä ne solutioniin
- Käyttää AAA-mallia (Arrange-Act-Assert)
- Testata eri skenaarioita (normaalit tapaukset, rajatapaukset, virhetilanteet)

## Hyödyllisiä linkkejä

### Wiki-materiaalit
- [Yksikkötestaus - Teoria](https://github.com/xamk-mire/Xamk-wiki/tree/main/C%23/fin/04-Advanced/UnitTesting)

### Ulkoiset resurssit
- [xUnit dokumentaatio](https://xunit.net/)
- [Microsoft: Unit testing](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test)

---

## Palauttaminen

Palauta:
1. Kaikki koodimuutokset pushattu repoon, ja kysymyksiin vastattu

**Varmista että:**
- ✅ Kaikki testit menevät läpi: `dotnet test`
- ✅ Olet vastannut teoriakysymyksiin
- ✅ Koodi on siistiä ja kommentoitua

---

## Arviointiperusteet

### Hyväksytty 
- ✅ OSA 1: Calculator-testit kirjoitettu (vähintään 15 testiä)
- ✅ Testit menevät läpi
- ✅ Teoriakysymyksiin vastattu

### Hyvä 
- ✅ OSA 1: Calculator ja StringHelper testit (vähintään 30 testiä)
- ✅ OSA 2: ArrayHelper-projekti luotu ja aloitettu (vähintään 3 metodia)
- ✅ Kattavat testit (normaalit + rajatapaukset)
- ✅ Hyvät vastaukset teoriakysymyksiin

### Kiitettävä 
- ✅ OSA 1: Kaikki testit toteutettu kattavasti (38+ testiä)
- ✅ OSA 2: ArrayHelper toteutettu täysin TDD:llä (kaikki 9 metodia)
- ✅ Erinomaiset testit kaikille (normaalit + rajat + virheet)
- ✅ Koodi on siistiä ja hyvin dokumentoitua
- ✅ Erinomaiset vastaukset teoriakysymyksiin
- ✅ Käytetty `[Theory]` ja `[InlineData]`

---


## Tuki ja kysymykset

Jos tarvitset apua:
1. Tarkista ensin wiki-materiaalit
2. Googlaa virheilmoituksia
3. Kysy luokkakavereilta tai opettajalta

## Tehtävän rakenne

### OSA 1: Kirjoita testit valmiille koodille 
Projektit ja koodi on jo valmiina. Sinun tehtäväsi on kirjoittaa kattavat testit `Calculator`- ja `StringHelper`-luokille.

### OSA 2: TDD - Luo oma projekti 
Luot itse uuden `ArrayHelper`-projektin samaan solutioniin ja toteutat sen täysin TDD-menetelmällä (testit ensin, sitten koodi).

---

## Aloitus

### 1. Avaa projekti

**Visual Studiossa:**
1. Avaa `UnitTestingBasics.sln` -tiedosto
2. Solution Explorer näyttää kaksi projektia:
   - `CalculatorApp` (class library -projekti)
   - `CalculatorApp.Tests` (testiprojekti)

**TAI Komentoriviltä:**
```bash
cd Assigments/UnitTestingBasics
dotnet build
```

### 2. Tutustu koodiin

Avaa ja tutustu näihin tiedostoihin:
- `CalculatorApp/Calculator.cs` - Laskinluokka (7 metodia)
- `CalculatorApp/StringHelper.cs` - Merkkijono-apuluokka (4 metodia)

---

## OSA 1: Kirjoita testit valmiille koodille (60 min)

### Tavoite
Kirjoita kattavat testit `Calculator`- ja `StringHelper`-luokille.

### Tehtävä 1.1: Calculator-testit

Avaa tiedosto `CalculatorApp.Tests/CalculatorTests.cs`.

Kirjoita testit jokaiselle metodille. Jokaisen metodin kohdalla testaa:
- ✅ Normaali tapaus
- ✅ Rajatapaukset (nolla, negatiiviset, jne.)
- ✅ Virhetilanteet (poikkeukset)

#### Esimerkki: Add-metodi

```csharp
[Fact]
public void Add_PositiveNumbers_ReturnsSum()
{
    // Arrange
    Calculator calculator = new Calculator();
    int a = 5;
    int b = 3;
    int expected = 8;

    // Act
    int result = calculator.Add(a, b);

    // Assert
    Assert.Equal(expected, result);
}

[Fact]
public void Add_NegativeNumbers_ReturnsSum()
{
    // Arrange
    Calculator calculator = new Calculator();

    // Act
    int result = calculator.Add(-5, -3);

    // Assert
    Assert.Equal(-8, result);
}

[Fact]
public void Add_WithZero_ReturnsOtherNumber()
{
    // Arrange
    Calculator calculator = new Calculator();

    // Act
    int result = calculator.Add(5, 0);

    // Assert
    Assert.Equal(5, result);
}
```

#### Metodit joille kirjoitat testit:
1. ✅ `Add(int a, int b)` - 3+ testiä
2. ✅ `Subtract(int a, int b)` - 3+ testiä
3. ✅ `Multiply(int a, int b)` - 3+ testiä
4. ✅ `Divide(int a, int b)` - 3+ testiä (sisältäen poikkeustestin!)
5. ✅ `IsEven(int number)` - 4+ testiä
6. ✅ `Square(int number)` - 3+ testiä
7. ✅ `Max(int a, int b)` - 3+ testiä

**Yhteensä:** Vähintään 22 testiä

#### Vinkkejä:

**Poikkeustestaus:**
```csharp
[Fact]
public void Divide_ByZero_ThrowsDivideByZeroException()
{
    // Arrange
    Calculator calculator = new Calculator();

    // Act & Assert
    Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
}
```

**Desimaalilukujen vertailu:**
```csharp
[Fact]
public void Divide_ReturnsDecimal_WithPrecision()
{
    // Arrange
    Calculator calculator = new Calculator();

    // Act
    double result = calculator.Divide(10, 3);

    // Assert
    Assert.Equal(3.333333, result, 5); // 5 desimaalin tarkkuus
}
```

### Tehtävä 1.2: StringHelper-testit

Avaa tiedosto `CalculatorApp.Tests/StringHelperTests.cs`.

Kirjoita testit jokaiselle metodille:

1. ✅ `Reverse(string input)` - 3+ testiä
2. ✅ `IsPalindrome(string input)` - 4+ testiä
3. ✅ `CountWords(string input)` - 5+ testiä
4. ✅ `Capitalize(string input)` - 4+ testiä

**Yhteensä:** Vähintään 16 testiä

#### Tärkeät testiskenaariot:
- Normaali merkkijono
- Tyhjä merkkijono (`""`)
- Null-arvo (jos käsitellään)
- Isot ja pienet kirjaimet (case-sensitivity)
- Välilyönnit

### Testien ajaminen

**Komentoriviltä:**
```bash
dotnet test
```

**Visual Studiossa:**
- `Ctrl + R, A` - Aja kaikki testit
- `Ctrl + R, T` - Aja nykyinen testi
- `Test Explorer`: `Test` → `Test Explorer`

**Tavoite:** Kaikki testit vihreänä! ✅

---

## OSA 2: TDD - Luo oma projekti (90 min)

Nyt luot itse uuden `ArrayHelper`-projektin ja toteutat sen TDD-menetelmällä.

### TDD-prosessi

```
1. RED   → Kirjoita testi joka epäonnistuu (koska koodia ei ole vielä)
2. GREEN → Kirjoita minimaalinen koodi joka saa testin läpi
3. REFACTOR → Paranna koodia (jos tarpeen)
```

### Vaihe 2.1: Luo uusi projekti ArrayHelper

**Komentoriviltä:**
```bash
# Varmista että olet UnitTestingBasics-kansiossa
cd Assigments/UnitTestingBasics

# Luo uusi class library -projekti
dotnet new classlib -n ArrayHelper

# Lisää solutioniin
dotnet sln add ArrayHelper/ArrayHelper.csproj

# Poista default Class1.cs
del ArrayHelper\Class1.cs
```

**TAI Visual Studiossa:**
1. Solution Explorer → Oikea klikkaus "Solution 'UnitTestingBasics'"
2. Add → New Project
3. Valitse "Class Library"
4. Nimi: `ArrayHelper`
5. Create
6. Poista `Class1.cs` -tiedosto

### Vaihe 2.2: Luo testiprojekti ArrayHelper.Tests

**Komentoriviltä:**
```bash
# Luo xUnit-testiprojekti
dotnet new xunit -n ArrayHelper.Tests

# Lisää solutioniin
dotnet sln add ArrayHelper.Tests/ArrayHelper.Tests.csproj

# Lisää projektiviittaus
cd ArrayHelper.Tests
dotnet add reference ../ArrayHelper/ArrayHelper.csproj
cd ..
```

**TAI Visual Studiossa:**
1. Solution Explorer → Oikea klikkaus "Solution 'UnitTestingBasics'"
2. Add → New Project
3. Valitse "xUnit Test Project"
4. Nimi: `ArrayHelper.Tests`
5. Create
6. Lisää projektiviittaus xUnit projektiin, jotta voit testata ArrayHelperin methodeja:
   - Oikea klikkaus "Dependencies" (ArrayHelper.Tests-projektin alla)
   - Add Project Reference
   - Valitse "ArrayHelper"

### Vaihe 2.3: Siivoa pois automaattisesti luotu luokka

Poista tiedosto:
- `ArrayHelper.Tests/UnitTest1.cs`

### Vaihe 2.4: Luo ArrayHelper-luokka (tyhjä)

**ArrayHelper/ArrayHelper.cs:**
```csharp
namespace ArrayHelper;

/// <summary>
/// Apuluokka taulukoiden käsittelyyn.
/// </summary>
public class ArrayHelper
{
    // Metodit lisätään TDD:llä
}
```

### Vaihe 2.5: Toteutettavat metodit TDD:llä

Toteuta seuraavat metodit **yksi kerrallaan** TDD-prosessilla.

Jokaisessa:
1. Luo tyhjä metodi ja laita se palauttamaan (`throw new NotImplementedException();`)
2. Kirjoita testit (muista nimetä hyvin)
3. Aja testit (RED)
4. Toteuta metodi
5. Aja testit (GREEN)
6. Refaktoroi (jos tarpeen)

Esimerkki:

#### 2.5.1 Sum - Laske taulukon summa

**Metodi:**
```csharp
/// <summary>
/// Laskee taulukon lukujen summan.
/// </summary>
public int Sum(int[] numbers)
{
    throw new NotImplementedException();
}
```

**Testit (ArrayHelper.Tests/ArrayHelperTests.cs):**
```csharp
using Xunit;

namespace ArrayHelper.Tests;

public class ArrayHelperTests
{
    [Fact]
    public void Sum_ValidArray_ReturnsSum()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Act
        int result = helper.Sum(numbers);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Sum_EmptyArray_ReturnsZero()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();
        int[] numbers = { };

        // Act
        int result = helper.Sum(numbers);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Sum_NullArray_ReturnsZero()
    {
        // Arrange
        ArrayHelper helper = new ArrayHelper();

        // Act
        int result = helper.Sum(null);

        // Assert
        Assert.Equal(0, result);
    }
}
```

**Toteutus:**
```csharp
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
```

#### 2.5.2 Average - Laske keskiarvo

**Sinä teet:**
- Tyhjä metodi
- Vähintään 2 testiä
- Toteutus

**Testaa:**
- Normaali taulukko
- Tyhjä taulukko (palauttaa 0.0)

#### 2.5.3 FindMax - Etsi suurin luku

**Sinä teet:**
- Tyhjä metodi
- Vähintään 3 testiä
- Toteutus

**Testaa:**
- Normaali taulukko
- Negatiiviset luvut
- Tyhjä taulukko → Heitä `InvalidOperationException`

**Poikkeuksen heittäminen:**
```csharp
if (numbers == null || numbers.Length == 0)
    throw new InvalidOperationException("Taulukko on tyhjä");
```

#### 2.5.4 FindMin - Etsi pienin luku

**Sinä teet:**
- Vastaava kuin FindMax, mutta pienin luku

#### 2.5.5 Contains - Sisältääkö taulukko arvon

**Sinä teet:**
- Palauttaa true jos arvo löytyy, muuten false

**Testaa:**
- Löytyy
- Ei löydy
- Tyhjä taulukko

#### 2.5.6 Reverse - Käännä taulukko

**Sinä teet:**
- Palauttaa uuden taulukon käänteisessä järjestyksessä

**Testaa:**
- Normaali taulukko
- Tyhjä taulukko

#### 2.5.7 GetEvenNumbers - Palauta parilliset

**Sinä teet:**
- Palauttaa uuden taulukon, joka sisältää vain parilliset luvut

**Testaa:**
- Sekalaiset luvut
- Vain parittomat (palauttaa tyhjä taulukko)

#### 2.5.8 CountOccurrences - Laske esiintymät

**Sinä teet:**
- Laskee kuinka monta kertaa tietty arvo esiintyy taulukossa

**Testaa:**
- Useita esiintymiä
- Ei yhtään esiintymää

#### 2.5.9 RemoveDuplicates - Poista duplikaatit

**Sinä teet:**
- Palauttaa uuden taulukon ilman duplikaatteja

**Testaa:**
- Duplikaatteja
- Ei duplikaatteja

**Vihje:** Voit käyttää `Distinct()` LINQ-metodia tai tehdä itse silmukalla.

---

## OSA 3: Teoria ja dokumentointi 

Vastaa kysymyksiin tiedostossa [Questions.md](Questions.md).


---

## Vinkkejä

### AAA-malli

Jokainen testi kannattaa rakentaa AAA-mallin mukaan:

```csharp
[Fact]
public void MethodName_Scenario_ExpectedResult()
{
    // Arrange - Valmistele
    // Luo tarvittavat oliot ja muuttujat

    // Act - Toimi
    // Kutsu testattavaa metodia

    // Assert - Varmista
    // Tarkista että tulos on odotettu
}
```

### Testien nimeäminen

Hyvä nimeämiskäytäntö:
```
MethodName_Scenario_ExpectedResult
```

Esimerkkejä:
- `Add_PositiveNumbers_ReturnsSum`
- `Divide_ByZero_ThrowsException`
- `IsPalindrome_ValidPalindrome_ReturnsTrue`

### Yleisiä Assert-metodeja

```csharp
Assert.Equal(expected, actual);          // Yhtäsuuruus
Assert.NotEqual(expected, actual);       // Erisuuruus
Assert.True(condition);                  // Tosi
Assert.False(condition);                 // Epätosi
Assert.Null(object);                     // Null
Assert.NotNull(object);                  // Ei null
Assert.Throws<ExceptionType>(() => {});  // Poikkeus
Assert.Empty(collection);                // Tyhjä kokoelma
Assert.Contains(item, collection);       // Sisältää
```

### Theory ja InlineData 

Jos haluat testata samaa asiaa monilla syötteillä:

```csharp
[Theory]
[InlineData(2, 3, 5)]
[InlineData(0, 0, 0)]
[InlineData(-1, 1, 0)]
public void Add_VariousInputs_ReturnsSum(int a, int b, int expected)
{
    // Arrange
    Calculator calculator = new Calculator();

    // Act
    int result = calculator.Add(a, b);

    // Assert
    Assert.Equal(expected, result);
}
```

---




