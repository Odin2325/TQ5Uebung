using System.ComponentModel.Design;
using System.Data;

namespace cLernen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zahlenvergleich();
            Console.WriteLine("\n-~-~-~-~-~-~-~-~-~-\n");
            Wetter();
            Console.WriteLine("\n-~-~-~-~-~-~-~-~-~-\n");
            Console.WriteLine(Wochentag());
            Console.WriteLine("\n-~-~-~-~-~-~-~-~-~-\n");
            Primzahl(11);
            Console.WriteLine("\n-~-~-~-~-~-~-~-~-~-\n");
            Eintritt();
            //Währungsrechner();
            // WuerfelFuenfzehnSpiel();
            // VerifyUser();
            //Shout();
            //TemperatureConverter();
            // CubeCalculations();
            // InterestCalculation();
            // SummeZufallsGenerator();
            Console.ReadKey();
        }

        static void Zahlenvergleich()
        {
            Console.WriteLine("Gib eine Zahl zwischen 1 und 10 ein:");
            int zahl = Convert.ToInt16(Console.ReadLine());
            if (0 <= zahl && zahl <= 5)
            {
                Console.WriteLine($"Die Zahl {zahl} ist kleiner oder gleich 5.");
            }
            else if (zahl > 5 && zahl < 10)
            {
                Console.WriteLine($"Die Zahl {zahl} ist größer als 5.");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!");
            }
        }

        static void Wetter()
        {
            Console.WriteLine("Wie viel Grad in Celsius sind es?");
            double temperatur = Convert.ToDouble(Console.ReadLine());
            if (temperatur < 15.0)
            {
                Console.WriteLine("Saukalt draußen, bleib drin.");

            }
            else if (temperatur <= 30.0)
            {
                Console.WriteLine("Bissl frisch.");
            }
            else
            {
                Console.WriteLine("Schön warm draußen!");
            }
        }

        static string Wochentag()
        {
            Console.WriteLine("Gib den Wochentag als Zahl ein (Montag = 1, Sonntag = 7):");
            string? tagNummer = Console.ReadLine();
            string wochentag = tagNummer switch
            {
                "1" => "Montag",
                "2" => "Dienstag",
                "3" => "Mittwoch",
                "4" => "Donnerstag",
                "5" => "Freitag",
                "6" => "Samstag",
                "7" => "Sonntag",
                _ => "Ungültige Eingabe!"
            };
            return wochentag;
        }
        static void Primzahl(int zahl)
        {
               if (zahl < 10)

            {
                switch (zahl)
                {
                    case 2:
                        Console.WriteLine("Primzahl");
                        break;
                    case 3:
                        Console.WriteLine("Primzahl");
                        break;
                    case 5:
                        Console.WriteLine("Primzahl");
                        break;
                    case 7:
                        Console.WriteLine("Primzahl");
                        break;
                    default:
                        Console.WriteLine("Keine Primzahl");
                        break;
                }
            }
               else
            {
                Console.WriteLine($"Zahl {zahl} zu groß für Überprüfung.");
            }
        }
        
        static void Eintritt()
        {
            string message;
            string tagtyp;
            Console.WriteLine("Gib dein Alter ein:");
            int alter = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Gib den Wochentag als Zahl ein (Montag = 1, Sonntag = 7):");
            int tagNummer = Convert.ToInt16(Console.ReadLine());
            switch (tagNummer)
            {
                case <= 5:
                    tagtyp = "Werktag";
                    break;
                case > 5:
                    tagtyp = "Wochenende";
                    break;
            }
            if (alter < 18)
            {
                message = "Ermäßigter Eintritt";
            }
            else
            {
                message = "Normaler Eintritt";
            }
            Console.WriteLine($"{message} - {tagtyp}.");
        }
        static void Währungsrechner()
        {
            Console.WriteLine("Gib einen Betrag in Euro ein:");
            decimal betrag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Wähle eine Währung, in die der Eurobetrag gewechselt werden soll: YEN, INR, GBP, USD.");
            string währung = Console.ReadLine().ToUpper();
            decimal wechselkurs = währung switch
            {
                "YEN" => betrag * 159.14558m,
                "INR" => betrag * 89.655121m,
                "GBP" => betrag * 0.82812935m,
                "USD" => betrag * 1.0581981m,
                _ => -1
            };
            Console.WriteLine($"{betrag} Euro sind {wechselkurs:F2} {währung}");
        }

        internal static void WuerfelFuenfzehnSpiel()
        {
            Random wuerfelWurfGenerator = new Random();

            int bonusPunkte = 0;
            Console.WriteLine("Spiel Start");
            Console.WriteLine("=========================================");
            Console.WriteLine("Werfen Sie Ihr erstes wuerfel!");
            Console.ReadKey();
            int wurf1 = wuerfelWurfGenerator.Next(1, 7);
            Console.WriteLine("Resultat: " + wurf1);
            Console.WriteLine("Werfen Sie Ihr zweites wuerfel!");
            Console.ReadKey();
            int wurf2 = wuerfelWurfGenerator.Next(1, 7);
            Console.WriteLine("Resultat: " + wurf2);
            Console.WriteLine("Werfen Sie Ihr drittes wuerfel!");
            Console.ReadKey();
            int wurf3 = wuerfelWurfGenerator.Next(1, 7);
            Console.WriteLine("Resultat: " + wurf3);
            int summe = wurf1 + wurf2 + wurf3;
            Console.WriteLine("\n");

            Console.WriteLine($"Wurf: {wurf1} + {wurf2} + {wurf3} = {summe}.");
            //Console.WriteLine("Wurf: " + wurf1 + " + " + wurf2 + " + " + wurf3 + " = " + summe + ".");
            if (wurf1 == wurf2 && wurf1 == wurf3)
            {
                bonusPunkte += 6;
                Console.WriteLine("Dreierpasch!");
            }
            else if (wurf1 == wurf2 || wurf1 == wurf3 || wurf2 == wurf3)
            {
                bonusPunkte += 2;
                Console.WriteLine("Zweierpasch!");
            }
            Console.WriteLine("Erhaltene Bonuspunkte: " + bonusPunkte);
            Console.WriteLine("\nGesamt punktzahl: " + (summe + bonusPunkte) + "\n");
            if (summe + bonusPunkte == 7)
            {
                Console.WriteLine("Sie haben einen 7 Euro Gutschein gewonnen!");
            }
            else if (summe + bonusPunkte >= 16)
            { 
                Console.WriteLine("Sie haben einen 50 Euro Gutschein gewonnen!");
            }
            else if (summe + bonusPunkte >= 10)
            {
                Console.WriteLine("Sie haben einen 25 Euro Gutschein gewonnen!");
            }
            else
            {
                Console.WriteLine("Hier ist ein Katzenvideo für dich");
            }
            Console.WriteLine("=========================================");
            Console.WriteLine("Spiel Vorbei.");
        }


        static void VerifyUser()
        {
            string correctUsername = "admin1";
            string correctPassword = "pass123";
            Console.WriteLine("Enter your username:");
            string? userInput = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string? passwordInput = Console.ReadLine();

            if (userInput == correctUsername && passwordInput == correctPassword)
                    {
                Console.WriteLine("Login succesful!");
            }
            else if (userInput != correctUsername && passwordInput != correctPassword)
            {
                Console.WriteLine("No Access!");
            }
            else
            {
                Console.WriteLine("One value was incorrect.");
            }

        }
        static void Shout()
        {
            Console.WriteLine("Enter a string: ");
            string convert = Console.ReadLine();
            Console.WriteLine(convert.ToUpper());

        }
        static void SummeZufallsGenerator()
        {
            Random ZufallsGenerator = new Random();
            int zahl1 = ZufallsGenerator.Next(1, 301);
            int zahl2 = ZufallsGenerator.Next(1, 301);
            int zahl3 = ZufallsGenerator.Next(1, 301);
            Console.WriteLine(zahl1 + zahl2 + zahl3);

        }

        static void TemperatureConverter()
        {
            Console.WriteLine("Enter a temperature in Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"{celsius} Celsius is {fahrenheit} in Fahrenheit.");
        }

        static void CubeCalculations()
        {
            int height = 6;
            int radius = 3;
            double pi = 3.1415;
            double curved_surface = 2 * pi * height * radius;
            double surface = 2 * pi * radius * (radius + height);
            double volume = pi * radius * 2 * height;
            Console.WriteLine($"A cylinder of height {height} and radius {radius} has:\nA curved surface area of {curved_surface:F2}, a surface of {surface:F2} and a volume of {volume:F2}.\n");
        }
            
        static void InterestCalculation()
        {
            Console.WriteLine("Enter a initial investment sum:");
            double investment = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the duration of investment in years:");
            int years = Convert.ToInt32(Console.ReadLine());
            double interestRate = 0.04;
            double output = investment * (Math.Pow((1 + interestRate / 1), years));
            Console.WriteLine($"Total amount after {years} years: {output:F2}.");
        }

           }
}
