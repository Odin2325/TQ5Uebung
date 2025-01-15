using SpielZauberKrieger;

namespace TestZauberKrieger
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_ToString_ReturnValue()
        {
            // Arrange
            var warrior = new Warrior();

            // Act

            Console.WriteLine("test");
            // Assert
            //Assert.AreEqual("Charakter ist ein Krieger", warrior.ToString());
            Assert.That(warrior.ToString(), Is.EqualTo("Charakter ist ein Krieger"));


        }
 

    }
}