using ProgrammierenLernen;

namespace TestingSuite
{
    internal class BuchTesting
    {
        public BuchVereinfacht StandardBuch_ZumTesten()
        {
            return new BuchVereinfacht(100, "Max Musterman", "Mustermans Adventures", "Sci-Fi", "1.", "387239183934857", 0.2m, "1990", "Dies ist mein Leben.", new DateOnly());
        }

        [Test]
        public void InhalteLesen_StandardBuch_ReturnsInhalte()
        {
            //Arrange
            var buch = StandardBuch_ZumTesten();

            //Act
            var result = buch.InhalteLesen;

            //Assert
            Assert.That(result, Is.EqualTo("Dies ist mein Leben."));
        }

        [Test]
        public void BuchDetailsAnzeigen_StandardBuch_ReturnsDetails()
        {
            //Arrange
            var buch = StandardBuch_ZumTesten();
            //Act
            var result = buch.BuchDetailsAnzeigen();
            //Assert
            Assert.That(result, Is.EqualTo("Autor: Max Musterman, Titel: Mustermans Adventures, Genre: Sci-Fi, Auflage: 1., ISBN: 387239183934857, Preis: 14,99, Erscheinungsjahr: 1990"));
        }



    }
}
