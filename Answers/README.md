# Mallivastaukset opettajalle - UnitTestingBasics

Tämä kansio sisältää esimerkkivastaukset ja -toteutukset opettajan käyttöön.

## Sisältö

### 1. Calculator.cs
Sisältää kaikki Calculator-luokan metodit toteutettuna:
- Add, Subtract, Multiply, Divide
- IsEven, Square, Max

### 2. StringHelper.cs
Sisältää kaikki StringHelper-luokan metodit toteutettuna:
- Reverse, IsPalindrome
- CountWords, Capitalize

### 3. ArrayHelper.cs
Sisältää kaikki ArrayHelper-luokan metodit toteutettuna:
- Sum, Average, FindMax, FindMin
- Contains, Reverse
- GetEvenNumbers, CountOccurrences, RemoveDuplicates

### 4. CalculatorTests.cs
Esimerkkitestit Calculator-luokalle.

### 5. StringHelperTests.cs
Esimerkkitestit StringHelper-luokalle.

### 6. ArrayHelperTests.cs
Esimerkkitestit ArrayHelper-luokalle.

### 7. Questions_Answers.md
Mallivastaukset teoriakysymyksiin.

## Huomioita opettajalle

### Arviointivinkkejä

**Calculator-luokka (Perus):**
- Tarkista että kaikki metodit toimivat oikein
- Testejä pitäisi olla vähintään 3 per metodi
- Poikkeustestaus Divide-metodille on tärkeää

**StringHelper-luokka (Keskitaso):**
- IsPalindrome voi olla haastava - hyväksy eri toteutustavat
- Tarkista että tyhjät merkkijonot käsitellään oikein

**ArrayHelper-luokka (Haastava):**
- Tämä on TDD-osio - tarkista että opiskelija on tehnyt testit ENNEN toteutusta
- Null-tarkistukset ovat tärkeitä
- Poikkeuskäsittely FindMax/FindMin -metodeissa

### Yleisiä virheitä

1. **Testien nimeäminen**: Opiskelijat usein nimeävät testit huonosti (esim. `Test1`, `Test2`)
2. **AAA-mallin puute**: Testit eivät ole selkeästi jaettu Arrange-Act-Assert -osiin
3. **Rajatapausten unohtaminen**: Tyhjät taulukot, null-arvot, negatiiviset luvut
4. **Poikkeusten testaaminen**: Unohdetaan testata että metodit heittävät oikeat poikkeukset
5. **Testien riippuvuus**: Testit riippuvat toisistaan (esim. jakavat staattista tilaa)

### Arviointikriteerit

**Hyväksytty (1-2):**
- Calculator toteutettu ja testattu
- Testit menevät läpi
- Peruskäsitteet ymmärretty

**Hyvä (3-4):**
- Calculator ja StringHelper toteutettu
- Kattavat testit (normaalit + rajatapaukset)
- ArrayHelper aloitettu
- Hyvä ymmärrys TDD:stä

**Kiitettävä (5):**
- Kaikki kolme luokkaa toteutettu täysin
- Erinomaiset testit (normaalit + rajat + virheet)
- Siisti ja hyvin dokumentoitu koodi
- Syvä ymmärrys yksikkötestauksesta ja TDD:stä
- Mahdollisesti käytetty [Theory] ja [InlineData]

### Opetusvinkkejä

**TDD-osion ohjaaminen:**
1. Painota että testit ENSIN, sitten koodi
2. Näytä esimerkki RED-GREEN-REFACTOR -syklistä
3. Korosta että on OK jos ensimmäinen toteutus on "ruma" - refaktorointi tulee myöhemmin

**Yleisiä kysymyksiä:**
- "Pitääkö testata kaikkea?" → Ei, mutta tärkeimmät skenaariot kyllä
- "Montako testiä riittää?" → Vähintään: normaali tapaus, rajatapaus, virhetilanne
- "Voiko testissä olla useampi Assert?" → Voi, mutta yleensä parempi jakaa erillisiksi testeiksi

## Testien ajaminen

```bash
# Aja kaikki testit
dotnet test

# Aja testit yksityiskohtaisella tulostuksella
dotnet test --verbosity normal

# Aja vain tietyn luokan testit
dotnet test --filter FullyQualifiedName~CalculatorTests
```

## Lisämateriaali opettajalle

- [xUnit dokumentaatio](https://xunit.net/)
- [Microsoft: Unit testing best practices](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
- [Martin Fowler: Test Pyramid](https://martinfowler.com/articles/practical-test-pyramid.html)
