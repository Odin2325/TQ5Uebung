using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{
    internal class Minis
    {
        /*
      Console.WriteLine(ListStatistics(werte));
      Console.WriteLine(RnaSequenz("AUGUUUUCUUAAAUG"));
      Console.WriteLine(RnaSequenz("AUGU"));
      Console.WriteLine(RnaSequenz("BUGUUUUCUUAAAUG"));
      openWith("something/myfile.txt");

      Dictionary<string, int> lagerPaletten = new Dictionary<string, int>();
      lagerPaletten.Add("Kaffee", 13);
      lagerPaletten.Add("Kekse", 5);
      lagerPaletten.Add("Käse", 7);

      foreach (var keyValuePair in lagerPaletten)
      Console.WriteLine($"Key: {keyValuePair.Key} - Value: {keyValuePair.Value}.");
      Einkaufsliste().ForEach(Console.WriteLine);
      PrintArray(["My", "Bob", "is", "Bob"]);
        */

        private static string CheckEingabe()
        {
            string eingabe = "";
            bool validerInput = false;
            do
            {
                Console.WriteLine("Eingabe wiederholen:");
                eingabe = Console.ReadLine();
                if (eingabe != null && eingabe != "")
                    validerInput = true;
            } while (!validerInput);
            return eingabe;
        }

        public static (double schnitt, double summe, double min, double max, double count) ListStatistics(List<double> zahlen)
        {
            return (zahlen.Average(), zahlen.Sum(), zahlen.Min(), zahlen.Max(), zahlen.Count());
        }

        static string RnaSequenz(string sequenz)
        {
            string protein = "Protein:";
            if (sequenz.Length % 3 != 0 || sequenz == null || sequenz == "")
                return "Ungültige Eingabe.";
            for (int i = 0; i < sequenz.Length; i += 3)
            {
                if (protein.EndsWith("STOP"))
                    break;
                string codon = sequenz.Substring(i, 3);
                switch (codon)
                {
                    case "AUG":
                        protein += " Methionin";
                        break;
                    case "UUU":
                    case "UUC":
                        protein += " Phenylalalalalalin";
                        break;
                    case "UUA":
                    case "UUG":
                        protein += " Leucin";
                        break;
                    case "UCU":
                    case "UCC":
                    case "UCA":
                    case "UCG":
                        protein += " Serin";
                        break;
                    case "UAU":
                    case "UAC":
                        protein += " Tyrosin";
                        break;
                    case "UGU":
                    case "UGC":
                        protein += " Cystein";
                        break;
                    case "UGG":
                        protein += " Tryptophan";
                        break;
                    case "UAA":
                    case "UAG":
                    case "UGA":
                        protein += " STOP";
                        break;
                    default:
                        return "Fehlerhafte Sequenz.";
                }
            }
            return protein;
        }
        static void Schaltjahr(int jahr)
        {
            bool Schaltjahr = true;
            if (jahr % 4 == 0)
            {
                if (jahr % 100 == 0)
                    Schaltjahr = false;
                if (jahr % 400 == 0)
                    Schaltjahr = true;
            }
            else
                Schaltjahr = false;
            if (Schaltjahr == true)
                Console.WriteLine($"{jahr} ist ein Schaltjahr.");
            else
                Console.WriteLine($"{jahr} ist kein Schaltjahr.");
        }

        static void Planetenalter()
        {
            Console.WriteLine("Wie alt bist du in Sekunden?");
            if (!double.TryParse(Console.ReadLine(), out double sekunden))
                Console.WriteLine("Ungültige Eingabe");
            double erdJahre = sekunden / 31557600;
            Console.WriteLine("Merkur: " + Math.Round(erdJahre / 0.2408467, 2) + "Jahre.");
            Console.WriteLine("Venus: " + Math.Round(erdJahre / 0.61519726, 2) + "Jahre.");
            Console.WriteLine("ERde: " + Math.Round(erdJahre) + "Jahre.");
            Console.WriteLine("Mars: " + Math.Round(erdJahre / 1.8808158, 2) + "Jahre.");
            Console.WriteLine("Jupiter: " + Math.Round(erdJahre / 11.862615, 2) + "Jahre.");
            Console.WriteLine("Saturn: " + Math.Round(erdJahre / 29.447498, 2) + "Jahre.");
            Console.WriteLine("Uranus: " + Math.Round(erdJahre / 84.016846, 2) + "Jahre.");
            Console.WriteLine("Neptun: " + Math.Round(erdJahre / 164.79132, 2) + "Jahre.");
        }

        static void Rain()
        {
            for (int i = 0; i < 101; i++)
            {
                string addendum = "";
                if (i % 3 == 0)
                    addendum += "Pling";
                if (i % 5 == 0)
                    addendum += "Plang";
                if (i % 7 == 0)
                    addendum += "Plong";
                if (addendum.Length > 0 && i != 0)
                    Console.WriteLine(i + " - " + addendum);
                else
                    Console.WriteLine(i);

            }
        }
        static void Verteilung()
        {
            Console.WriteLine("Enter your name:");
            string? name = Console.ReadLine();
            if (name == null || name == "")
                Console.WriteLine("One for you and one for me.");
            else
                Console.WriteLine($"One for {name} and one for me.");
        }
        static void Einkaufen(decimal budget)
        {
            Dictionary<string, decimal> produkte = new Dictionary<string, decimal>
            {
                { "Laptop"         , 1200m },
                { "Handy"          ,  800m},
                { "Kaffeemaschine" ,  400m },
                { "Waschmaschine"  ,  700m },
                { "Drucker"        ,  140m },
                { "Fernseher"      ,  340m },
            };
            List<string> gekaufteProdukte = new List<string>();
            decimal betrag = 0;
            Console.WriteLine("Willkommen im Techmarkt!");
            Console.WriteLine("Was möchten Sie kaufen?\n1. Laptop - 1200\n2. Smartphone - 800\n3. Kaffeemaschine - 400\n4. Waschmaschine - 999\n 5. Beenden");
            string input;
            bool abbrechen = false;
            while (!abbrechen)
            {
                if (betrag + MinDict(produkte) > budget)
                {
                    Console.WriteLine("Betrag unzureichen.");
                    break;
                }
                input = Console.ReadLine();
                if (input == null || input == "")
                    continue;
            }
        }
        public static decimal MinDict(Dictionary<string, decimal> produkte)
        {
            decimal min = decimal.MaxValue;
            foreach (var kvp in produkte)
            {
                if (kvp.Value < min)
                    min = kvp.Value;
            }
            return min;
        }

        static void openWith(string path)
        {
            Dictionary<string, string> compatibleApps = new Dictionary<string, string>
            {
                {"txt", "Notepad" },
                {"pdf", "PDF Reader"},
                {"cs", "Visual Studio"},
                {"html", "Firefox" }
            };
            if (path == "" || path == null || !path.Contains("."))
                Console.WriteLine("Invalid input.");
            else
            {
                var (filename, filepath) = separatePath(path);
                if (!compatibleApps.ContainsKey(filepath))
                    Console.WriteLine("No valid App found.");
                else
                    Console.WriteLine($"You can open {filename} with {compatibleApps[filepath]} because it is a {filepath} file.");
            }
        }

        static (string, string) separatePath(string path)
        {
            string filepath = Path.GetExtension(path).Trim('.');
            string filename = path.Split('/').Last().Split('.')[0];
            return (filename, filepath);
        }
        static string Pangram(string input)
        {

            return String.Join(" ", input.Split(" ").Select(x => new String(x.Reverse().ToArray())));
        }
        static List<string> Einkaufsliste()
        {
            List<string> einkaufsListe = new List<string>();
            while (true)
            {
                Console.WriteLine("Füge der Einkaufsliste etwas hinzu. 'Fertig' zum beenden.");
                string item = Console.ReadLine();
                if (item.ToLower() == "fertig")
                    break;
                else if (item == "" || item == null)
                {
                    Console.WriteLine("Eingabe ungültig.");
                    continue;
                }
                else
                    einkaufsListe.Add(item);
            }
            return einkaufsListe;
        }

        static int FindIndex(double[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void PrintArray(string[] wordList)
        {
            string output = "{";
            for (int i = 0; i < wordList.Length; i++)
            {
                if (i < wordList.Length - 1)
                {
                    output += wordList[i] + ", ";
                }
                else
                {
                    output += wordList[i] + "}";
                }
            }
            Console.WriteLine(output);
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
