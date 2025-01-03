using ProgrammierenLernen;

namespace TestProject2
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var utils = new Utils();

            var result = utils.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

    }
}