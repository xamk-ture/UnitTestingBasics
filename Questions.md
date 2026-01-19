# Yksikkötestaus - Teoriakysymykset

## Vastausohjeet

1. Kirjoita vastaukset tähän samaan tiedostoon kysymysten alle
2. Ole rehellinen - ei haittaa jos et tiedä kaikkea, saat kyllä palautetta tarvittaessa
4. Käytä esimerkkejä havainnollistamaan vastauksiasi
5. Voit käyttää koodiesimerkkejä (```csharp ... ```)

**Muista:** Vastauksia ei arvioida "oikein/väärin" -periaatteella, vaan sen mukaan miten hyvin olet ymmärtänyt käsitteet ja osaat selittää ne omin sanoin.

---

## 1. Yksikkötestauksen perusteet

### 1.1 Mikä on yksikkötesti?
Selitä omin sanoin: Mikä on yksikkötesti ja mitä sillä testataan?

### 1.2 Mitkä ovat yksikkötestin ominaisuudet?
Listaa ja selitä lyhyesti vähintään 4 yksikkötestin tärkeää ominaisuutta.

### 1.3 Miksi yksikkötestaus on tärkeää?
Anna vähintään 3 syytä miksi yksikkötestaus on tärkeä osa ohjelmistokehitystä.

---

## 2. AAA-malli

### 2.1 Mitä AAA tarkoittaa?
Selitä lyhyesti mitä jokainen kirjain tarkoittaa ja mitä kussakin vaiheessa tehdään:
- A: Arrange
- A: Act
- A: Assert

### 2.2 Miksi AAA-mallia käytetään?
Miksi on hyvä järjestää testit AAA-mallin mukaan?

---

## 3. xUnit-attribuutit

### 3.1 [Fact] attribuutti
- Mihin `[Fact]`-attribuuttia käytetään?
- Milloin käyttäisit `[Fact]`-attribuuttia?

### 3.2 [Theory] ja [InlineData] attribuutit
- Mihin `[Theory]` ja `[InlineData]` -attribuutteja käytetään?
- Mikä etu niillä on verrattuna `[Fact]`-attribuuttiin?
- Anna esimerkki tilanteesta, jossa `[Theory]` olisi parempi valinta kuin `[Fact]`.

---

## 4. Assert-metodit

### 4.1 Assert.Equal
Mitä `Assert.Equal(expected, actual)` tekee?

### 4.2 Assert.True ja Assert.False
Milloin käyttäisit `Assert.True()` ja `Assert.False()` -metodeja?

### 4.3 Assert.Throws
- Mihin `Assert.Throws<ExceptionType>()` käytetään?
- Miksi poikkeusten testaaminen on tärkeää?

### 4.4 Assert.Null ja Assert.NotNull
Anna esimerkki tilanteesta, jossa testaisit että jokin arvo on null tai ei ole null.

---

## 5. Testien nimeäminen

### 5.1 Nimeämiskäytäntö
- Mikä on hyvä nimeämiskäytäntö testeille?
- Mitä testin nimestä pitäisi selvitä?

### 5.2 Esimerkkinimiä
Anna 3 esimerkkiä hyvin nimetyistä testeistä ja selitä miksi ne ovat hyviä.

---

## 6. Testattavat skenaariot

### 6.1 Mitä testata?
Listaa vähintään 3 erilaista skenaariotyyppiä, jotka pitäisi testata.

### 6.2 Rajatapaukset
- Mitä ovat rajatapaukset (edge cases)?
- Anna 2-3 esimerkkiä rajatapauksista, joita pitäisi testata.

---

## 7. Test-Driven Development (TDD)

### 7.1 Mikä on TDD?
Selitä omin sanoin: Mikä on Test-Driven Development?

### 7.2 TDD:n vaiheet
Selitä TDD:n kolme vaihetta:
1. RED
2. GREEN
3. REFACTOR

### 7.3 TDD:n hyödyt
Anna vähintään 2 etua TDD-menetelmän käytöstä.

### 7.4 TDD:n haasteet
Mikä TDD:ssä voi olla haastavaa tai hidastavaa?

---

## 8. Testien organisointi

### 8.1 Testiprojektin nimeäminen
Jos sinulla on projekti nimeltä `MyApp`, miten nimeäisit sen testiprojektin?

### 8.2 Testiluokkien nimeäminen
Jos testaat luokkaa `Calculator`, miten nimeäisit testiluokan?

### 8.3 Testien jakaminen
Miten testit kannattaa jakaa eri tiedostoihin suuremmissa projekteissa?

---

## 9. Testien ajaminen

### 9.1 Visual Studio
- Miten ajat kaikki testit Visual Studiossa?
- Miten ajat vain yhden testin?

### 9.2 Komentoriviltä
Mikä komento ajaa testit komentoriviltä .NET-projektissa?

### 9.3 Testien tulkinta
- Mitä tarkoittaa kun testi on "vihreä" (passed)?
- Mitä tarkoittaa kun testi on "punainen" (failed)?
- Mitä pitää tehdä jos testi epäonnistuu?

---

## 10. Parhaat käytännöt

### 10.1 Yksi assert per testi
- Miksi yleensä suositellaan että testissä on vain yksi Assert?
- Milloin voisi olla OK käyttää useampaa Assertia yhdessä testissä?

### 10.2 Testien riippumattomuus
- Mitä tarkoittaa että testit ovat riippumattomia toisistaan?
- Miksi tämä on tärkeää?
- Anna esimerkki huonosta tavasta, jossa testit riippuvat toisistaan.

### 10.3 Mitä EI pitäisi testata?
Anna 2-3 esimerkkiä asioista, joita EI kannata testata yksikkötesteissä.

---


