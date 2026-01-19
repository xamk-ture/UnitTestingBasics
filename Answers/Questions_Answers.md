# Yksikkötestaus - Mallivastaukset (Opettajalle)

**HUOM:** Nämä ovat mallivastauksia. Hyväksy myös muita vastauksia, kunhan opiskelija osoittaa ymmärrystä!

---

## 1. Yksikkötestauksen perusteet

### 1.1 Mikä on yksikkötesti?

**Mallivastaus:**
Yksikkötesti on automaattinen testi, joka testaa pienen osan koodista eristettynä muusta järjestelmästä. Tyypillisesti yksi testi testaa yhtä metodia tai yhtä toiminnallisuutta kerrallaan. Yksikkötestin pitää olla nopea, riippumaton muista testeistä ja toistettava.

### 1.2 Mitkä ovat yksikkötestin ominaisuudet?

**Mallivastaus:**
1. **Nopea** - Suoritus kestää vain millisekunteja
2. **Eristetty** - Ei riipu ulkoisista resursseista kuten tietokannasta
3. **Toistettava** - Antaa aina saman tuloksen samoilla syötteillä
4. **Itsenäinen** - Ei riipu muista testeistä
5. **Selkeä** - Testaa vain yhtä asiaa kerrallaan

### 1.3 Miksi yksikkötestaus on tärkeää?

**Mallivastaus:**
1. **Havaitsee virheet aikaisin** - Virheet löytyvät heti kehitysvaiheessa, ei vasta tuotannossa
2. **Helpottaa refaktorointia** - Voit muuttaa koodia turvallisesti, testit kertovat jos rikot jotain
3. **Dokumentoi koodia** - Testit näyttävät miten koodia pitää käyttää
4. **Säästää aikaa pitkällä tähtäimellä** - Vähemmän bugeja, nopea debuggaus
5. **Parantaa koodin laatua** - Testattava koodi on usein paremmin suunniteltua

---

## 2. AAA-malli

### 2.1 Mitä AAA tarkoittaa?

**Mallivastaus:**
- **A: Arrange (Järjestä)** - Valmistele testi: luo objektit, aseta alkuarvot
- **A: Act (Toimi)** - Suorita testattava toiminto, kutsu testattavaa metodia
- **A: Assert (Varmista)** - Tarkista tulos: vertaa tulosta odotukseen

### 2.2 Miksi AAA-mallia käytetään?

**Mallivastaus:**
AAA-malli tekee testeistä selkeitä ja helposti luettavia. Jokainen testi on rakennettu samalla tavalla, joten on helppo ymmärtää mitä testi tekee. Malli erottaa selkeästi valmisteluvaiheen, varsinaisen toiminnon ja tulosten tarkistuksen toisistaan.

---

## 3. xUnit-attribuutit

### 3.1 [Fact] attribuutti

**Mallivastaus:**
- `[Fact]` merkitsee metodin yksikkötestiksi joka ei ota parametreja
- Käytetään kun testataan yhtä tiettyä skenaariota
- Esimerkki: `[Fact] public void Add_PositiveNumbers_ReturnsSum()`

### 3.2 [Theory] ja [InlineData] attribuutit

**Mallivastaus:**
- `[Theory]` merkitsee parametrisoidun testin
- `[InlineData]` tarjoaa testidatan parametreina
- Etuna on että voi ajaa saman testin useilla eri syötteillä ilman koodin toistoa
- Esimerkki: Testata Add-metodia kymmenellä eri lukuparilla kirjoittamalla vain yksi testi

```csharp
[Theory]
[InlineData(2, 3, 5)]
[InlineData(0, 0, 0)]
[InlineData(-1, 1, 0)]
public void Add_VariousInputs_ReturnsSum(int a, int b, int expected)
{
    // ...
}
```

---

## 4. Assert-metodit

### 4.1 Assert.Equal

**Mallivastaus:**
`Assert.Equal(expected, actual)` tarkistaa että kaksi arvoa ovat yhtäsuuret. Jos ne eivät ole, testi epäonnistuu. Ensimmäinen parametri on odotettu arvo ja toinen on todellinen arvo.

### 4.2 Assert.True ja Assert.False

**Mallivastaus:**
- `Assert.True(condition)` - Tarkistaa että ehto on tosi
- `Assert.False(condition)` - Tarkistaa että ehto on epätosi
- Käytetään kun testattava metodi palauttaa boolean-arvon
- Esimerkki: `Assert.True(calculator.IsEven(4))`

### 4.3 Assert.Throws

**Mallivastaus:**
- `Assert.Throws<ExceptionType>()` tarkistaa että metodi heittää tietyn poikkeuksen
- Poikkeusten testaaminen on tärkeää koska:
  - Varmistaa että virhetilanteet käsitellään oikein
  - Estää ohjelmaa kaatumasta odottamattomasti
  - Dokumentoi milloin ja miksi poikkeus heitetään

```csharp
Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
```

### 4.4 Assert.Null ja Assert.NotNull

**Mallivastaus:**
Esimerkkejä:
- `Assert.Null(user)` - Varmistaa että käyttäjää ei löytynyt (null)
- `Assert.NotNull(result)` - Varmistaa että tietokantahaku palautti tuloksen
- Käytetään kun testataan että metodi palauttaa null tietyissä tilanteissa tai varmistetaan että tulos ei ole null

---

## 5. Testien nimeäminen

### 5.1 Nimeämiskäytäntö

**Mallivastaus:**
Hyvä nimeämiskäytäntö testeille on: `MethodName_Scenario_ExpectedBehavior`

Testin nimestä pitäisi selvitä:
1. Mitä metodia testataan
2. Millä syötteellä/tilanteessa
3. Mitä odotetaan tapahtuvan

### 5.2 Esimerkkinimiä

**Mallivastaus:**
1. `Add_PositiveNumbers_ReturnsSum` - Selkeä, kertoo että testataan Add-metodia positiivisilla luvuilla ja odotetaan summaa
2. `Divide_ByZero_ThrowsDivideByZeroException` - Kertoo että testataan jakamista nollalla ja odotetaan poikkeusta
3. `IsValidEmail_InvalidFormat_ReturnsFalse` - Kertoo että testataan sähköpostin validointia väärällä muodolla ja odotetaan false

---

## 6. Testattavat skenaariot

### 6.1 Mitä testata?

**Mallivastaus:**
1. **Happy path** - Normaalit tapaukset kun kaikki menee hyvin
2. **Rajatapaukset** - Tyhjät arvot, nollat, negatiiviset luvut, minimiet ja maksimit
3. **Virhetilanteet** - Poikkeukset, virheelliset syötteet
4. **Erikoistapaukset** - Erityiset tilanteet jotka liittyvät logiikkaan

### 6.2 Rajatapaukset

**Mallivastaus:**
Rajatapaukset ovat äärimmäisiä tai poikkeuksellisia syötteitä, jotka voivat paljastaa bugeja.

Esimerkkejä:
- Tyhjä merkkijono tai null
- Nolla (jakaminen, indeksointi)
- Negatiiviset luvut kun odotetaan positiivisia
- Taulukon ensimmäinen ja viimeinen indeksi
- Tyhjä taulukko tai lista
- Minimiarvo ja maksimiarvo (int.MinValue, int.MaxValue)

---

## 7. Test-Driven Development (TDD)

### 7.1 Mikä on TDD?

**Mallivastaus:**
TDD (Test-Driven Development) on kehitysmenetelmä jossa testit kirjoitetaan ENNEN varsinaista koodia. Idea on että ensin mietitään mitä koodin pitää tehdä kirjoittamalla testi, ja vasta sitten toteutetaan koodi joka saa testin menemään läpi.

### 7.2 TDD:n vaiheet

**Mallivastaus:**
1. **RED** - Kirjoita testi joka epäonnistuu (koska koodia ei ole vielä)
2. **GREEN** - Kirjoita minimaalinen määrä koodia joka saa testin menemään läpi
3. **REFACTOR** - Paranna koodia ja testejä (jos tarpeen) ilman että testit rikkoontuvat

### 7.3 TDD:n hyödyt

**Mallivastaus:**
- **Parempi suunnittelu** - Pakotetaan miettimään mitä koodi tekee ennen toteutusta
- **100% testikattavuus** - Kaikelle koodille on testit koska ne kirjoitetaan ensin
- **Vähemmän bugeja** - Testit löytävät ongelmat heti
- **Selkeämpi rajapinta** - Testejä kirjoittaessa mietitään miten koodia käytetään
- **Luottamus refaktorointiin** - Testit varmistavat että muutokset eivät riko toiminnallisuutta

### 7.4 TDD:n haasteet

**Mallivastaus:**
- **Hidas alussa** - Vie aikaa kirjoittaa testit ensin
- **Vaatii harjoittelua** - Voi tuntua vaikealta ajatella testejä ensin
- **Ylläpito** - Jos vaatimukset muuttuvat paljon, testejäkin pitää muuttaa
- **Ei sovi kaikkeen** - Esim. UI:n tai prototyyppien kanssa voi olla haastavaa

---

## 8. Testien organisointi

### 8.1 Testiprojektin nimeäminen

**Mallivastaus:**
`MyApp.Tests` - Lisätään `.Tests` projektin nimen perään.

### 8.2 Testiluokkien nimeäminen

**Mallivastaus:**
`CalculatorTests` - Lisätään `Tests` luokan nimen perään.
Yleinen käytäntö: Yksi testiluokka per luokka jota testataan.

### 8.3 Testien jakaminen

**Mallivastaus:**
Isommissa projekteissa testit kannattaa jakaa:
- Kansioihin testattavan projektin rakenteen mukaan (Services/, Controllers/, jne.)
- Yksi testiluokka per tuotantokoodi-luokka
- Voi myös jakaa testiluokat osiin jos yhdessä luokassa on paljon metodeja
- Esim. `CalculatorBasicTests.cs` ja `CalculatorAdvancedTests.cs`

---

## 9. Testien ajaminen

### 9.1 Visual Studio

**Mallivastaus:**
- **Kaikki testit:** Test Explorer → "Run All" (tai `Ctrl + R, A`)
- **Yksi testi:** Klikkaa testiä hiiren oikealla → "Run" (tai `Ctrl + R, T`)

### 9.2 Komentoriviltä

**Mallivastaus:**
`dotnet test` - Ajaa kaikki testit projektissa.

### 9.3 Testien tulkinta

**Mallivastaus:**
- **Vihreä (passed)** - Testi meni läpi, koodi toimii odotetulla tavalla
- **Punainen (failed)** - Testi epäonnistui, joko koodi on väärin tai testi on väärin
- **Jos testi epäonnistuu:**
  1. Lue virheilmoitus huolellisesti
  2. Debuggaa testi (aseta breakpoint)
  3. Tarkista onko testi oikein vai onko koodi buginen
  4. Korjaa joko testi tai koodi
  5. Aja testi uudelleen

---

## 10. Parhaat käytännöt

### 10.1 Yksi assert per testi

**Mallivastaus:**
- **Miksi:** Kun testi epäonnistuu, tiedät heti mikä meni pieleen. Jos on monta Assertia, ensimmäinen epäonnistuminen pysäyttää testin.
- **Poikkeus:** Voi käyttää useampaa Assertia kun testataan saman objektin ominaisuuksia jotka liittyvät yhteen:
```csharp
[Fact]
public void CreateUser_ValidData_SetsProperties()
{
    User user = CreateUser("Matti", 25);
    Assert.Equal("Matti", user.Name); // OK
    Assert.Equal(25, user.Age);        // OK - liittyy samaan
}
```

### 10.2 Testien riippumattomuus

**Mallivastaus:**
**Mitä tarkoittaa:** Testit eivät riipu toistensa tuloksista tai suoritusjärjestyksestä. Jokainen testi toimii itsenäisesti.

**Miksi tärkeää:**
- Testit voidaan ajaa missä tahansa järjestyksessä
- Testit voidaan ajaa rinnakkain (nopeampi)
- Yksi epäonnistunut testi ei kaada muita

**Huono esimerkki:**
```csharp
private static int sharedCounter = 0;

[Fact]
public void Test1() { sharedCounter++; }

[Fact]
public void Test2() 
{ 
    Assert.Equal(1, sharedCounter); // Riippuu Test1:stä!
}
```

### 10.3 Mitä EI pitäisi testata?

**Mallivastaus:**
1. **.NET:n perusluokat** - Esim. `List.Add()` toimii varmasti, Microsoft on testannut sen
2. **Kolmannen osapuolen kirjastot** - Ne on jo testattu
3. **Triviaalit get/set** - Yksinkertaiset property-getterit ja setterit
4. **Käyttöliittymä** - Yksikkötesteissä ei testata UI:ta (siihen on omat työkalut)

---

## 11. Käytännön kokemukset

### 11.1 Vaikein osa

**Esimerkkivastauksia:**
- "Poikkeusten testaaminen oli vaikeaa, syntaksi oli hankala muistaa"
- "TDD-osio oli haastava koska ei tiennyt mistä aloittaa"
- "Rajatapausten keksiminen oli vaikeaa"

*Hyväksy kaikki rehelliset vastaukset*

### 11.2 Mielenkiintoisin oivallus

**Esimerkkivastauksia:**
- "Huomasin että testien kirjoittaminen pakotti miettimään koodia paremmin"
- "TDD-osiossa oli paljon helpompaa kun tiesi mitä koodin pitää tehdä"
- "Assert.Equal:issa parametrien järjestys on tärkeä!"

*Hyväksy kaikki vastaukset jotka osoittavat oppimista*

### 11.3 TDD-kokemus

**Esimerkkivastauksia:**
- "TDD oli helpompaa koska tiesi tarkalleen mitä metodin pitää tehdä"
- "TDD oli vaikeampaa koska piti keksiä itse miten toteuttaa"
- "Oli yllättävää miten helposti koodi syntyi kun testit olivat valmiina"

*Hyväksy erilaisia kokemuksia, kunhan opiskelija perustelee*

---

## 12. Soveltaminen (Valinnainen)

**Arviointi:**
- Anna bonuspisteitä jos opiskelija on miettinyt aihetta syvällisesti
- Hyvä vastaus sisältää konkreettisia esimerkkejä omasta projektista
- Erittäin hyvä vastaus pohtii mitä haasteita voisi olla ja miten niitä voisi ratkaista

---

## Arviointi yhteenveto

### Hyväksytty (1-2)
- Vastaa vähintään 50% kysymyksistä
- Vastaukset osoittavat perustason ymmärrystä
- Jotkin vastaukset voivat olla pinnallisia

### Hyvä (3-4)
- Vastaa vähintään 80% kysymyksistä
- Vastaukset ovat selkeitä ja omaperäisiä
- Käyttää esimerkkejä havainnollistamaan
- Osoittaa hyvää ymmärrystä yksikkötestauksesta

### Kiitettävä (5)
- Vastaa kaikkiin kysymyksiin
- Vastaukset ovat laaja-alaisia ja syvällisiä
- Käyttää hyviä koodiesimerkkejä
- Osaa kriittisesti arvioida ja vertailla
- Vastaa bonuskysymykseen hyvin
