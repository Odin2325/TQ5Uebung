using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenLernen
{
    public class BibKunde
    {
        //Test Hochladen Git
        private string vorname;
        private string nachname;
        private int alter;
        private string adresse;
        private decimal guthaben;
        private BuchVereinfacht[] ausgelieheneBuecher;
        private int kundennummer;
        private string passwort;
        private static int zaehlerKundenummer = 1;

        public BibKunde(string vorname, string nachname, int alter, string adresse, decimal guthaben, string passwort)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.alter = alter;
            this.adresse = adresse;
            this.guthaben = guthaben;
            this.kundennummer = zaehlerKundenummer;
            this.passwort = passwort;
            ausgelieheneBuecher = new BuchVereinfacht[3];
            zaehlerKundenummer++;
            Console.WriteLine($"Deine Login Informationen sind wie folgt: \nKundennummer: {this.kundennummer}\nPasswort: {this.passwort}");
        }

        public int Kundennummer { get => kundennummer; }
        public string Passwort { get => passwort; }

        public string KundeDetails()
        {
            return $"Vorname: {vorname}, Nachname: {nachname}, Alter: {alter}, Adresse: {adresse}, Guthaben: {guthaben}, Kundennummer: {kundennummer}";
        }

        public void PasswortAendern(string neuesPasswort)
        {
            this.passwort = neuesPasswort;
        }

        public bool BuchAusleihen(BuchVereinfacht buch)
        {
            for (int i = 0; i < ausgelieheneBuecher.Length; i++)
            {
                if (ausgelieheneBuecher[i] == null)
                {
                    ausgelieheneBuecher[i] = buch;
                    return true;
                }
            }
            return false;
        }

        public bool BuchZurueckgeben(BuchVereinfacht buch)
        {
            for(int i =0;i < ausgelieheneBuecher.Length; i++)
            {
                if (ausgelieheneBuecher[i] == buch)
                {
                    ausgelieheneBuecher[i] = null;
                    return true;
                }
            }
            return false;
        }
    }
}
