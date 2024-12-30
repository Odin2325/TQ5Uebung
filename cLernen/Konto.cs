using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{
    internal abstract class Konto
    {
        protected string name;
        protected string email;
        protected string addresse;
        protected string telefonnummer;
        protected string passwort;
        protected string benutzername;

        protected Konto(string name, string email, string addresse, string telefonnummer, string benutzername)
        {
            this.name = name;
            this.email = email;
            this.addresse = addresse;
            this.telefonnummer = telefonnummer;
            this.benutzername = benutzername;
        }
        // protected virtual void EditProfileData();
        // choose data, compare old data, validate new data
        // validation methods for everything

        protected static string PasswortGenerieren(int länge)
        {
            string passwort = "";
            Random rnd = new Random();
            for (int i = 0; i < länge; i++)
                passwort += rnd.Next(0, 10);
            return passwort;
        }
        public virtual void DetailsAnzeigen()
        {
            Console.WriteLine($"Name: {name}\nErreichbar unter die Nummer: {telefonnummer}\n");
        }
        protected virtual bool PasswortÄndern() //change method from bool to string and add a validation method?
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
        public bool EmailAktualisieren()
        {
            Console.WriteLine("Bitte geben Sie Ihre neue Email-Adresse ein: ");
            string eingabe = Console.ReadLine();
            if (eingabe.Contains('@') && eingabe.Contains('.'))
            {
                Console.WriteLine("Email-Adresse wurde erfolgreich aktualisiert.");
                email = eingabe;
                return true;
            }
            else
            {
                Console.WriteLine("Email-Adresse ist nicht gueltig.");
                return false;
            }
        }
    }

    internal class FBKonto : Konto
    {
        private List<FBKonto> freunde = new List<FBKonto>();

        public FBKonto(string email, string adresse, string name, string telefonnummer, string benutzername) : base(email, adresse, name, telefonnummer, benutzername)
        {
            this.passwort = PasswortGenerieren(6);
        }

        public override void DetailsAnzeigen()
        {
            base.DetailsAnzeigen();
            Console.WriteLine("Freunde: ");
            foreach (var freund in freunde)
            {
                Console.WriteLine(freund.name);
            }
        }

        public void FreundeHinzufuegen(FBKonto freund)
        {
            freunde.Add(freund);
        }
    }
    internal class Bankkonto: Konto
    {
        private string kontonummer = KontonummerGenerieren();
        private decimal kontostand = 0;
        private List<string> kontoHistorie = new List<string>();

        public Bankkonto(string kontoinhaber, string email,string addresse, string telefonnummer, string benutzername) : base(kontoinhaber, email, addresse, telefonnummer, benutzername)
        {
            this.passwort = PasswortGenerieren(4);
        }

        private static string KontonummerGenerieren()
        {
            string neueKontonummer = "DE";
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
                neueKontonummer += rnd.Next(0, 10);
            return neueKontonummer;
        }
        public override void DetailsAnzeigen()
        {
            base.DetailsAnzeigen();
            Console.WriteLine("Kontostand: " + kontostand);
            KontoHistorieAusgeben();
        }

        private void KontoHistorieAusgeben()
        {
            Console.WriteLine("=======================================\nKontoHistorie\n=======================================");
            foreach (var eintrag in kontoHistorie)
            {
                Console.WriteLine(eintrag);
            }
            Console.WriteLine("=======================================");
        }

        public void GeldEinzahlen()
        {
            Console.WriteLine("Geld Einzahlen: ");
            if (PinUeberpruefen())
            {
                Console.WriteLine("Wie viel Geld moechten Sie einzahlen?");
                decimal betrag = Convert.ToDecimal(Console.ReadLine());
                kontostand += betrag;
                kontoHistorie.Add($"Einzahlung: ${betrag} am {DateTime.Now}");
            }
        }
        public void GeldAuszahlen()
        {
            Console.WriteLine("Geld Auszahlen: ");
            if (PinUeberpruefen())
            {
                Console.WriteLine("Wie viel Geld moechten Sie auszahlen?");
                decimal betrag = Convert.ToDecimal(Console.ReadLine());
                kontostand -= betrag;
                kontoHistorie.Add($"Auszahlung: ${betrag} am {DateTime.Now}");
            }
        }
        private bool PinUeberpruefen()
        {
            string eingabe = "";

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Bitte geben Sie Ihr BankPin ein: ");
                eingabe = Console.ReadLine();
                if (eingabe == passwort)
                {
                    Console.WriteLine("Wilkommen!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Falsches Pin eingegeben.");
                    Console.WriteLine("Sie haben noch " + (3 - i) + " versuche uebrig.");
                }
            }
            Console.WriteLine("Konto wurde gesperrt.");
            Console.WriteLine("Bitte Support anrufen.");
            return false;
        }
    }

    internal class Büchereikonto : Konto
    {
        private List<Buch> ausgelieheneBücher = new List<Buch>();

        public Büchereikonto(string kontoinhaber, string email, string addresse, string telefonnummer, string benutzername) : base(kontoinhaber, email, addresse, telefonnummer, benutzername)
        {

        }
        public void BuchAusleihen(Buch buch)
        {
            if (ausgelieheneBücher.Count() < 3){
                ausgelieheneBücher.Add(buch);
            }
            else
                Console.WriteLine("Nicht möglich, maximale Ausleihzahl überschritten");
            foreach (Buch listenbuch in ausgelieheneBücher)
                Console.WriteLine(listenbuch.titel);
        }
        public void BuchZurückGeben(string name)
        {
            foreach (Buch buch in ausgelieheneBücher)
            {
                if (buch.titel == name)
                    ausgelieheneBücher.Remove(buch);
            }
        }
     }
}
