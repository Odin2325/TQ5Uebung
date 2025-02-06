using ProgrammierenLernen;

namespace TestingSuite
{
    internal class Bib_Testing
    {
        private BibKunde BibKundeErstellen(string vorname)
        {
            return new BibKunde(vorname, "Mustermann", 23, "Fussweg 2", 0, "1234");
        }
        private Bibliothek BibErstellen()
        {
            return new Bibliothek("Staatsbib", "Landshuterstrasse 10");
        }

        private BuchVereinfacht BuchErstellen(string titel)
        {
            return new BuchVereinfacht(100, "Bob", titel, "Bibliography", "1", "1234", 10, "1990", "Test Buch", new DateOnly());
        }

        [Test]
        public void KundeBuchAusleihen_StaBibKundeBuch_BuchVonKatalogEntferntUndAusgeliehen()
        {
            //Arrange
            var bib = BibErstellen();
            var kunde = BibKundeErstellen("James");
            var buch = BuchErstellen("Moby Dick");

            //Act
            bib.BuecherKaufen(buch, 10);
            var resultat = bib.KundeBuch_Ausleiehen(kunde, buch);
            var anzahlKopien = bib.Katalog[buch];

            //Assert
            Assert.That(anzahlKopien, Is.EqualTo(9));
            Assert.That(resultat, Is.True);
        }

        [Test]
        public void KundeBuchAusleihen_StaBibKundeVoll_ZuVieleBuecher()
        {
            //Arrange
            var bib = BibErstellen();
            var kunde = BibKundeErstellen("James");
            var buch = BuchErstellen("Moby Dick");

            //Act
            bib.BuecherKaufen(buch, 10);
            bib.KundeBuch_Ausleiehen(kunde, buch);
            bib.KundeBuch_Ausleiehen(kunde, buch);
            bib.KundeBuch_Ausleiehen(kunde, buch);
            var resultat = bib.KundeBuch_Ausleiehen(kunde, buch);

            //Asssert
            Assert.That(resultat, Is.False);
        }

        [Test]
        public void KundeBuchAusleihen_StaBibKundeBuch_BuchNichtEnthalten()
        {
            //Arrange
            var bib = BibErstellen();
            var kunde = BibKundeErstellen("James");
            var buch = BuchErstellen("Moby Dick");

            //Act
            var resultat = bib.KundeBuch_Ausleiehen(kunde, buch);

            //Asssert
            Assert.That(resultat, Is.False);
        }

        [Test]
        public void KundeErstellen_StandardBibKunde_KundeErfolgreichErstellt()
        {
            //Arrange
            var bib = BibErstellen();
            var kunde = BibKundeErstellen("Bobby");

            //Act
            var result = bib.KundeHinzufuegen(kunde);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void KundeErstellen_StandardBibKunde_KundeExistiertSchon()
        {
            //Arrange
            var bib = BibErstellen();
            var kunde = BibKundeErstellen("Bobby");

            //Act
            bib.KundeHinzufuegen(kunde);
            var result = bib.KundeHinzufuegen(kunde);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void BuecherEntfernen_StandardBibBuch_BuchWirdEntfernt()
        {
            //Arrange
            var bib = BibErstellen();
            var buch = BuchErstellen("Tom Sawyer");

            //Act
            bib.BuecherKaufen(buch, 10);
            bib.BuecherEntfernen(buch);

            //Assert
            Assert.That(!bib.Katalog.ContainsKey(buch));
        }

        [Test]
        public void BuecherEntfernen_StandardBibKeinBuch_LiefertFalsch()
        {
            //Arrange
            var bib = BibErstellen();
            var buch = BuchErstellen("Tom Sawyer");

            //Act
            var resultat = bib.BuecherEntfernen(buch);

            //Assert
            Assert.That(!resultat);
        }

        [Test]
        public void BuecherKaufen_StandardBibBuch_BuchWirdHinzugefuegt()
        {
            //Arrange
            var bib = BibErstellen();
            var buch = BuchErstellen("Tom Sawyer");

            //Act
            bib.BuecherKaufen(buch, 10);

            //Assert
            Assert.That(bib.Katalog.ContainsKey(buch));
        }

        [Test]
        public void BuecherKaufen_BuchEnthalten_MengeWirdErhoeht()
        {
            //Arrange
            var bib = BibErstellen();
            var buch = BuchErstellen("Tom Sawyer");

            //Act
            bib.BuecherKaufen(buch, 10);
            bib.BuecherKaufen(buch, 5);
            var resultat = 15;

            //Assert
            Assert.That(resultat, Is.EqualTo(bib.Katalog[buch]));
        }

        [Test]
        public void KatalogAusgeben_StandardBuch_StartetMitRichtigerFormat()
        {
            //Arrange
            var bib = BibErstellen();
            var buch1 = BuchErstellen("Harry Potter");
            var buch2 = BuchErstellen("Lord of the flies");

            //Act
            bib.BuecherKaufen(buch1, 10);
            bib.BuecherKaufen(buch2, 30);
            var result = bib.KatalogAusgeben();

            //Assert
            Assert.That(result.StartsWith("Buch Name\t\t|Buch Anzahl"));
        }
    }
}
