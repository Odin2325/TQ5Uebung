using cLernen;

namespace cLernenTest
{
    public class Tests
    {
        Roomba bobby;
        Polizeiroboter sonny;

        [SetUp]
        public void Setup()
        {
            bobby = new Roomba();
            sonny = new Polizeiroboter();
            sonny.PowerButton();
        }

        [Test]
        public void RoboterKannArbeiten_Test()
        {
            var resultat = bobby.KannArbeiten();
            Assert.That(resultat, Is.EqualTo(false));
            bobby.PowerButton();
            bobby.Laden();
            var resultat2 = bobby.KannArbeiten();
            Assert.That(resultat2, Is.EqualTo(true));
        }
        [Test]
        public void Seriennummer_Test()
        {
            Assert.That(bobby.seriennummer.Length, Is.EqualTo(11));
            Assert.That(sonny.seriennummer.Length, Is.EqualTo(11));
        }

        [Test]
        public void Laden_Test()
        {
            sonny.Laden();
            Assert.That(sonny.Ladekapazität, Is.EqualTo(100));
        }
        /*[TearDown]
        public void TearDown()
        -> bei Benutzung von Internetverbindung/Datenbank etc.
        */
    }
}