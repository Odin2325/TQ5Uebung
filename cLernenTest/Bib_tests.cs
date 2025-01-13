using cLernen;
namespace cLernenTest;

internal class Bib_tests
{
    Bibliothek uniBib = new Bibliothek("Unibibliothek", "Hollywood 1-3");
    Buch dogTraining = new Buch(375, "Cesar Millan", "Be the Pack Leader", "Bildung", "87664533578", "2007", new DateTime(2025, 1, 1));
    Buch fevreDream = new Buch(450, "George R. R. Martin", "Fevre Dream", "Fantasy", "576907857", "1982", new DateTime(2023, 01, 01));
    public void Bib_BücherHinzufügen()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
