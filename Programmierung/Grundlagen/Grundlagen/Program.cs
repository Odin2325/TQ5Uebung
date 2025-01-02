using Grundlagen.Aufgaben;
using Grundlagen.Erfahren;
using Grundlagen.Fortgeschritten;
using Grundlagen.Simple;
using Grundlagen.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen
{
    internal class Program
    {
        private static Outputs outputs;
        private static Calculate calculate;
        private static DictionaryCalculate dictionaryCalculate;
        private static MessageWorker msgWorker;
        private static Switches switches;
        private static ArraysAndLists arraysAndLists;
        private static FileOpener fileOpener;
        private static CalculateTwo calTwo;
        private static RNASequenzierung rnaSequenzierung;
        private static Kasse kasse;
        private static LKW lkw;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            VersionHandler versionClass = new VersionHandler();
            outputs = new Outputs();
            calculate = new Calculate();
            dictionaryCalculate = new DictionaryCalculate();
            msgWorker = new MessageWorker();
            switches = new Switches();
            arraysAndLists = new ArraysAndLists();
            fileOpener = new FileOpener();
            calTwo = new CalculateTwo();
            rnaSequenzierung = new RNASequenzierung();
            kasse = new Kasse();
            lkw = new LKW();

            string version = versionClass.Update(versionClass.Read());
            versionClass.Save(version);
            outputs.NormalOutput($"Starte den Grundkurs.\nFolgende Version wird verwendet: {version}");
            outputs.NormalOutput("Fragen sind in Gelb. User-Input ist in Blau. Optionen ist in Weiss.");

            WaitForExit();
        }

        private static void WaitForExit()
        {
            StringBuilder options = new StringBuilder();

            options.AppendLine("- Durchschnitt")
                   .AppendLine("- Volume")
                   .AppendLine("- Temperatur")
                   .AppendLine("- Zylinder")
                   .AppendLine("- Invest")
                   .AppendLine("- Noten")
                   .AppendLine("- Random")
                   .AppendLine("- CallBack")
                   .AppendLine("- Login")
                   .AppendLine("- Würfelgame")
                   .AppendLine("- Währungsrechner")
                   .AppendLine("- CalculateSumme")
                   .AppendLine("- ValidateInput")
                   .AppendLine("- RepeatInput")
                   .AppendLine("- ReverseArray")
                   .AppendLine("- FindIndex")
                   .AppendLine("- RandomWord")
                   .AppendLine("- Pangram")
                   .AppendLine("- OpenWith")
                   .AppendLine("- NameChecker")
                   .AppendLine("- Faktor")
                   .AppendLine("- TerraAlter")
                   .AppendLine("- Schaltjahr")
                   .AppendLine("- RNA")
                   .AppendLine("- Kasse")
                   .AppendLine("- LKW")
                   .AppendLine("- Exit");

            while (true)
            {
                outputs.NormalOutput("Bitte gebe eines der folgenden Dinge an, die du testen möchtest:");
                Console.ResetColor();
                Console.WriteLine(options.ToString());

                Console.ForegroundColor = ConsoleColor.Blue;
                string input = Console.ReadLine();

                if (input.Equals("durchschnitt", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    double durchschnitt = calculate.BerechneDurchschnitt(calculate.werte);
                    outputs.SuccessOutput($"Der Durchschnitt beträgt: {durchschnitt}");
                }
                else if (input.Equals("volume", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    int länge = 12;
                    int breite = 12;
                    int höhe = 12;
                    int volume = calculate.BerechneVolume(länge, breite, höhe);
                    outputs.SuccessOutput($"Das Volumen beträgt: {volume}");
                }
                else if (input.Equals("temperatur", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    double fahrenheit = calculate.BerechneFahrenheit();
                    outputs.SuccessOutput($"Die berechnete Fahrenheit beträgt: {fahrenheit}");
                }
                else if (input.Equals("zylinder", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    var ergebnisse = calculate.BerechneZylinder(5, 10);

                    outputs.SuccessOutput($"Volumen: {ergebnisse.Item1}");
                    outputs.SuccessOutput($"Gesamtoberfläche: {ergebnisse.Item2}");
                    outputs.SuccessOutput($"Geprümmter Oberflächenbereich (seitliche Fläche): {ergebnisse.Item3}");
                }
                else if (input.Equals("invest", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    decimal result = calculate.BerechneInvestErtrag();

                    outputs.SuccessOutput($"Am Ende hast du {result}€");
                }
                else if (input.Equals("noten", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    dictionaryCalculate.NotenCalculate();

                    outputs.SuccessOutput($"Die Berechnung ist fertig.");
                }
                else if (input.Equals("random", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    calculate.ZufallsGenerator();
                }
                else if (input.Equals("callback", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    outputs.NormalOutput("Sprich mit mir😁Schreibe irgendeinen Satz!");
                    string msg = Console.ReadLine();
                    string answer = msgWorker.CallBack(msg);
                    outputs.SuccessOutput(answer);
                }
                else if (input.Equals("login", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    outputs.NormalOutput("Gebe bitte dein Username ein.");
                    string userName = Console.ReadLine();
                    outputs.NormalOutput("Gebe bitte dein Password ein.");
                    string pass = Console.ReadLine();

                    string answer = msgWorker.Login(userName, pass);
                    outputs.SuccessOutput(answer);
                }
                else if (input.Equals("würfelgame", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    msgWorker.WürfelGame();
                }
                else if (input.Equals("währungsrechner", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    decimal ergebnis = switches.Währungsrechner();
                    string währung = switches.choosenWährung;

                    if (ergebnis == 0)
                    {
                        outputs.ErrorOutput("Fehler 404: Ungültige Eingabe!");
                    }
                    else
                    {
                        outputs.SuccessOutput($"Dein umgerechneter Bertag beläuft sich auf {ergebnis}{währung}");
                    }
                }
                else if (input.Equals("calculatesumme", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    outputs.NormalOutput("Bitte gebe ein wo die schleife stoppen soll.");
                    int.TryParse(Console.ReadLine(), out int target);

                    calculate.CalculateSumme(target);
                }
                else if (input.Equals("validateinput", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    msgWorker.ValidateInput();
                }
                else if (input.Equals("repeatinput", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    msgWorker.RepeatInput();
                }
                else if (input.Equals("reversearray", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    arraysAndLists.ReverseArray(arraysAndLists.reverseArray);
                }
                else if (input.Equals("findindex", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    double target = 5.5;
                    int result = arraysAndLists.FindIndex(arraysAndLists.findIndex, target);
                    outputs.SuccessOutput($"Deine gesuchte Zahl ist an stelle: {result.ToString()}");
                }
                else if (input.Equals("randomword", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    string randomWord = arraysAndLists.GenerateRandomWord(20);
                    outputs.SuccessOutput($"Dein Random erstelltes Wort lautet: {randomWord}");
                }
                else if (input.Equals("pangram", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    var (originalWords, pangramWords) = arraysAndLists.Pangram();
                    outputs.SuccessOutput("Original Liste: " + string.Join(", ", originalWords));
                    outputs.SuccessOutput("Pangram Liste: " + string.Join(", ", pangramWords));
                }
                else if (input.Equals("openwith", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    fileOpener.OpenWith("version.txt");
                }
                else if (input.Equals("namechecker", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    msgWorker.NameChecker();
                }
                else if (input.Equals("faktor", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    calculate.FaktorAusgabe();
                }
                else if (input.Equals("terraalter", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    calTwo.TerraAlter();
                }
                else if (input.Equals("schaltjahr", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();

                    outputs.NormalOutput("Geben Sie ein Jahr ein, um zu prüfen, ob es ein Schaltjahr ist: ");
                    if (int.TryParse(Console.ReadLine(), out int jahr))
                    {
                        if (calTwo.BerechneSchaltjahr(jahr))
                        {
                            outputs.SuccessOutput($"{jahr} ist ein Schaltjahr.");
                        }
                        else
                        {
                            outputs.SuccessOutput($"{jahr} ist kein Schaltjahr.");
                        }
                    }
                    else
                    {
                        outputs.ErrorOutput("Ungültige Eingabe. Bitte eine Ganzzahl eingeben.");
                    }
                }
                else if (input.Equals("rna", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    string rna = "AUGUUUUCUUGGUAAAUG";
                    var protein = rnaSequenzierung.CheckRNA(rna);

                    outputs.NormalOutput("Protein Sequenz:");
                    foreach (var acid in protein)
                    {
                        outputs.SuccessOutput(acid);
                    }
                }
                else if (input.Equals("kasse", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    ManageKasse();
                }
                else if (input.Equals("lkw", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    ManageLKW();
                }
                else if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    outputs.NormalOutput("Programm wird beendet. Auf Wiedersehen!");
                    break;
                }
                else
                {
                    Console.ResetColor();
                    outputs.ErrorOutput("Ungültiger Befehl. Versuche es erneut.");
                }

                // Abfrage, ob der Benutzer etwas weiter testen möchte
                Console.WriteLine("\nMöchtest du etwas anderes testen? (ja/nein)");
                Console.ForegroundColor = ConsoleColor.Blue;
                string continueInput = Console.ReadLine();

                if (continueInput.Equals("nein", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    outputs.NormalOutput("Programm wird beendet. Auf Wiedersehen!");
                    break;
                }
                else if (!continueInput.Equals("ja", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ResetColor();
                    outputs.ErrorOutput("Ungültige Antwort. Programm wird beendet.");
                    break;
                }
            }
        }

        private static void ManageKasse()
        {
            while (true)
            {
                Console.WriteLine("\nWählen Sie eine Option:");
                Console.WriteLine("1: Geld einzahlen");
                Console.WriteLine("2: Geld auszahlen");
                Console.WriteLine("3: Kassenstand anzeigen");
                Console.WriteLine("4: Rechnung drucken");
                Console.WriteLine("5: Beenden");

                Console.ForegroundColor = ConsoleColor.Blue;
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        outputs.NormalOutput("Geben Sie den Geldwert ein (z. B. 10):");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        int wert = int.Parse(Console.ReadLine());

                        outputs.NormalOutput("Geben Sie die Menge ein:");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        int menge = int.Parse(Console.ReadLine());

                        Console.ResetColor();
                        kasse.GeldEinzahlen(wert, menge);
                        break;

                    case "2":
                        outputs.NormalOutput("Geben Sie den Auszahlungsbetrag ein:");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        int betrag = int.Parse(Console.ReadLine());
                        Console.ResetColor();

                        kasse.GeldAuszahlen(betrag);
                        break;

                    case "3":
                        Console.ResetColor();
                        kasse.KassenstandAusgeben();
                        break;

                    case "4":
                        outputs.NormalOutput("Geben Sie den Betrag für die Rechnung ein:");

                        Console.ForegroundColor = ConsoleColor.Blue;
                        int rechnungsBetrag = int.Parse(Console.ReadLine());
                        Console.ResetColor();

                        kasse.RechnungDrucken(rechnungsBetrag);
                        break;

                    case "5":
                        outputs.SuccessOutput("Programm beendet.");
                        return;

                    default:
                        outputs.ErrorOutput("Ungültige Option. Bitte erneut versuchen.");
                        break;
                }
            }
        }

        private static void ManageLKW()
        {
            while (true)
            {
                Console.WriteLine("\nWählen Sie eine Option:");
                Console.WriteLine("1: Motor starten/stoppen");
                Console.WriteLine("2: Fahren");
                Console.WriteLine("3: Beenden");

                Console.ForegroundColor = ConsoleColor.Blue;
                string input = Console.ReadLine();
                Console.ResetColor();

                switch (input)
                {
                    case "1":
                        lkw.ManageMotor();
                        break;

                    case "2":
                        lkw.Fahren();
                        break;

                    case "5":
                        outputs.SuccessOutput("Programm beendet.");
                        return;

                    default:
                        outputs.ErrorOutput("Ungültige Option. Bitte erneut versuchen.");
                        break;
                }
            }
        }
    }
}
