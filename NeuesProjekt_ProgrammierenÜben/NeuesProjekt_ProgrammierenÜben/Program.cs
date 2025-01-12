namespace NeuesProjekt_ProgrammierenÜben
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Aufgabe  Würfel Volumen
            Console.Write("Geben Sie die Seitenlänge des Würfels ein (ganzzahlig positiv): ");   
            int seitenlaenge = int.Parse(Console.ReadLine());
            int volumen = seitenlaenge * seitenlaenge * seitenlaenge;
            Console.WriteLine($"Das Volumen des Würfels beträgt: {volumen} Kubikeinheiten.");

            //Aufgabe Währungsumrechnung
            decimal geld = 300.50m;
            float gewechselterTyp = (float)geld;
            Console.WriteLine("Der Typ der variable ist: " + gewechselterTyp.GetType());
            Console.WriteLine("Wert = " + gewechselterTyp);

            //Aufgabe Durchschnittsalter
            Console.Write("Geben Sie das Alter der ersten Person ein: ");
            int alter1 = int.Parse(Console.ReadLine());

            Console.Write("Geben Sie das Alter der zweiten Person ein: ");
            int alter2 = int.Parse(Console.ReadLine());

            Console.Write("Geben Sie das Alter der dritten Person ein: ");
            int alter3 = int.Parse(Console.ReadLine());

            // Berechnung des Durchschnittsalters
            int summe = alter1 + alter2 + alter3;
            double durchschnitt = summe / 3.0; 

            Console.WriteLine($"alter1 = {alter1}");
            Console.WriteLine($"alter2 = {alter2}");
            Console.WriteLine($"alter3 = {alter3}");
            Console.WriteLine($"Der durchschnittsalter ist: {alter1}+{alter2}+{alter3} / 3 = {durchschnitt:F2}");

            //Aufgabe 1 Temparaturumrechnung
            Console.Write("Geben Sie die Temperatur in Celsius ein: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine($"{celsius}°C entsprechen {fahrenheit:F2}°F.");

            //Aufgabe Zylinder
            double PI = 3.1415;
            Console.WriteLine("Geben Sie den Radius des Zylinders ein: ");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Geben Sie die Höhe des Zylinders ein: ");
            int height = int.Parse(Console.ReadLine());

            double zylinder = 2 * PI * radius * height;

            Console.WriteLine($"der Zylinder mit der Höhe {height} und Radius {radius} hat folgendes Volumen: {zylinder:F2}");

            //Aufgabe Zinseszins
            double zinssatz = 0.04;
            int n = 1;
            Console.WriteLine("Geben Sie das zu investierende Vermögen ein: ");
            double vermögen = double.Parse(Console.ReadLine());
            Console.WriteLine("Geben Sie den Zeitraum an über den das Vermögen angelegt wird: ");
            int zeitraum = int.Parse(Console.ReadLine());
            double Anlage = vermögen * Math.Pow(1 + (zinssatz / 1), n * zeitraum);
            Console.WriteLine($"Das Endvermögen nach {zeitraum} Jahren beträgt: {Anlage:F2}");

            //Aufgabe Random zahlen addieren
            Random random = new Random();

            //Drei zufällige Zahlen zwischen 1 und 100 generieren
            int zahl1 = random.Next(1, 101); 
            int zahl2 = random.Next(1, 101);
            int zahl3 = random.Next(1, 101);

            // Summe berechnen
            int addition = zahl1 + zahl2 + zahl3;

            Console.WriteLine($"Die zufälligen Zahlen sind: {zahl1}, {zahl2}, {zahl3}");
            Console.WriteLine($"Die Summe der Zahlen ist: {addition}");
            Aufgabe Login überprüfen
            string Benutzername = "admin1";
            string Passwort = "pass123";

            überprüfung(Benutzername, Passwort);
            Würfelspiel();
            summenRechnen();
            PinLogin();
            Pyramide();
            StarteIndexSuche();
            WortAusgabe();
            Zeichenausgabe();
            double budget = LiesBudget();
            Einkaufen(budget);
            Schaltjahr();
            Aufgabe();
            List<double> zahlen = [ 1.2, 3.4, 5.6, 7.8, 9.1 ];

            var statistik = ListStatistics(zahlen);

            Console.WriteLine("Statistik der Liste:");
            Console.WriteLine($"Durchschnitt: {statistik.Durchschnitt}");
            Console.WriteLine($"Summe: {statistik.Summe}");
            Console.WriteLine($"Min: {statistik.Min}");
            Console.WriteLine($"Max: {statistik.Max}");
            Console.WriteLine($"Anzahl Werte: {statistik.Anzahl}");

            var buch = new BuchVereinfacht(300, "Max Mustermann", "C# lernen leicht gemacht", "Programmierung", "1. Auflage", "1234567890", 39.99m, "2023", "Dies ist ein großartiges Buch!");
            Console.WriteLine(buch.BuchDetailsAnzeigen());
            Console.WriteLine(buch.InhalteLesen());*/
         }
        static void überprüfung(string Benutzername, string Passwort)
        {
            
            Console.WriteLine("Geben Sie Ihren Benutzernamen ein: ");
            string eingabeBenutzername = Console.ReadLine();

            Console.WriteLine("Geben Sie Ihr Passwort ein: ");
            string eingabePasswort = Console.ReadLine();

            if (eingabeBenutzername == Benutzername && eingabePasswort == Passwort)
            {
                Console.WriteLine("Wilkommen admin!");
            }
            else
            {
                Console.WriteLine("kein Zugriff!");
            }
        }
        static void Würfelspiel()
        {
            Random würfelwurf = new Random();

            for (int i = 0; i < 10; i++)
            {
                int wurf1 = würfelwurf.Next(1, 7);
                int wurf2 = würfelwurf.Next(1, 7);
                int wurf3 = würfelwurf.Next(1, 7);

                int Bonus = 0;
                int summe = wurf1 + wurf2 + wurf3;

                Console.WriteLine("Spiel start");
                Console.WriteLine("");
                Console.WriteLine($"Wurf:{wurf1} + {wurf2} + {wurf3}");
                Console.WriteLine("");
                Console.WriteLine("Spiel Ende!");
                if (wurf1 == wurf2 || wurf1 == wurf3 || wurf2 == wurf3)
                {
                    Bonus += 2;
                    Console.WriteLine("Zweierpasch!");
                }
                else if (wurf1 == wurf2 && wurf1 == wurf3)
                {
                    Bonus += 6;
                    Console.WriteLine("Dreierpasch!");
                }
                else
                {
                    Console.WriteLine("kein Gewinn!");
                }
                Console.WriteLine("Bonuspunkte: " + Bonus);
                if (summe + Bonus >= 16)
                {
                    Console.WriteLine("Gewonnen!");
                    Console.WriteLine("Hier dein neues Auto!");
                    Console.WriteLine("-------------");
                }
                else if (summe + Bonus >= 10)
                {
                    Console.WriteLine("Gewonnen!");
                    Console.WriteLine("Hier dein Laptop"!);
                    Console.WriteLine("-------------");
                }
                else if (summe + Bonus == 7)
                {
                    List<string> länder = new List<string>
                    {
                    "Deutschland",
                    "Frankreich",
                    "Italien",
                    "Spanien",
                    "Japan",
                    "China",
                    "Brasilien",
                    "Kanada",
                    "Indien",
                    "Australien",
                    "Russland",
                    "USA",
                    "Mexiko",
                    "Südafrika",
                    "Argentinien"
                    };

                    Random random = new Random();

                    int zufälligerIndex = random.Next(0, länder.Count);

                    string zufälligesLand = länder[zufälligerIndex];
                    Console.WriteLine("Gewonnen!");
                    Console.WriteLine($"deine nächste Reise geht nach {zufälligesLand}");
                    Console.WriteLine("-------------");
                }
                else if (summe + Bonus < 7)
                {
                    Console.WriteLine("Das war wohl eine Niete!");
                    Console.WriteLine("-------------");
                }
            }
        }
        static void summenRechnen()
        {
            int summe = 0;
            for (int i = 0; i <= 200; i++)
            {
                summe += i;
            }
            Console.WriteLine($"Die Summer der Zahlen 1 bis 200 beträgt: {summe}");
        }
        static void PinLogin()
        {
            string Pin = "1234";
            string PinEingabe = "";
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Geben Sie ihre Pin ein: ");
                PinEingabe = Console.ReadLine();
                if (Pin == PinEingabe)
                {
                    Console.WriteLine("Sie werden eingeloggt.");
                    return;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, bitte versuchen Sie es erneut. Sie haben noch " + (3 - i) + " Versuche");
                }
            }
            Console.WriteLine("Bitte kontaktieren sie den Kundenservice um ihre Karte zu entsperren.");
        }
        static void Währungsrechner()
        {
            double betragInEuro = 0;
            string gewuenschteWaehrung = "";
            bool gültigeEingabe = false;

            string[] Währungen = { "USD", "GBP", "CHF", "JPY" };
            while (!gültigeEingabe)
            {
                Console.WriteLine("Bitte geben sie einen Betrag in € ein: ");
                betragInEuro = double.Parse(Console.ReadLine());
                if (betragInEuro >= 0)
                {
                    gültigeEingabe = true;
                }
                else
                {
                    Console.WriteLine("Betrag muss größer als 0€ sein");
                }
            }
            gültigeEingabe = false;

            while (!gültigeEingabe)
            {
                Console.WriteLine("bitte geben sie die gewünschte Währung an");
                gewuenschteWaehrung = Console.ReadLine().ToUpper();
                if (Array.Exists(Währungen, Währung => Währung == gewuenschteWaehrung))
                {
                    gültigeEingabe = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Währung. Bitte wählen sie zwischen USD, GBP, CHF und JPY");
                }
            }
            double betragInZielWährung = Umrechnen(betragInEuro, gewuenschteWaehrung);
            Console.WriteLine($"{betragInEuro:F2} EUR entsprechen {betragInZielWährung:F2} {gewuenschteWaehrung}.");

        }
        static double Umrechnen(double betragInEuro, string Währung)
        {
            double wechselkurs = Währung switch
            {
                "USD" => 1.1,
                "GBP" => 0.85,
                "CHF" => 1.05,
                "JPY" => 140.0,
                _ => 1.0
            };

            return betragInEuro * wechselkurs;
        }
        static void Pyramide()
        {
            {
                Console.Write("Bitte geben Sie die Anzahl der Zeilen für die Pyramide ein: ");
                if (int.TryParse(Console.ReadLine(), out int zeilen) && zeilen > 0)
                {
                    for (int i = 1; i <= zeilen; i++)
                    {
                        Console.Write(new string(' ', zeilen - i));

                        // Sterne mit Leerzeichen dazwischen
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }

                        // Zeilenumbruch für die nächste Zeile
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie eine gültige positive ganze Zahl ein.");
                }
            }
        }
        static void Ausgabe(string[] array)
        {
            Console.WriteLine("{" + string.Join(",", array) + "}");
        }
        static int[] Reverse(int[] array)
        {
            int[] reversed = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }
            return reversed;
        }
        static void StarteIndexSuche()
        {
            double[] array = new double[] { 21, 85, 165, 456, 651, 351, 512, 354, 151, 754, 891, 541 };

            Console.WriteLine("\nGeben Sie die Zahl ein, deren Index Sie finden möchten:");
            double value = double.Parse(Console.ReadLine());

            double index = FindIndexVonWert(array, value);

            if (index != -1)
            {
                Console.WriteLine($"Die Zahl {value} wurde an Index {index} gefunden.");
            }
            else
            {
                Console.WriteLine($"Die Zahl {value} wurde im Array nicht gefunden.");
            }
        }
        public static double FindIndexVonWert(double[] array, double value)
        {
            for (double i = 0; i < array.Length; i++)
            {
                if (array[(int)i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        static void WortAusgabe()
        {
            bool weitermachen = true;
            while (weitermachen)
            {
                Console.WriteLine("Geben Sie die gewünschte Länge des Wortes ein:");
                int laenge = int.Parse(Console.ReadLine());

                string wort = RandomWort(laenge);
                Console.WriteLine($"Das generierte Wort lautet: {wort}");

                Console.WriteLine("Ist das wort zufriedenstellend? Ja/Nein: ");
                string antwort = Console.ReadLine().ToLower();

                if (antwort == "ja")
                {
                    Console.WriteLine("Vielen dank");
                    weitermachen = false;
                }
                else if (antwort == "nein")
                {
                    Console.WriteLine("Dann nochmal!");
                }
                else
                {
                    Console.WriteLine("ungültige Eingabe, wir beenden das hier");
                    weitermachen = false;
                }
            }
        }
        static string RandomWort(int laenge)
        {
            Random random = new Random();
            char[] zeichensammlung = new char[laenge];

            for (int i = 0; i < laenge; i++)
            {
                bool istGrossBuchstabe = random.Next(0, 2) == 1;
                if (istGrossBuchstabe)
                {
                    zeichensammlung[i] = (char)random.Next(65, 91);
                }
                else
                {
                    zeichensammlung[i] = (char)random.Next(97, 123);
                }
            }
            return new string(zeichensammlung);
        }
        static void Zeichenausgabe()
        {
            Console.WriteLine("Bitte geben Sie einen beliebigen Satz ein:");
            string benutzerEingabe = Console.ReadLine();

            string ergebnis = VertauscheWorte(benutzerEingabe);
            Console.WriteLine($"Der neue String lautet: {ergebnis}");
        }
        static string VertauscheWorte(string eingabe)
        {
            string[] worte = eingabe.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < worte.Length; i++)
            {
                char[] chars = worte[i].ToCharArray();
                Array.Reverse(chars);
                worte[i] = new string(chars);
            }
            return string.Join(" ", worte);
        }
        static double LiesBudget()
        {
            Console.WriteLine("Willkommen in MediaMarkt!");
            Console.WriteLine("Bitte geben Sie Ihr Budget ein:");
            return double.Parse(Console.ReadLine());
        }
        static void Einkaufen(double budget)
        {
            Dictionary<string, double> produkte = new Dictionary<string, double>
            {
                {"Laptop", 1200},
                {"Handy", 800},
                {"Kaffeemaschine", 400},
                {"Waschmaschine", 700},
                {"Druecker", 140},
                {"Fernseher", 340}
            };

            List<string> gekaufteProdukte = new List<string>();
            double gesamtSumme = 0;

            while (true)
            {
                Console.WriteLine("\nWas moechten Sie heute kaufen?");
                int index = 1;
                foreach (var produkt in produkte)
                {
                    Console.WriteLine($"{index}. {produkt.Key} - {produkt.Value} EUR");
                    index++;
                }
                Console.WriteLine("Geben Sie die 7 ein umd en Einkauf zu Beenden");

                Console.Write("Ihre Auswahl: ");
                string auswahl = Console.ReadLine();

                if (auswahl == "7")
                {
                    Console.WriteLine("Vielen Dank fuer Ihren Einkauf!");
                    break;
                }

                if (int.TryParse(auswahl, out int produktIndex) && produktIndex >= 1 && produktIndex <= produkte.Count)
                {
                    string ausgewaehltesProdukt = produkte.ElementAt(produktIndex - 1).Key;
                    double preis = produkte[ausgewaehltesProdukt];

                    if (gesamtSumme + preis <= budget)
                    {
                        gekaufteProdukte.Add(ausgewaehltesProdukt);
                        gesamtSumme += preis;
                        Console.WriteLine($"{ausgewaehltesProdukt} wurde Ihrem Warenkorb hinzugefuegt.");
                    }
                    else
                    {
                        Console.WriteLine("Ihr Budget reicht nicht aus, um dieses Produkt zu kaufen.");
                    }
                }
                else
                {
                    Console.WriteLine("Ungueltige Eingabe. Bitte waehlen Sie eine gueltige Option.");
                }
            }

            ErstelleRechnung(gekaufteProdukte, gesamtSumme);
        }
        static void ErstelleRechnung(List<string> gekaufteProdukte, double gesamtSumme)
        {
            Console.WriteLine("\nIhre Rechnung:");
            var produktGruppen = gekaufteProdukte.GroupBy(p => p);

            foreach (var gruppe in produktGruppen)
            {
                string produkt = gruppe.Key;
                int anzahl = gruppe.Count();
                double gesamtPreis = anzahl * gruppe.FirstOrDefault().Length;
                Console.WriteLine($"{produkt} x{anzahl} - {gesamtPreis} EUR");
            }

            Console.WriteLine($"Gesamtbetrag: {gesamtSumme:F2} EUR");
        }
        static void Schaltjahr()
        {
            Console.WriteLine("bitte gib eine Jahreszahl ein");
            int Jahr = int.Parse(Console.ReadLine());

            if (Jahr >= 0) {
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
        static void Aufgabe()
        {
            Console.WriteLine("Bitte geben sie eine RNA Sequenz ein: ");
            string RNA = Console.ReadLine();

            Dictionary<string, string> CodonTabelle = new Dictionary<string, string>()
            {
                { "AUG", "Methionin"},
                { "UUU", "Phenylalanin"},
                { "UUC", "Phenylalanin"},
                { "UUA", "Leucin"},
                { "UUG", "Leucin"},
                { "UCU", "Serin"},
                { "UCC", "Serin"},
                { "UCA", "Serin"},
                { "UCG", "Serin"},
                { "UAU", "Tyrosin"},
                { "UAC", "Tyrosin"},
                { "UGU", "Cystein"},
                { "UGC", "Cystein"},
                { "UGG", "Tryptophan"},
                { "UAA", "STOP"},
                { "UAG", "STOP"},
                { "UGA", "STOP"}
            };

            List<string> Protein = new List<string>();

            for (int i = 0; i < RNA.Length; i += 3)
            {
                string Codon = RNA.Substring(i, 3);

                if (CodonTabelle.ContainsKey(Codon))
                {
                    string Aminosäure = CodonTabelle[Codon];

                    if (Aminosäure == "STOP")
                    {
                        break;
                    }

                    Protein.Add(Aminosäure);
                }

                else
                {
                    Console.WriteLine($"ungültiges Codon gefunden: {Codon}");
                    break;
                }
            }

            Console.WriteLine("Die Protein Sequenz ist: ");
            Console.WriteLine(string.Join(", "), Protein);
        }
        public static double BerechneMax(List<double> zahlen)
        {
            double max = double.MinValue;
            foreach (var zahl in zahlen)
            {
                if (zahl > max)
                    max = zahl;
            }
            return max;
        }
        public static double BerechneMin(List<double> zahlen)
        {
            double min = double.MaxValue;
            foreach (var zahl in zahlen)
            {
                if (zahl < min)
                    min = zahl;
            }
            return min;

        }
        public static double BerechneDurchschnitt(List<double> zahlen)
        {
            if (zahlen.Count == 0) return 0;
            return BerechneSumme(zahlen) / zahlen.Count;
        }
        public static double BerechneSumme(List<double> zahlen)
        {
            double summe = 0;
            foreach (var zahl in zahlen)
            {
                summe += zahl;
            }
            return summe;
        }
        public static (double Durchschnitt, double Summe, double Min, double Max, int Anzahl) ListStatistics(List<double> zahlen)
        {
            double summe = BerechneSumme(zahlen);
            double durchschnitt = BerechneDurchschnitt(zahlen);
            double min = BerechneMin(zahlen);
            double max = BerechneMax(zahlen);
            int anzahl = zahlen.Count;

            return (durchschnitt, summe, min, max, anzahl);
        }
    }
    internal class Auto
    {
        public string Farbe;
        public string Hersteller;
        public string Modell;
        public int MaxGeschwindigkeit;
        public bool MotorAn = false;
        public int AktuelleGeschwindigkeit;
        public bool LichtIstAn = false;
        public bool TuerIstOffen = false;

        public Auto(string farbe, string hersteller, string modell, int maxGeschwindigkeit)
        {
            Farbe = farbe;
            Hersteller = hersteller;
            Modell = modell;
            MaxGeschwindigkeit = maxGeschwindigkeit;

            MotorAn = false;
            AktuelleGeschwindigkeit = 0;
            LichtIstAn = false;
            TuerIstOffen = false;
        }
        public void MotorStarten()
        {
            if (!MotorAn)
            {
                MotorAn = true;
                LichtIstAn = true;
                TuerIstOffen = false;
                Console.WriteLine("Der Motor wurde gestartet. Licht ist eingeschaltet.Türen wurden geschlossen.");
            }
        }
        public void Beschleunigen()
        {
            if (MotorAn)
            {
                if (AktuelleGeschwindigkeit <= MaxGeschwindigkeit)
                {
                    AktuelleGeschwindigkeit += 10;
                    Console.WriteLine(AktuelleGeschwindigkeit);
                    if (AktuelleGeschwindigkeit == MaxGeschwindigkeit)
                    {
                        Console.WriteLine("Reisegeschwindigkeit erreicht");
                    }
                }         
            }
        }
        public void Bremsen()
        {
            if (MotorAn)
            {
                if (AktuelleGeschwindigkeit == MaxGeschwindigkeit)
                {
                    AktuelleGeschwindigkeit -= 10;
                    Console.WriteLine(AktuelleGeschwindigkeit);
                    if (AktuelleGeschwindigkeit == 0)
                    Console.WriteLine($"Sie haben auf {AktuelleGeschwindigkeit} gebremst");
                    LichtIstAn = false;
                    Console.WriteLine("Sobald der Motor aus ist, können die Türen geöffnet werden.");
                }
            }
        }
        public void MotorStoppen()
        {
            if (MotorAn)
            {
                if (AktuelleGeschwindigkeit == 0)
                {
                    MotorAn = false;
                    LichtIstAn = false;
                    Console.WriteLine("Der Motor wurde gestoppt. Licht aus.");
                    TuerIstOffen = true;
                    Console.WriteLine("Die Türen wurden geöffnet.");
                }
            }
        }
    }
}