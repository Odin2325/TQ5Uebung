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
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            VersionHandler versionClass = new VersionHandler();
            outputs = new Outputs();
            calculate = new Calculate();
            dictionaryCalculate = new DictionaryCalculate();
            msgWorker = new MessageWorker();

            string version = versionClass.Update(versionClass.Read());
            versionClass.Save(version);
            outputs.NormalOutput($"Starte den Grundkurs.\nFolgende Version wird verwendet: {version}");

            WaitForExit();
        }

        private static void WaitForExit()
        {
            string[] options = {
                "- Durchschnitt",
                "- Volume",
                "- Temperatur",
                "- Zylinder",
                "- Invest",
                "- Noten",
                "- Random",
                "- CallBack",
                "- Exit"
            };

            while (true)
            {
                Console.WriteLine("Bitte gebe eines der folgenden Dinge an, die du testen möchtest:");
                foreach (var option in options)
                {
                    Console.WriteLine(option);
                }

                string input = Console.ReadLine();

                if (input.Equals("durchschnitt", StringComparison.OrdinalIgnoreCase))
                {
                    double durchschnitt = calculate.BerechneDurchschnitt(calculate.werte);
                    outputs.SuccessOutput($"Der Durchschnitt beträgt: {durchschnitt}");
                }
                else if (input.Equals("volume", StringComparison.OrdinalIgnoreCase))
                {
                    int länge = 12;
                    int breite = 12;
                    int höhe = 12;
                    int volume = calculate.BerechneVolume(länge, breite, höhe);
                    outputs.SuccessOutput($"Das Volumen beträgt: {volume}");
                }
                else if (input.Equals("temperatur", StringComparison.OrdinalIgnoreCase))
                {
                    double fahrenheit = calculate.BerechneFahrenheit();
                    outputs.SuccessOutput($"Die berechnete Fahrenheit beträgt: {fahrenheit}");
                }
                else if (input.Equals("zylinder", StringComparison.OrdinalIgnoreCase))
                {
                    var ergebnisse = calculate.BerechneZylinder(5, 10);

                    outputs.SuccessOutput($"Volumen: {ergebnisse.Item1}");
                    outputs.SuccessOutput($"Gesamtoberfläche: {ergebnisse.Item2}");
                    outputs.SuccessOutput($"Geprümmter Oberflächenbereich (seitliche Fläche): {ergebnisse.Item3}");
                }
                else if (input.Equals("invest", StringComparison.OrdinalIgnoreCase))
                {
                    decimal result = calculate.BerechneInvestErtrag();

                    outputs.SuccessOutput($"Am Ende hast du {result}€");
                }
                else if (input.Equals("noten", StringComparison.OrdinalIgnoreCase))
                {
                    dictionaryCalculate.NotenCalculate();

                    outputs.SuccessOutput($"Die Berechnung ist fertig.");
                }
                else if (input.Equals("random", StringComparison.OrdinalIgnoreCase))
                {
                    calculate.ZufallsGenerator();
                }
                else if (input.Equals("callback", StringComparison.OrdinalIgnoreCase))
                {
                    outputs.NormalOutput("Sprich mit mir😁Schreibe irgendeinen Satz!");
                    string msg = Console.ReadLine();
                    string answer = msgWorker.CallBack(msg);
                    outputs.SuccessOutput(answer);
                }
                else if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    outputs.NormalOutput("Programm wird beendet. Auf Wiedersehen!");
                    break;
                }
                else
                {
                    outputs.ErrorOutput("Ungültiger Befehl. Versuche es erneut.");
                }

                // Abfrage, ob der Benutzer etwas weiter testen möchte
                Console.WriteLine("\nMöchtest du etwas anderes testen? (ja/nein)");
                string continueInput = Console.ReadLine();
                if (continueInput.Equals("nein", StringComparison.OrdinalIgnoreCase))
                {
                    outputs.NormalOutput("Programm wird beendet. Auf Wiedersehen!");
                    break;
                }
                else if (!continueInput.Equals("ja", StringComparison.OrdinalIgnoreCase))
                {
                    outputs.ErrorOutput("Ungültige Antwort. Programm wird beendet.");
                    break;
                }
            }
        }
    }
}
