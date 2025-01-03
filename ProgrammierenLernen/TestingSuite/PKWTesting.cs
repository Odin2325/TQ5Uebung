using ProgrammierenLernen;


namespace TestingSuite
{
    public class PKWTesting
    {
        PKW pkw;

        [SetUp]
        public void Setup()
        {
            pkw = new PKW("Maseratti","Quatro Porte",2002,"V8");
        }

        [Test]
        public void NeuesAutoParken_Test()
        {
            var resultat = pkw.Parken();

            Assert.That(resultat, Is.EqualTo(true));
        }

        [Test]
        public void NeuesAutoFaehrtParken_Test()
        {
            pkw.ManageMotor();

            pkw.SchnellerFahren(200);

            var resultat = pkw.Parken();

            Assert.That(resultat, Is.EqualTo(true));
        }

        [Test]
        public void NeuesAutoMotorAnParken_Test()
        {
            pkw.ManageMotor();

            var resultat = pkw.Parken();

            pkw.ManageMotor();

            Assert.That(resultat, Is.EqualTo(true));
        }

        [Test]
        public void NeuesAutoMotorImmernochAnParken_Test()
        {
            var resultat = pkw.Parken();

            Assert.That(resultat, Is.EqualTo(true));
        }
    }
}