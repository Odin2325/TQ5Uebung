using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{
    public class Bibliothek
    {
        string name;
        string adresse;
        List<Bibkunde> kunden;
        Dictionary<Buch, int> katalog;
        static int kundenZähler = 99;
        public Bibliothek(string name, string adresse)
        {
                kunden = new List<Bibkunde>();
                katalog = new Dictionary<Buch, int>();
                this.name = name;
                this.adresse = adresse;
        }

        public Dictionary<Buch, int> Katalog { get => katalog; }

        public List<Bibkunde> BibKunden { get => kunden; }

            /// <summary>
            /// Gibt Name, Adresse und Kataloggröße dieser Bibliothek aus.
            /// </summary>
            /// <returns></returns>
        public string Details()
        {
            return $"Name: {name}\nAdresse: {adresse}\nKataloggröße: {katalog.Count()}";
        }

        public string KundennummerErstellen()
        {
            string kundennummer = kundenZähler.ToString().PadLeft(6, '0');
            kundenZähler++;
            return kundennummer;
        }
        public bool BuchAusleihen(Buch buch, Bibkunde kunde)
        {
            foreach (DateOnly datum in kunde.AusgelieheneBücher.Values)
            {
                if (datum < DateOnly.FromDateTime(DateTime.Now))
                {
                    Console.WriteLine("Ausstehende Rückgaben, Ausleihe nicht möglich.");
                    return false;
                }
            }
            if (kunde.AusgelieheneBücher.Count < 5 && kunde.guthaben > buch.Kosten)
            {
                kunde.AusgelieheneBücher.Add(buch, DateOnly.FromDateTime(DateTime.Now).AddDays(30));
                kunde.guthaben -= buch.Kosten;
                return true;
            }
            else
            {
                Console.WriteLine("Zu viele Bücher ausgeliehen oder zu wenig Guthaben.");
                return false;
            }
        }

        public bool BuchZurückGeben(Buch buch, Bibkunde kunde)
        {
            for (int i = 0; i < kunde.AusgelieheneBücher.Count; i++)
            {
                if (kunde.AusgelieheneBücher.ContainsKey(buch))
                {
                    kunde.AusgelieheneBücher.Remove(buch);
                    return true;
                }
            }
            Console.WriteLine("Rückgabe nicht möglich.");
            return false;
        }
        private bool IstKunde(Bibkunde kunde)
            // kundennummer prüfen
        {
            if (kunden.Contains(kunde))
            {
                return true;
            }
            return false;
        }

        private bool BuchInKatalog(Buch buch)
        {
            return katalog.ContainsKey(buch);
        }

        public bool KundeHinzufügen(Bibkunde kunde)
        {
            if (!IstKunde(kunde))
            {
                kunden.Add(kunde);
                Console.WriteLine("Kunde erfolgreich hinzugefügt.");
                return true;
            }
            else
            {
                Console.WriteLine("Kunde existiert bereits.");
                return false;
            }
        }
    }
}
