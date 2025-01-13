using SomeAufgaben.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SomeAufgaben.Bücherkatalog
{
    internal class Katalog
    {
        private Outputs outputs;

        private Dictionary<string, int> bücherkatalog = new Dictionary<string, int>()
        {
            { "Gefangene von Askaban", 3 },
            { "Mustermann Buch", 18 }
        };
        public Katalog() 
        { 
            outputs = new Outputs();
        }

        public void ShowAusgelieheneBücher(Kunde kunde)
        {
            outputs.Trennung();
            outputs.NormalOutput("Suche nach ausgeliehenen Büchern...");

            // Überprüfen, ob der Kunde ausgeliehene Bücher hat
            if (kunde.ausgeliehendeBücher != null && kunde.ausgeliehendeBücher.Count > 0)
            {
                outputs.NormalOutput($"Ausgeliehene Bücher:\n");
                foreach (var buch in kunde.ausgeliehendeBücher)
                {
                    outputs.NormalOutput($"- {buch}\n");
                }
            }
            else
            {
                outputs.NormalOutput($"Du hast keine Bücher ausgeliehen.");
            }
            outputs.Trennung();
        }

        public void BuchAusleihen(Kunde kunde)
        {
            outputs.Trennung();
            outputs.NormalOutput("Ausleihvorgang gestartet...");

            
            outputs.NormalOutput("Bitte gib den Titel des auszu leihenden Buches ein:");
            string buchTitel = Console.ReadLine().Trim();

            // Überprüfen, ob das Buch schon ausgeliehen wurde
            if (!kunde.ausgeliehendeBücher.Contains(buchTitel))
            {
                // Buch zur Liste der ausgeliehenen Bücher hinzufügen
                kunde.ausgeliehendeBücher.Add(buchTitel);
                outputs.SuccessOutput($"Das Buch '{buchTitel}' wurde erfolgreich ausgeliehen.");
            }
            else
            {
                outputs.ErrorOutput($"Das Buch '{buchTitel}' wurde bereits ausgeliehen.");
            }

            outputs.Trennung();
        }

        public void BuchZurückGeben(Kunde kunde)
        {
            outputs.Trennung();
            outputs.NormalOutput("Welches Buch möchtest du zurück geben?");
            string buchTitel = Console.ReadLine();


            // Überprüfen, ob das Buch in der Liste der ausgeliehenen Bücher ist
            if (kunde.ausgeliehendeBücher.Contains(buchTitel))
            {
                // Buch aus der Liste der ausgeliehenen Bücher entfernen
                kunde.ausgeliehendeBücher.Remove(buchTitel);
                outputs.SuccessOutput($"Das Buch '{buchTitel}' wurde erfolgreich zurückgegeben.");
            }
            else
            {
                outputs.ErrorOutput($"Das Buch '{buchTitel}' wurde nicht ausgeliehen oder ist bereits zurückgegeben.");
            }
        }
    }
}
