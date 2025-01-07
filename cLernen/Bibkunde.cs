using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{
    public class Bibkunde
    {
        private string vorname;
        private string nachname;
        private int alter;
        private string adresse;
        private decimal guthaben = 0m;
        private Dictionary<Buch, DateOnly> ausgelieheneBücher = new();
        private string kundennummer = NummerErstellen(11);
        private string passwort = NummerErstellen(9);

        public Bibkunde(string vorname, string nachname, int alter, string adresse)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.alter = alter;
            this.adresse = adresse;
        }
        public string Passwort { get => passwort; }

        public string KundenDetails()
        {
            return $"Vorname: {vorname}, Nachname: {nachname}, Alter: {alter}, Adresse: {adresse}, Guthaben: {guthaben}, Kundennummer: {kundennummer}";
        }

        public void BücherAnzeigen()
        {
            foreach (KeyValuePair<Buch, DateOnly> kvp in ausgelieheneBücher)
            {
                Console.WriteLine($"Titel: {kvp.Key.Titel}, Autor: {kvp.Key.Autor}, Rückgabe: {kvp.Value}");
            }
        }
        public bool BuchAusleihen(Buch buch)
        {
            foreach (DateOnly datum in ausgelieheneBücher.Values)
            {
                if (datum < DateOnly.FromDateTime(DateTime.Now))
                {
                    Console.WriteLine("Ausstehende Rückgaben, Ausleihe nicht möglich.");
                    return false;
                }
            }
            if (ausgelieheneBücher.Count < 5 && guthaben > buch.Kosten)
            {
                ausgelieheneBücher.Add(buch, DateOnly.FromDateTime(DateTime.Now).AddDays(30));
                guthaben -= buch.Kosten;
                return true;
            }
            else
            {
                Console.WriteLine("Zu viele Bücher ausgeliehen.");
                return false;
            }
        }

        public bool BuchZurückGeben(Buch buch)
        {
            for (int i = 0; i<ausgelieheneBücher.Count; i++)
            {
                if (ausgelieheneBücher.ContainsKey(buch))
                {
                    ausgelieheneBücher.Remove(buch);
                    return true;
                }
            }
            Console.WriteLine("Rückgabe nicht möglich.");
            return false;
        }
        static string NummerErstellen(int anzahl)
        {
            string nummer = "";
            Random rnd = new Random();
            for (int i = 0; i < anzahl; i++)
                nummer += rnd.Next(0, 10);
            return nummer;
        }

        public void GuthabenAufladen(decimal betrag)
            //missing error handling
        {
            if (betrag <= 0)
                Console.WriteLine("Ungültiger Betrag.");
            else
                guthaben += betrag;
        }
        public virtual bool PasswortÄndern()
        {
            Console.WriteLine("Bitte altes Passwort eingeben:");
            string eingabe = Console.ReadLine();
            if (eingabe == passwort)
            {
                Console.WriteLine("Bitte neues Passwort mit mindestens 6 Zeichen eingeben:");
                string neuesPasswort = "";
                do
                {
                    neuesPasswort = Console.ReadLine();

                } while (neuesPasswort.Length < 6);
                passwort = neuesPasswort;
                return true;
            }
            else
            {
                Console.WriteLine("Password inkorrekt");
                return false;
            }
        }
    }
}
