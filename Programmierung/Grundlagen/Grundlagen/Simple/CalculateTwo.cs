using Grundlagen.utils;
using System;
using System.Collections.Generic;

namespace Grundlagen.Simple
{
    internal class CalculateTwo
    {
        private Dictionary<string, Dictionary<string, int>> schuelerNoten = new Dictionary<string, Dictionary<string, int>>(StringComparer.OrdinalIgnoreCase)
        {
            { "Sophia", new Dictionary<string, int> { { "Mathe", 93 }, { "Deutsch", 87 }, { "Englisch", 98 }, { "Biologie", 95 }, { "Chemie", 100 } } },
            { "Nicolas", new Dictionary<string, int> { { "Mathe", 80 }, { "Deutsch", 83 }, { "Englisch", 82 }, { "Biologie", 88 }, { "Chemie", 85 } } },
            { "Zahira", new Dictionary<string, int> { { "Mathe", 84 }, { "Deutsch", 96 }, { "Englisch", 90 }, { "Biologie", 67 }, { "Chemie", 79 } } },
            { "Jeong", new Dictionary<string, int> { { "Mathe", 70 }, { "Deutsch", 90 }, { "Englisch", 99 }, { "Biologie", 81 }, { "Chemie", 63 } } }
        };

        private Outputs outputs;

        public CalculateTwo()
        {
            outputs = new Outputs();
        }

        public void NotenCalculate()
        {
            outputs.NormalOutput("Für wen willst du die Summe berechnen?\nSophia\nNicolas\nZahira\nJeong");
            string input = Console.ReadLine()?.Trim();

            if (!schuelerNoten.ContainsKey(input))
            {
                outputs.ErrorOutput("Schüler nicht gefunden!");
                return;
            }

            var noten = schuelerNoten[input];
            int summe = BerechneSumme(noten);
            double durchschnitt = BerechneDurchschnitt(summe, noten.Count);

            outputs.SuccessOutput($"{input}s Summe: {summe}");
            outputs.NormalOutput("Berechne nun den Durchschnitt...");
            outputs.SuccessOutput($"{input}s Durchschnitt: {durchschnitt:F2}");

            outputs.NormalOutput("Berechne die Noten...");
            foreach (var punkte in noten.Values)
            {
                string note = BerechneNote(punkte);
                outputs.SuccessOutput($"Fachnote: {note}");
            }
        }

        private int BerechneSumme(Dictionary<string, int> noten)
        {
            int summe = 0;
            foreach (var note in noten.Values)
            {
                summe += note;
            }
            return summe;
        }

        private double BerechneDurchschnitt(int summe, int anzahlFaecher)
        {
            return (double)summe / anzahlFaecher;
        }

        private string BerechneNote(int punkte)
        {
            if (punkte <= 100 && punkte > 96) return "A+";
            if (punkte <= 96 && punkte > 92) return "A";
            if (punkte <= 92 && punkte > 89) return "A-";
            if (punkte <= 89 && punkte > 86) return "B+";
            if (punkte <= 86 && punkte > 82) return "B";
            return "Durchgefallen!";
        }
    }
}