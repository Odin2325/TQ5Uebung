namespace ProgrammierenLernen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            
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
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void PinUeberpruefung(string echtenPin)
        {
            string pinEingabe = "";
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Geben Sie bitte ihr pin ein: ");
                pinEingabe = Console.ReadLine();
                if (pinEingabe == echtenPin)
                {
                    Console.WriteLine("Sie werden eingeloggt.");
                    return;
                }
                else
                {
                    Console.WriteLine("Uebrige versuche: " + (3 - i));
                }
            }
            Console.WriteLine("Kontaktieren Sie bitte die Filiale um ihr Konto wieder zu aktivieren.");
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
                if(int.TryParse(Console.ReadLine(), out resultat))
                {
                    if(resultat >=0 && resultat <= 15)
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

            Console.WriteLine($"Eingabe Zahl: {resultat} - Versuche: {versuche+1}");
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
                else if(istZahl)
                {
                    break;
                }
            } while (true);

            int gewuenschteWaehrung = 0;
            do {
                Console.WriteLine("Wir arbeiten nur mit die folgenden Waehrungen. Waehlen Sie bitte eins davon aus, anhand der Zahl:");
                Console.WriteLine("1. YEN\n2. INR\n3. GBP\n4. USD");
                int.TryParse(Console.ReadLine(), out gewuenschteWaehrung);
            } while (gewuenschteWaehrung <= 0 || gewuenschteWaehrung >= 5);

            decimal endBetrag = gewuenschteWaehrung switch
            {
                1 => yen*betragInEuro,
                2 => inr*betragInEuro,
                3 => gbp*betragInEuro,
                4 => usd*betragInEuro,
                _ => throw new Exception("Ungueltige Option.")
            };

            Console.WriteLine("Sie haetten: " + Math.Round(endBetrag,2));

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

            if(wurf1 == wurf2 && wurf1 == wurf3)
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

            Console.WriteLine("\nGesamt punktzahl: " + (summe + bonusPunkte)+"\n");

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
