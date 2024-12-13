**Dictionaries Anfang Beispiel**

            //Supermarkt lager
            Dictionary<string, int> lagerPaletten = new Dictionary<string, int>();

            lagerPaletten.Add("Milch", 5);
            lagerPaletten.Add("Gurke", 1);
            lagerPaletten.Add("Kekse", 2);


            foreach (var keyValuePair in lagerPaletten)
            {
                Console.WriteLine($"Key: {keyValuePair.Key} - Value: {keyValuePair.Value}");
                Console.WriteLine(lagerPaletten["Milch"]);
            }

            foreach (var key in lagerPaletten.Keys)
            {
                if(key == "Milch")
                {
                    lagerPaletten[key] = 2;
                }
            }
            
            //List<string> test = new List<string>();
            //Jeder wert in List<string> ist ein string.

            //Bei dictionaries, jeder wert ist ein Key Value Pair

**Dictionary openWith Uebung**

            /*
             * Ihr definiert eine Methode die heisst openWith(string path)
             * 
             * HelferMethode:
             * "/asdf/asdf/dateiname.exe"
             * parameter(string pfad): rueckgabewert string
             * Wir muessen als erster schritt ueberpruefen, was die datei endung in unser pfad ist.
             * Um die Zeichen nach den Punkt zu bekommen, 
             * empfehle ich eine neue Methode zu schreiben, die dass fuer euch schafft.
             * Diese helfermethode koennte beispielsweise in den pfad nach den index von einen "." suchen.
             * Dann anhand von diesen index und die Methode Substring(indexVonPunkt) die letzte Zeichen bekommen.
             * 
             * Unsere Uebung wieder:
             * Dann moechten wir in unser openWith methode unser dictionary erstellen,
             * der als erster eintrag (schluessel) den string mit verschiedene dateiendungen enthaelt.
             * Bspw: txt, py, cs, html
             * Dann als wert paar moechten wir den pfad zu eine exe datei angeben. 
             * Bspw: "asdf/notepad.exe", "asdf/vscode.exe", "visualstudio.exe", "microsoftedge.exe"
             * 
             * Ueberpruefen ob key in unser dictionary enthalten ist.
             * 
             * Wenn ja, dann gebe aus welche application wir verwenden wuerden um die datei zu oeffnen.
             * 
             * Beipsiels ausgabe:
             * Sie koennen die Datei {dateiname} mit {applikation} oeffnen, da es eine {dateiendung} Datei ist.
             * => Mit Werte: Sie koennen die Datei {Aufgabe13Dez} mit {VSCode} oeffnen, da es eine {py} Datei ist.
             */

*Loesung*

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

            return pfad.Substring(indexSchraegstrich + 1,laenge);
        }

**Dictionary Einkaufen Uebung**

            /*
             * Einkaufen bei TechStore (mediamarkt, apple store, saturn, etc...) list mit budget.
             * 
             * Wir gehen einkaufen. Wir sollten ein budget in die methode als parameter eingeben.
             * Wir sollten jetzt in einen TechStore einkaufen gehen.
             * Der benutzer soll einen Menue bekommen mit die Produkte und ihre Preise die er kaufen koennte.
             * D.h. Wir brauchen einen dictionary fuer produkt und preis.
             * 
             * Dann soll der benutzer in einen Kleinen menue aufgefordert werden produkte zu kaufen.
             * Wichtig hier, er darf sein budget nicht ueberschreiten.
             * 
             * Programmablauf:
             * Wilkommen in MediaMarkt!
             * Was moechten Sie heute kaufen?
             * 1. Laptop - 1200
             * 2. Handy - 800
             * 3. Kaffeemaschine - 400
             * 4. Waschmaschine - 700
             * 5. Druecker - 140
             * 6. Fernseher - 340
             * 7. Beenden
             * 
             * Wenn etwas gekauft wird, dann soll es zu die gekaufteProdukte hinzugefuegt werden.
             * Wir haben hierfuer eine Liste mit alle produkte die gekauft worden sind
             * Und auch eine variable fuer die gesamt summe aller produkte die wir gekauft haben.
             * 
             * Es soll am ende eine Rechnung erstellt werden:
             * Es soll ausgegeben werden welche produkte gekauft worden sind, wie viel wir dafuer gezahlt haben und am ende die summe.
             * Bspw: [Handy, Drueker, Fernseher, Handy]:
             * 
             * Handy x2 - 1600
             * Druecker x1 - 140
             * Fernseher x1 - 340
             * Betrag: 2080
             */

*Loesung*

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
                Console.WriteLine("Ihr budget betraegt: " + (budget-betrag));
                Console.WriteLine("1. Laptop - 1200\r\n2. Handy - 800\r\n3. Kaffeemaschine - 400\r\n4. Waschmaschine - 700\r\n5. Drucker - 140\r\n6. Fernseher - 340\r\n7. Beenden");
                eingabe = Console.ReadLine();
                if(eingabe == null || eingabe == "")
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
            Console.WriteLine(RechnungErstellenOhneGesamtBetrag(produkte, warenkorb)+"Betrag: " + betrag);
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
            foreach(var paar in produkte)
            { 
                if(paar.Value < min)
                {
                    min = paar.Value;
                }
            }
            return min;
        }
