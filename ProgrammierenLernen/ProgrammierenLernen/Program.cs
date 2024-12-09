namespace ProgrammierenLernen
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //datentyp variableName = wert;
            //datentyp variableName;
            string name;
            Console.WriteLine("Geben Sie bitte Ihr name ein: ");
            name = Console.ReadLine();
            Console.WriteLine("Geben Sie Ihr alter ein: ");
            //int alter = Convert.ToInt32(Console.ReadLine());
            //int.TryParse(Console.ReadLine(),out int alter);

            double zahlMitKommaStelle = 90.5;
            int ganzeZahl = (int)zahlMitKommaStelle;

            SummeZufallsZahlen();


        }

        internal static void SummeZufallsZahlen()
        {
            Random zufallszahlGenerator = new Random();

            Program.Summe(zufallszahlGenerator.Next(1, 301), zufallszahlGenerator.Next(1, 301), zufallszahlGenerator.Next(1, 301));
        }

        internal static void Summe(int a, int b, double c)
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
