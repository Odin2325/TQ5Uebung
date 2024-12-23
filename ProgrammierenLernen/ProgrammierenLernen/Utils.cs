using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenLernen
{
    public class Utils
    {
        /// <summary>
        /// Erzeugt eine schoene ausgabe anhand von die StudentenInfos Tupeln.
        /// </summary>
        public static void StudentAusgabe()
        {
            List<(string Name, int Alter, double DurchschnittsNote)> StudentenInfos = StudentenInformationen();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Name\t\t| Age\t| Grade");
            Console.WriteLine("--------------------------------");
            foreach (var student in StudentenInfos)
            {
                Console.WriteLine($"{student.Name}\t| {student.Alter}\t| {Math.Round(student.DurchschnittsNote, 1)}");
            }
        }
        /// <summary>
        /// Methode um Studentent Tupeln zu erstellen und als Liste zurueckzugeben.
        /// 
        /// </summary>
        /// <returns>(string Name, int Alter, double DurchschnittsNote)</returns>
        private static List<(string Name, int Alter, double DurchschnittsNote)> StudentenInformationen()
        {
            List<(string Name, int Alter, double DurchschnittsNote)> studentenListe = new List<(string Name, int Alter, double DurchschnittsNote)>();

            int zaehler = 1;
            string name;
            int alter;
            double note;

            while (true)
            {
                Console.WriteLine($"Geben Sie die details von Student {zaehler} ein:");

                name = StudententNameOrWert("Name");
                alter = StudententAlter();
                note = StudententNote();

                studentenListe.Add((name, alter, note));
                Console.Clear();
                if (StudententNameOrWert("Weiter") == "n")
                {
                    break;
                }

                zaehler++;
            }
            return studentenListe;
        }

        private static int StudententAlter()
        {
            int alter;
            bool validerInput = false;

            do
            {
                Console.Write("Alter: ");
                int.TryParse(Console.ReadLine(), out alter);

                if (alter > 6 && alter <= 20)
                {
                    validerInput = true;
                }
            } while (!validerInput);
            return alter;
        }

        private static double StudententNote()
        {
            double note = 0;
            bool validerInput = false;

            do
            {
                try
                {
                    Console.Write("Note: ");
                    note = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Nicht valide Note. Bitte nur zahlen eingeben.");
                    continue;
                }

                if (note <= 100 && note >= 0)
                {
                    validerInput = true;
                }
                else
                {
                    Console.WriteLine("Zahl muss im Bereich zwischen 0 und 100 sein.");
                }
            } while (!validerInput);
            return note;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ausgabe"></param>
        /// <returns></returns>
        private static string StudententNameOrWert(string ausgabe)
        {
            string eingabe = "";
            bool validerInput = false;

            do
            {
                if (ausgabe == "Name")
                {
                    Console.Write("Name: ");
                    eingabe = Console.ReadLine();
                }
                else if (ausgabe == "Weiter")
                {
                    Console.WriteLine("Moechten Sie noch einen Student im System speichern? y oder n eingeben bitte.");
                    eingabe = Console.ReadLine();
                    if (eingabe == "y" || eingabe == "n")
                    {
                        return eingabe;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (eingabe != null && eingabe != "")
                {
                    validerInput = true;
                }
            } while (!validerInput);
            return eingabe;
        }

        public static (double Durchschnitt, double Summe, double Min, double Max, int Count) ListStatistics(List<double> zahlen)
        {
            return (zahlen.Average(), zahlen.Sum(), zahlen.Min(), zahlen.Max(), zahlen.Count);
        }

        /*
         * Wir moechten eine Methode schreibe die heisst ListStatistics(List<double> zahlen).
         * Diese methode sollte einen Tupel zurueckgeben mit die folgenden informationen.
         * 
         * 1. Durchschnitt
         * 2. Summe
         * 3. Min
         * 4. Max
         * 5. Anzahl Werte
         * 
         * Dies heisst, der rueckgabetyp sollte einen Tupel sein. 
         * Dieser Tupel soll Benannte Tupel variablen verwenden.
         * 
         * Am besten selber methoden schreiben um alle Werte zu bekommen. 
         * 4 helfermethoden + unsere ListStatistics Methode
         * 
         * Beispiel von die Folien:
         * public static (string Name, int Alter) GetPerson(){}
         */



        /*
         * Wir muessen dir Formel berechnen:
         * n! / (r!*((n-r)!))
         * 
         * Eine for schleife um die Zahl n zu berechnen (aktueller zeilen nummer)
         * Innere for schleife um die Zahl r zu berechnen (aktuelle spalten)
         */
        /// <summary>
        /// Creates a pyramid representing the values in Pascals Triangle.
        /// </summary>
        /// <param name="hoehe"></param>
        public static void PascalTriangle(int hoehe)
        {
            for (int n = 0; n <= hoehe; n++)
            {
                Console.Write(new string(' ', (int)hoehe - n));
                for (int r = 0; r <= n; r++)
                {
                    Console.Write(NcR(n, r) + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Calculates n choose r.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static BigInteger NcR(BigInteger n, BigInteger r)
        {
            return Faktoriell(n) / (Faktoriell(r) * Faktoriell(n - r));
        }



        public static void NANP(string telephoneNummer)
        {
            //Sonderzeichen Loeschen-Entfernen
            char[] einzelZeichen = telephoneNummer.ToCharArray();
            string resultat = "";

            foreach (char zeichen in einzelZeichen)
            {
                if (zeichen >= '0' && zeichen <= '9')
                {
                    resultat += zeichen;
                }
            }

            if (resultat.Length > 10)
            {
                //4912345678910
                //49816112345 6
                //Laenge 11
                //11-10 = 1 Index

                //Substring(1) wenn nur NANP telephonenummern.
                //Unsere variante, alle telephonnummern egal welche laendervorwahlzahl
                //Wir gehen davon aus alle zahlen haben 10 zeichen.
                resultat = resultat.Substring(resultat.Length - 10);
            }

            Console.WriteLine("Telephonenummer: " + resultat);
        }

        //gerade => n/2
        //ungerade => 3n + 1
        //Bis die Zahl 1
        public static (int, int) Collatz(int n, int schritte = 0)
        {
            if (n <= 0)
            {
                Console.WriteLine("Ungueltige Eingabe.");
                return (-1, -1);
            }

            if (n == 1)
            {
                return (n, schritte);
            }

            Console.WriteLine($"{schritte + 1}. {n}");
            if (n % 2 == 0)
            {
                //n /= 2;
                return Collatz(n / 2, schritte++);
            }
            else
            {
                return Collatz(3 * n + 1, schritte++);
            }

        }


        //RNA => Codons (laenge 3) => Proteinen (wir haben eine Tabelle)
        //Moeglich mit Substring 3 Zeichen zu bekommen.
        public static List<string> RnaUebersetzung(string rnaSequenz)
        {
            var proteinen = new List<string>();

            for (int i = 0; i < rnaSequenz.Length; i += 3)
            {
                if (i > rnaSequenz.Length - 3)
                {
                    Console.WriteLine("Zeichenketten nicht durch 3 Teilbar.");
                    Console.WriteLine($"Nur bis zu index {i} gelaufen.");
                    break;
                }
                string codon = rnaSequenz.Substring(i, 3);

                string proteine = codon switch
                {
                    "AUG" => "Methionin",
                    "UUU" or "UUC" => "Phenylalanin",
                    "UUA" or "UUG" => "Leucin",
                    "UCU" or "UCC" or "UCA" or "UCG" => "Serin",
                    "UAU" or "UAC" => "Tyrosin",
                    "UGU" or "UGC" => "Cystein",
                    "UGG" => "Tryptophan",
                    "UAA" or "UAG" or "UGA" => "STOP",
                    _ => ""
                };

                if (proteine == "STOP")
                {
                    break;
                }
                if (proteine == "")
                {
                    Console.WriteLine("Ungueltige eingabe erreicht: " + codon);
                    break;
                }
                proteinen.Add(proteine);
            }
            return proteinen;
        }

        static void Schaltjahr()
        {
            Console.WriteLine("bitte gib eine Jahreszahl ein");
            int Jahr = int.Parse(Console.ReadLine());
            if (Jahr >= 0)
            {
                Console.WriteLine("gültige Jahreszahl");
                if ((Jahr % 4 == 0 && Jahr % 100 != 0) || (Jahr % 400 == 0))
                {
                    Console.WriteLine("ihre Jahreszahl entspricht einem Schaltjahr");
                }
                else
                {
                    Console.WriteLine("ihre Jahreszahl entspricht nicht einem Schaltjahr");
                }
            }
            else
            {
                Console.WriteLine("ungültige Eingabe!");
            }
        }

        public bool BerechneSchaltjahr(int jahr)
        {
            if (jahr % 4 == 0)
            {
                if (jahr % 100 == 0)
                {
                    return jahr % 400 == 0;
                }
                return true;
            }
            return false;
        }

        public static void PlanetenAlter()
        {
            Console.WriteLine("Wie alt bist du in Sekunden?");
            if (!double.TryParse(Console.ReadLine(), out double sekunden))
            {
                Console.WriteLine("Ungueltige eingabe.");
            }

            double erdJahren = sekunden / 31557600;

            Console.WriteLine("Merkur: " + Math.Round(erdJahren / 0.2408467));
            Console.WriteLine("Venus: " + erdJahren / 0.61519726);
            Console.WriteLine("Erde: " + erdJahren);
            Console.WriteLine("Mars: " + erdJahren / 1.8808158);
            Console.WriteLine("Jupiter: " + erdJahren / 11.862615);
            Console.WriteLine("Saturn: " + erdJahren / 29.447498);
            Console.WriteLine("Uranus: " + erdJahren / 84.016846);
            Console.WriteLine("Neptun: " + erdJahren / 164.79132);
        }

        public static void RegentropfenFaktoren(int obereGrenze)
        {
            Console.WriteLine("Regentropfen Start");
            for (int i = 0; i < obereGrenze; i++)
            {
                string resultat = "";
                if (i % 3 == 0)
                {
                    resultat += "Pling";
                }
                if (i % 5 == 0)
                {
                    resultat += "Plang";
                }
                if (i % 7 == 0)
                {
                    resultat += "Plong";
                }

                if (resultat.Length > 0 && i != 0)
                {
                    Console.WriteLine($"{i} - {resultat}");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }





        public static void EinsDichMich()
        {
            Console.WriteLine("Geben Sie bitte Ihr name ein: ");
            string name = Console.ReadLine();
            if (name == null || name == "")
            {
                Console.WriteLine("Eins fuer dich, und eins fuer mich.");
            }
            else
            {
                Console.WriteLine($"Eins fuer {name}, und eins fuer mich.");
            }
        }

        public static void TechEinkaufen(decimal budget)
        {
            Dictionary<string, int> warenkorb = new Dictionary<string, int>();
            decimal betrag = 0;
            string? eingabe = "";
            bool willAbrechen = false;
            Dictionary<string, decimal> produkte = new Dictionary<string, decimal>
            {
                {"Laptop", 1200},
                {"Handy", 800},
                {"Drucker", 140},
                {"Fernseher", 340},
                {"Kaffeemaschine", 400},
                {"Waschmaschine",700},
            };

            Console.WriteLine("Wilkommen in MediaMarkt: ");
            Console.WriteLine("Was moechten Sie heute kaufen?");
            Console.WriteLine("Druecken Sie bitte die dazugehoerige Zahl um ein Produkt in Ihr Warenkorb hinzuzufuegen.");

            while (!willAbrechen)
            {
                Console.WriteLine("Druecken Sie bitte eine Taste um weiter zu machen.");
                Console.ReadKey();
                Console.Clear();
                if (betrag + MinDictionary(produkte) > budget)
                {
                    Console.WriteLine("Sie koennen keine weitere Produkte kaufen.");
                    Console.WriteLine("Ihr Budget ist ausgenutzt, wir schicken Ihnen zum Checkout.");
                    break;
                }
                Console.WriteLine("Ihr budget betraegt: " + (budget - betrag));
                Console.WriteLine("1. Laptop - 1200\r\n2. Handy - 800\r\n3. Kaffeemaschine - 400\r\n4. Waschmaschine - 700\r\n5. Drucker - 140\r\n6. Fernseher - 340\r\n7. Beenden");
                eingabe = Console.ReadLine();
                if (eingabe == null || eingabe == "")
                {
                    continue;
                }
                var ausgewaehlterProdukt = "";
                switch (eingabe)
                {
                    case "1":
                        ausgewaehlterProdukt = "Laptop";
                        break;
                    case "2":
                        ausgewaehlterProdukt = "Handy";
                        break;
                    case "3":
                        ausgewaehlterProdukt = "Kaffeemaschine";
                        break;
                    case "4":
                        ausgewaehlterProdukt = "Waschmaschine";
                        break;
                    case "5":
                        ausgewaehlterProdukt = "Drucker";
                        break;
                    case "6":
                        ausgewaehlterProdukt = "Fernseher";
                        break;
                    case "7":
                        willAbrechen = true;
                        continue;
                    default:
                        Console.WriteLine("Ungueltige Eingabe, bitte nur Zahlen zwischen 1-7 eingeben.");
                        continue;
                }

                if (betrag + produkte[ausgewaehlterProdukt] <= budget)
                {
                    //Wenn ein key nicht vorhanden ist und wir machen eine zuweisung mit schluessel und wert, dann wird es hinzugefuegt.
                    warenkorb[ausgewaehlterProdukt] = warenkorb.GetValueOrDefault(ausgewaehlterProdukt, 0) + 1;
                    betrag += produkte[ausgewaehlterProdukt];
                }
                else
                {
                    Console.WriteLine("Nicht genug geld im Budget.");
                }
            }
            Console.WriteLine("Hier ist Ihre Rechnung: ");
            Console.WriteLine(RechnungErstellenOhneGesamtBetrag(produkte, warenkorb) + "Betrag: " + betrag);
        }

        public static string RechnungErstellenOhneGesamtBetrag(Dictionary<string, decimal> produkte, Dictionary<string, int> warenkorb)
        {
            //laptop, 2
            //Handy x2 - 1600
            string resultat = "";
            foreach (var kvp in warenkorb)
            {
                if (produkte.ContainsKey(kvp.Key))
                {
                    resultat += $"{kvp.Key} x{kvp.Value} - {kvp.Value * produkte[kvp.Key]}\r\n";
                }
            }
            return resultat;
        }

        public static decimal MinDictionary(Dictionary<string, decimal> produkte)
        {
            decimal min = decimal.MaxValue;
            foreach (var paar in produkte)
            {
                if (paar.Value < min)
                {
                    min = paar.Value;
                }
            }
            return min;
        }

        public static void OpenWith(string pfad)
        {
            string dateiName = DateiName(pfad);
            string dateiTyp = DateiTyp(pfad);
            string applicationName = "";

            Dictionary<string, string> openingApplication = new Dictionary<string, string>();
            openingApplication.Add("txt", "C:\\Windows\\system32\\notepad.exe");
            openingApplication.Add("cs", "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe");
            openingApplication.Add("py", "C:\\Users\\MYTQ-Trainer\\AppData\\Local\\Programs\\Microsoft VS Code\\Code.exe");
            openingApplication.Add("html", "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe");

            if (openingApplication.ContainsKey(dateiTyp))
            {
                applicationName = DateiName(openingApplication[dateiTyp]);
                Console.WriteLine($"Sie koennen die Datei {dateiName} mit {applicationName} oeffnen, da es eine {dateiTyp} Datei ist.");
            }
            else
            {
                Console.WriteLine("Unknown File Type.");
                Console.WriteLine("Please download a software to open that kind of file.");
            }
        }


        public static string DateiTyp(string pfad)
        {
            int indexPunkt = pfad.LastIndexOf(".");

            string nachPunkt = pfad.Substring(indexPunkt + 1);

            return nachPunkt;
            //return Path.GetExtension(pfad).Trim('.');
        }

        public static string DateiName(string pfad)
        {
            int indexSchraegstrich = 0;
            if (pfad.Contains("\\"))
            {
                indexSchraegstrich = pfad.LastIndexOf('\\');

            }
            else if (pfad.Contains("/"))
            {
                indexSchraegstrich = pfad.LastIndexOf('/');
            }
            else
            {
                indexSchraegstrich = -1;
            }

            //01234567891011 =>Laenge = 12 - 5 = 7-3 = 4
            //text/name.py
            int laenge = pfad.Length - indexSchraegstrich - DateiTyp(pfad).Length - 2;

            return pfad.Substring(indexSchraegstrich + 1, laenge);
        }


        public static Tuple<List<string>, List<string>> Pangram()
        {
            List<string> originalWords = new List<string>();
            List<string> reversedWords = new List<string>();

            Console.WriteLine("Geben Sie Wörter ein. Geben Sie 'stop' ein, um die Eingabe zu beenden:");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                {
                    break;
                }

                originalWords.Add(input);
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                reversedWords.Add(new string(charArray));
            }

            Console.ResetColor();
            return Tuple.Create(originalWords, reversedWords);
        }

        public static string Pangram(string input, string sep = " ")
        {
            var words = new List<string>();

            foreach (var word in input.Split(sep))
            {
                words.Add(Reverse(word));
            }

            return string.Join(" ", words);
        }

        static string Reverse(string str)
        {
            return string.Concat(str.Reverse());
        }

        /// <summary>
        /// Ein gegebener Satz wird aufgeteilt in einzelne Woerter.
        /// Danach werden diese Woerter umgedreht mit unsere Reverse() methode.
        /// Dann geben wir wieder alle Woerter in einen String zurueck ohne die Reihenfolge zu veraendern.
        /// </summary>
        /// <param name="eingabe">Unser Eingabe Satz</param>
        /// <exception cref="NullPointerException">Moeglicherweise string ist null</exception>
        /// <returns><ref name="eingabe">Eingabe </ref>Soll umgedreht werden.</returns>
        public static string Pangram(string eingabe)
        {
            //Woerter sind in einen string array aufgeteilt.
            string[] aufgeteilterSatz = eingabe.Split(' ');
            //List<string> umgredehtreWoerter = new List<string>();
            string[] resultatWoerter = new string[aufgeteilterSatz.Length];

            //Wert an der stelle 0 = Hallo
            //foreach (string wort in aufgeteilterSatz)
            //{
            //    umgredehtreWoerter.Add(ReverseString(wort));
            //}

            for (int i = 0; i < resultatWoerter.Length; i++)
            {
                resultatWoerter[i] = ReverseString(aufgeteilterSatz[i]);
            }

            return JoinArray(resultatWoerter);
        }

        public static string ReverseString(string wort)
        {
            char[] zeichenWort = wort.ToCharArray();

            Array.Reverse(zeichenWort);

            string resultat = new string(zeichenWort);

            return resultat;
        }

        public static string JoinArray(string[] zeichenFolgen, string seperator = " ")
        {
            string resultat = "";

            for (int i = 0; i < zeichenFolgen.Length; i++)
            {
                if (i == zeichenFolgen.Length - 1)
                {
                    resultat += zeichenFolgen[i];
                }
                else
                {
                    resultat += zeichenFolgen[i] + seperator;
                }
            }

            return resultat;
        }
        public static string JoinArray(int[] zeichenFolgen, string seperator = " ")
        {
            string resultat = "";

            for (int i = 0; i < zeichenFolgen.Length; i++)
            {
                if (i == zeichenFolgen.Length - 1)
                {
                    resultat += zeichenFolgen[i];
                }
                else
                {
                    resultat += zeichenFolgen[i] + seperator;
                }
            }

            return resultat;
        }

        public static string RandomChars(int length, bool includeUpperCase = false)
        {
            var random = new Random();
            List<char> chars = new List<char>(length);

            while (chars.Count() < length)
            {
                if (includeUpperCase)
                {
                    char c = (char)random.Next('A', 'z' + 1);
                    // ...UVWXYZ[\]^_`abcdef...
                    //         ^-skip-^
                    if ('Z' < c && c < 'a') continue;
                    chars.Add(c);
                }
                else
                {
                    chars.Add((char)random.Next('a', 'z' + 1));
                }
            }
            return string.Join("", chars);
        }
        public string GenerateRandomWord(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Die Länge muss größer als 0 sein.");
            }

            Random random = new Random();
            StringBuilder wordBuilder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int charType = random.Next(0, 52);

                char randomChar;
                if (charType < 26)
                {
                    randomChar = (char)(charType + 97);
                }
                else
                {
                    randomChar = (char)(charType - 26 + 65);
                }

                wordBuilder.Append(randomChar);
            }

            return wordBuilder.ToString();
        }

        public static List<string> EinkaufsListeGenerator()
        {
            string eingabe = "";
            List<string> einkaufsListe = new List<string>();
            do
            {
                Console.WriteLine("Geben Sie das naechste Produkt fuer Ihre einkaufsliste: ");
                eingabe = Console.ReadLine();
                if (eingabe == "" || eingabe == null)
                {
                    Console.WriteLine("Ungueltige Eingabe!");
                    continue;
                }

                if (eingabe.ToUpper() == "FERTIG")
                {
                    continue;
                }

                einkaufsListe.Add(eingabe);

            } while (eingabe.ToUpper() != "FERTIG");

            Console.WriteLine("Einkaufsliste Erstellt!");
            return einkaufsListe;
        }

        public static int FindIndex(double[] zahlen, double gesuchteZahl)
        {
            if (zahlen == null || zahlen.Length == 0) Console.WriteLine("");

            for (int i = 0; i < zahlen.Length; i++)
            {
                if (zahlen[i] == gesuchteZahl)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void PrintArray(string[] array)
        {
            Console.WriteLine("{" + JoinArray(array, ", ") + "}");
        }
        public static void PrintArray(int[] array)
        {
            Console.WriteLine("{" + JoinArray(array, ", ") + "}");
        }



        //text sep
        //sep text




        public static decimal Summe(decimal[] zahlen)
        {
            decimal summe = 0;
            for (int i = 0; i < zahlen.Length; i++)
            {
                summe += zahlen[i];
                if (zahlen[i] % 2 == 0)
                {
                    zahlen[i]++;
                }
            }
            //foreach(int zahl in zahlen)
            //{
            //    summe += zahl;
            //    if (zahl % 2 == 0)
            //    {

            //    }
            //}
            return summe;
        }
        public static int Summe(int a, int b)
        {
            return a + b;
        }

        public static int Summe(int[] zahlen)
        {
            int summe = 0;
            for (int i = 0; i < zahlen.Length; i++)
            {
                summe += zahlen[i];
                if (zahlen[i] % 2 == 0)
                {
                    zahlen[i]++;
                }
            }
            //foreach(int zahl in zahlen)
            //{
            //    summe += zahl;
            //    if (zahl % 2 == 0)
            //    {

            //    }
            //}
            return summe;
        }

        public static BigInteger Faktoriell(BigInteger zahl)
        {
            if (zahl == 0)
            {
                return 1;
            }

            return zahl * Faktoriell(zahl - 1);
        }

        public static void RepeatInput()
        {
            Console.WriteLine("Bitte gebe ein Zeichen oder einen Text ein:");
            string input = Console.ReadLine();

            Console.WriteLine("Wie oft soll es wiederholt werden?");
            if (!int.TryParse(Console.ReadLine(), out int height) || height <= 0)
            {
                Console.WriteLine("Bitte gebe eine gültige Zahl größer als 0 ein.");
                return;
            }

            for (int i = 1; i <= height; i++)
            {
                string spaces = new string(' ', (height - i) * 2);

                string layer = string.Join("   ", Enumerable.Repeat(input, i));

                Console.WriteLine(spaces + layer);
            }
        }

        public static void PyramideErstellen(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = n; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static bool PinUeberpruefung(string echtenPin)
        {
            string pinEingabe = "";
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Geben Sie bitte ihr pin ein: ");
                pinEingabe = Console.ReadLine();
                if (pinEingabe == echtenPin)
                {
                    Console.WriteLine("Sie werden eingeloggt.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Uebrige versuche: " + (3 - i));
                }
            }
            Console.WriteLine("Kontaktieren Sie bitte die Filiale um ihr Konto wieder zu aktivieren.");
            return false;
        }


        //public void ValidateInput()
        //{
        //    outputs.NormalOutput("Bitte gebe eine Zahl zwischen 0 und 15 ein.");

        //    int versuche = 0;
        //    int zahl;
        //    bool validate;

        //    while (true)
        //    {
        //        validate = int.TryParse(Console.ReadLine(), out zahl);

        //        if (!validate)
        //        {
        //            outputs.ErrorOutput("Bitte gebe eine Zahl ohne Kommastelle oder Buchstabe/Sonderzeichen ein.");
        //            versuche++;
        //            continue;
        //        }

        //        if (zahl >= 0 && zahl <= 15)
        //        {
        //            outputs.SuccessOutput($"Du hast die {zahl} als gültige Zahl eingegeben.\nDu brauchtest {versuche + 1} Versuche.");
        //            break;
        //        }
        //        else
        //        {
        //            outputs.ErrorOutput("Die Zahl liegt nicht im Bereich von 0 bis 15.");
        //            versuche++;
        //        }
        //    }
        //}

        public static void EingabePruefen()
        {
            int resultat = -1;
            int versuche = 0;

            while (true)
            {
                Console.WriteLine("Geben Sie bitte eine Zahl zwischen 0 und 15 ein: ");
                if (int.TryParse(Console.ReadLine(), out resultat))
                {
                    if (resultat >= 0 && resultat <= 15)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Bitte nur Zahlen eingeben!");
                }
                versuche++;
            }

            Console.WriteLine($"Eingabe Zahl: {resultat} - Versuche: {versuche + 1}");
        }

        public static void CalculateSumme(int target)
        {
            Console.WriteLine($"Beginne mit berechnung der Summe.");

            int summe = 0;
            //for (int i = 0; i < target; i++)
            //{
            //    summe += i;
            //}
            int i = 1;
            while (i < target)
            {
                summe += i;
                i++;
            }

            Console.WriteLine($"Deine berechnete Summe beträgt: {summe}");
        }

        internal static void Waehrungsrechner()
        {
            const decimal yen = 159.14558m;
            const decimal inr = 89.655121m;
            const decimal gbp = 0.82812935m;
            const decimal usd = 1.0581981m;
            decimal betragInEuro = -1;

            Console.WriteLine("-----------Waehrungsrechner-----------");
            do
            {
                Console.WriteLine("Geben Sie dein Betrag ein: ");
                bool istZahl = decimal.TryParse(Console.ReadLine(), out betragInEuro);
                if (betragInEuro <= 0)
                {
                    Console.WriteLine("Ungueltige Eingabe, probieren Sie bitte nochmal mit nur positive Zahlen.");
                }
                else if (istZahl)
                {
                    break;
                }
            } while (true);

            int gewuenschteWaehrung = 0;
            do
            {
                Console.WriteLine("Wir arbeiten nur mit die folgenden Waehrungen. Waehlen Sie bitte eins davon aus, anhand der Zahl:");
                Console.WriteLine("1. YEN\n2. INR\n3. GBP\n4. USD");
                int.TryParse(Console.ReadLine(), out gewuenschteWaehrung);
            } while (gewuenschteWaehrung <= 0 || gewuenschteWaehrung >= 5);

            decimal endBetrag = gewuenschteWaehrung switch
            {
                1 => yen * betragInEuro,
                2 => inr * betragInEuro,
                3 => gbp * betragInEuro,
                4 => usd * betragInEuro,
                _ => throw new Exception("Ungueltige Option.")
            };

            Console.WriteLine("Sie haetten: " + Math.Round(endBetrag, 2));

            //switch (gewuenschteWaehrung)
            //{
            //    case "YEN":
            //        Console.WriteLine("Sie haetten : " + yen*betragInEuro + " yen.");
            //        break;
            //}
        }

        internal static void SelfCheckout()
        {

            double gewicht;
            int menge;
            Console.WriteLine("Welches Produkt kaufen Sie?");
            string produkt = Console.ReadLine();
            decimal price = produkt switch
            {
                "apfel" or "granatapfel" => 2,
                "banane" => 1.50m,
                "orange" => 1.80m,
                _ => -1
            };
            //decimal priceTernaer = produkt == "apfel" ? 2 : produkt == "banane"? 1.50m:-1;

            switch (produkt)
            {
                case "apfel":
                    Console.WriteLine("Wir kaufen ein Apfel.");
                    Console.WriteLine("Apfel bitte auf die Wage legen.");
                    gewicht = Convert.ToDouble(Console.ReadLine());
                    price = (decimal)(2 + 0.8 * gewicht);
                    break;
                case "banane":
                    Console.WriteLine("Wir kaufen eine Banane.");
                    break;
                case "fertig":
                    break;
                default:

                    break;

            }
        }

        internal static void WuerfelFuenfzehnSpiel()
        {
            Random wuerfelWurfGenerator = new Random();

            int bonusPunkte = 0;

            Console.WriteLine("Spiel Start");
            Console.WriteLine("\n=========================================\n");
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

            int resultatSumme = summe + bonusPunkte;


            if (resultatSumme >= 16)
            {
                Console.WriteLine("Sie haben ein Auto gewonnen!");
            }
            else if (resultatSumme >= 10)
            {
                Console.WriteLine("Sie haben einen Laptop gewonnen!");
            }
            else if (resultatSumme == 7)
            {
                Console.WriteLine("Sie haben eine Reise gewonnen!");
            }
            else
            {
                Console.WriteLine("Eine Katze!!! Das beste preis!");
            }

            Console.WriteLine("\n=========================================\n");
            Console.WriteLine("Spiel Vorbei.");
        }

        /*
        * Wir haben Zwei Werte schon.
        * benutzername = "admin1"
        * passwort = "pass123"
        * 
        * Wir moechten in eine Methode 2 Werte von den Benutzer bekommen.
        * Diese Werte sollten in die Methode selbst durch ReadLine() eingelesen werden.
        * Wir moechten jetzt ueberpruefen ob die eingaben gleich unser benutzername und passwort sind.
        * 
        * Im fall wo beide stimmen => Wilkommen admin!
        * Im fall wo nur eins davon stimmt, dann schreiben wir auf die Konsole => Fasst...
        * Ansonsten => Kein Zugriff.
        */
        internal static void AdminUeberpruefung()
        {
            string benutzername = "admin1";
            string passwort = "pass123";

            Console.WriteLine("Geben Sie bitte Ihr benutzername ein: ");
            string? eingabeName = Console.ReadLine();

            Console.WriteLine("Geben Sie bitte Ihr passwort ein: ");
            string? eingabePass = Console.ReadLine();

            if (eingabeName == benutzername && eingabePass == passwort)
            {
                Console.WriteLine("Wilkommen admin!");
            }
            else if (eingabeName == benutzername || eingabePass == passwort)
            {
                Console.WriteLine("Fasst...");
            }
            else
            {
                Console.WriteLine("Kein Zugriff.");
            }
        }

        internal static void AlterKontoErstellen()
        {
            Console.WriteLine("Geben Sie bitte Ihr alter ein: ");
            int.TryParse(Console.ReadLine(), out int alter);

            if (alter < 16)
            {
                Console.WriteLine("Sie sind zu Jung um einen Online Banking Konto zu erstellen.");
            }
            else if (alter < 18)
            {
                Console.WriteLine("Sie duerfen einen Online Banking Konto Erstellen nur mit deine Eltern.");
            }
            else
            {
                Console.WriteLine("Sie sind alt genug!");
                Console.WriteLine("Sie duerfen Ihr Konto jetzt erstellen...");
            }

            Console.WriteLine("Wir machen hier weiter!");
        }

        internal static void Schreien(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        internal static void SummeZufallsZahlen()
        {
            Random zufallszahlGenerator = new Random();

            Summe(zufallszahlGenerator.Next(1, 301), zufallszahlGenerator.Next(1, 301), zufallszahlGenerator.Next(1, 301));
        }

        internal static void Summe(int a, int b, double c)
        {
            Console.WriteLine($"Die Summe von {a} + {b} + {c} ist: {a + b + c}");
        }

        internal static void Begruessung(string name)
        {
            Console.WriteLine($"Wilkommen im Kurs {name}!");
            Summe(10, 25, 20);
        }
    }
}
