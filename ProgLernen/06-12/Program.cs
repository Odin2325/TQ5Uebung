namespace _06_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int aktuelleAufgaben = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;
            int sophiasumme = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            double sophiad = sophiasumme / aktuelleAufgaben;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;
            int nicolassumme = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            double nicolasd = nicolassumme / aktuelleAufgaben;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;
            int zahirahsumme = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            double zahirahd = zahirahsumme / aktuelleAufgaben;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;
            int jeongsumme = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
            double jeongd = jeongsumme / aktuelleAufgaben;

            Program.Begruessung("Test");

            Console.WriteLine("Summe Noten \n");
            Console.WriteLine($"Sophia: \t { sophiad } \t");
            Console.WriteLine($"Nicolas: \t {nicolasd} \t");
            Console.WriteLine($"Zahriah: \t {zahirahd} \t");
            Console.WriteLine($"Jeong: \t\t {jeongd} \t");
            Program.Summe(3, 4, 5);
        }
        static void Begruessung(string name)
        {
            Console.WriteLine($"Willkommen im Kurs {name}");
        }
        static void Summe(int a, int b, int c) 
        {
            Console.WriteLine($"Die Summe ist: {a+b+c}");
        }
    }
}
