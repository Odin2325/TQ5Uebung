namespace ProgrammierenLernen
{
    internal class Program
    {

        static void Main(string[] args)
        {

        }

        internal static void SummeZufallsZahlen()
        {
            Random zufallszahlGenerator = new Random();

            Program.Summe(zufallszahlGenerator.Next(1, 301), zufallszahlGenerator.Next(1, 301), zufallszahlGenerator.Next(1, 301));
        }

        internal static void Summe(int a, int b, int c)
        {
            Console.WriteLine($"Die Summe von {a} + {b} + {c} ist: {a+b+c}");
        }

        internal static void Begruessung(string name)
        {
            Console.WriteLine($"Wilkommen im Kurs {name}!");
            Program.Summe(10,25,20);
        }


    }
}
