using Grundlagen.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Simple
{
    internal class Calculate
    {
        Outputs outputs;

        public Dictionary<string, int> werte = new Dictionary<string, int>
        {
            { "Nico", 90 },
            { "Hugo", 30 },
            { "Ronny", 52 },
            { "Kevin", 46 }
        };

        public Calculate() 
        {
            outputs = new Outputs();
        }

        public double BerechneDurchschnitt(Dictionary<string, int> dictionary)
        {
            outputs.NormalOutput("Berechne den Durchschnitt...");

            if (dictionary == null || dictionary.Count == 0)
                throw new ArgumentException("Die Liste darf nicht leer oder null sein.");

            int summe = 0;
            foreach (var wert in dictionary.Values)
            {
                summe += wert;
            }

            return (double)summe / dictionary.Count;
        }

        public int BerechneVolume(int länge, int breite, int höhe)
        {
            outputs.NormalOutput("Berechne Volumen...");

            int volume = länge * breite * höhe;
            return volume;
        }

        public double BerechneFahrenheit()
        {
            double result = 0;
            bool validInput = false;

            while (!validInput)
            {
                outputs.NormalOutput("Bitte gebe (in Celsius) den Wert ein, der in Fahrenheit umgerechnet werden soll");
                string input = Console.ReadLine();
                outputs.NormalOutput("Validiere Wert...");
                if (input != null && int.TryParse(input, out int celsius))
                {
                    outputs.NormalOutput("Wert akzeptiert...\nBerechne Fahrenheit...");
                    result = celsius * 1.8 + 32;
                    validInput = true;
                }
                else
                {
                    outputs.ErrorOutput("Du hast keine gültige Ganzzahl eingegeben. Bitte versuche es erneut.");
                }
            }

            return result;
        }

        public Tuple<double, double, double> BerechneZylinder(double radius, double höhe)
        {
            outputs.NormalOutput("Berechne Volumen...");
            double volumen = Math.PI * Math.Pow(radius, 2) * höhe;

            outputs.NormalOutput("Berechne gesamte Oberfläche...");
            double gesamtOberfläche = 2 * Math.PI * radius * (radius + höhe);

            outputs.NormalOutput("Berechne gekrümmte Oberfläche...");
            double gekruemmteOberfläche = 2 * Math.PI * radius * höhe;

            return Tuple.Create(volumen, gesamtOberfläche, gekruemmteOberfläche);
        }

        public decimal BerechneInvestErtrag()
        {
            outputs.NormalOutput("Bitte gebe ein wieviel du Investieren willst...");
            decimal invest = Convert.ToDecimal(Console.ReadLine());

            outputs.NormalOutput("Bitte gebe ein wieviele Jahre du Investieren willst...");
            int jahre = Convert.ToInt32(Console.ReadLine());

            decimal zinssatz = 0.04m;
            decimal endbetrag = invest * (decimal)Math.Pow((double)(1 + zinssatz), jahre);
            return Math.Round(endbetrag, 2);
        }

        public void ZufallsGenerator()
        { 
            Random random = new Random(); 
            HashSet<int> zufallsZahlen = new HashSet<int>(); 
            
            while (zufallsZahlen.Count < 3) 
            { 
                int zahl = random.Next(1, 301); 
                zufallsZahlen.Add(zahl); 
            } 
            
            outputs.SuccessOutput("Die generierten Zufallszahlen sind:"); 
            
            foreach (int zahl in zufallsZahlen) 
            {
                outputs.SuccessOutput(zahl.ToString()); 
            } 
        }

        public void CalculateSumme(int target)
        {
            outputs.NormalOutput($"Beginne mit berechnung der Summe.");

            int summe = 0;
            for (int i = 0; i < target; i++)
            {
                summe += i;
            }

            outputs.SuccessOutput($"Deine berechnete Summe beträgt: {summe}");
        }

        public void FaktorAusgabe()
        {
            outputs.NormalOutput("==============Berechne den Faktor==============");
            int count3 = 0, count5 = 0, count7 = 0;

            for (int i = 0; i <= 100; i++)
            {
                string ausgabe = i.ToString();
                string ergaenzung = "";

                if (i % 3 == 0)
                {
                    ergaenzung += "pling";
                    count3++;
                }
                if (i % 5 == 0)
                {
                    ergaenzung += "plang";
                    count5++;
                }
                if (i % 7 == 0)
                {
                    ergaenzung += "plong";
                    count7++;
                }

                if (!string.IsNullOrEmpty(ergaenzung)) ausgabe += " " + ergaenzung;

                outputs.SuccessOutput(ausgabe);
            }

            outputs.NormalOutput("\n============Statistik============");
            outputs.NormalOutput($"Anzahl Zahlen durch 3 teilbar: {count3}");
            outputs.NormalOutput($"Anzahl Zahlen durch 5 teilbar: {count5}");
            outputs.NormalOutput($"Anzahl Zahlen durch 7 teilbar: {count7}");
        }
    }
}
