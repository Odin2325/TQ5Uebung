using ProgrammierenLernen;

namespace TestingSuite
{
    internal class BibKunde_Testing
    {
        public BibKunde StandardBibKunde_Erzeugen()
        {
            var bibKunde = new BibKunde("Nicolas","Arevalo",30,"Muenchner Strasse 1",40,"0101");

            return bibKunde;
        }

        public BuchVereinfacht[] StandardBuecher_Erzeugen()
        {
            BuchVereinfacht[] buecher = new BuchVereinfacht[3];
            buecher[0] = new BuchVereinfacht(280, "Max Musterman", "Mustermans Adventures", "Sci-Fi", "1.", "387239183934857", 14.99m, "1990", "Dies ist mein Leben.", new DateOnly());
            buecher[1] = new BuchVereinfacht(310, "J.K. Rowling", "Harry Potter and the Prisoner of Azkaban", "Fantasie", "2.", "872239183934857", 20.10m, "1997", "Es war eine Zeit", new DateOnly());
            buecher[2] = new BuchVereinfacht(333, "Dan Abnett", "Fall of the Imperium", "Sci-Fi, Fantasie", "1.", "387285923934857", 25.99m, "1998", "In the far future...", new DateOnly());
            return buecher;
        }


        //=======================================================================================================
        //Unit-Tests

        [Test]
        public void KundeDetails_StandardKunde_ReturnsDetails()
        {
            //Arrange
            var kunde = StandardBibKunde_Erzeugen();
            //Act
            var result = kunde.KundeDetails();
            //Assert
            Assert.That(result, Is.EqualTo("Vorname: Nicolas, Nachname: Arevalo, Alter: 30, Adresse: Muenchner Strasse 1, Guthaben: 40, Kundennummer: 123456789"));
        }

        [Test]
        public void PasswortAendern_StandardKunde_ReturnsNewPasswort()
        {
            //Arrange
            var kunde = StandardBibKunde_Erzeugen();
            //Act
            kunde.PasswortAendern("0102");
            var result = kunde.Passwort;
            //Assert
            Assert.That(result, Is.EqualTo("0102"));
        }

        //=======================================================================================================
        //Integration-Tests

        [Test]
        public void BuchAusleihen_StandardKundeBuch0_ReturnsTrue()
        {
            var kunde = StandardBibKunde_Erzeugen();
            var buch = StandardBuecher_Erzeugen()[0];

            var result = kunde.BuchAusleihen(buch);

            Assert.That(result, Is.True);
        }

        [Test]
        public void BuchZurueckgeben_StandardKundeBuch1_ReturnsTrue()
        {
            var kunde = StandardBibKunde_Erzeugen();
            var buch = StandardBuecher_Erzeugen()[1];

            kunde.BuchAusleihen(buch);
            var result = kunde.BuchZurueckgeben(buch);

            Assert.That(result, Is.True);
        }

    }
}
