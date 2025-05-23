﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenLernen
{
    /*
    * Abstrakt Konto => Bauplan fuer alle moegliche Klassen sein.
    * email, adresse, name, telefonnummer.
    * 2 Methoden ueberlegen, die alle Klassen haben sollen.
    * DetailsAnzeigen.
    * 
    * Bankkonto => kontostand, bankpin, kontonummer, kontoinhaber, kontoHistorie. Methoden => geld einzahlen, geld auszahlen.
    * SocialMediaKonto => freunde liste (List<FbKonto>), nachrichten.
    * BibliotheksKonto => Eigenschaften: Liste<Buch> ausgeliehenBuecher. 
    * Methode: ausleihen (darf nicht mehr als 3 buecher auf einmal ausleihen), zurueckgeben.
    */
    public abstract class Konto
    {
        protected string email;
        protected string adresse;
        protected string name;
        protected string telefonnummer;
        protected string passwort;
        protected string benutzername;

        protected Konto(string email, string adresse, string name, string telefonnummer, string passwort, string benutzername)
        {
            this.email = email;
            this.adresse = adresse;
            this.name = name;
            this.telefonnummer = telefonnummer;
            this.passwort = passwort;
            this.benutzername = benutzername;
        }

        public string Passwort
        {
            get { return passwort; }
        }

        public string Benutzername
        {
            get { return benutzername; }
        }

        //abstract => wir *muessen* es in die Kind klasse implementieren.
        //virtual => wir *koennen* es in die Kind klasse implementieren.
        public virtual void DetailsAnzeigen()
        {
            Console.WriteLine($"Name: {name}\nErreichbar unter die Nummer: {telefonnummer}\n");
        }
        public virtual bool PasswortAktualisieren()
        {
            Console.WriteLine("Bitte geben Sie Ihr altes Passwort ein: ");
            string eingabe = Console.ReadLine();
            if (eingabe == passwort)
            {
                string neuesPasswort = "";
                do
                {
                    Console.WriteLine("Geben Sie bitte Ihr neues Passwort ein:");
                    Console.WriteLine("Es muss mehr als 6 Zeichen haben.");
                    neuesPasswort = Console.ReadLine();
                } while (neuesPasswort.Length < 6);
                return true;
            }
            else
            {
                Console.WriteLine("Passwort nicht korrekt.");
                return false;
            }
        }
        public bool EmailAktualisieren()
        {
            Console.WriteLine("Bitte geben Sie Ihre neue Email-Adresse ein: ");
            string eingabe = Console.ReadLine();
            if (eingabe.Contains("@") && eingabe.Contains("."))
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

    public class FBKonto : Konto
    {
        private List<FBKonto> freunde = new List<FBKonto>();

        public FBKonto(string email, string adresse, string name, string telefonnummer, string passwort, string benutzername) : base(email, adresse, name, telefonnummer, passwort, benutzername)
        {
        }

        public override void DetailsAnzeigen()
        {
            base.DetailsAnzeigen();
            Console.WriteLine("Freunde: ");
            foreach(var freund in freunde)
            {
                Console.WriteLine(freund.name);
            }
        }

        public void FreundeHinzufuegen(FBKonto freund)
        {
            freunde.Add(freund);
        }
    }

    /*
     * Pin ueberpruefen => 4 zeichen lang, besteht nur aus zahlen.
     * Benutzername (IBAN) => 12 zeichen lang, erste 2 zeichen sind DE, letzte 10 zeichen sind nur zahlen.
     * Email => enthaelt einen "@" und einen ".", wird mit entweder .com oder .de enden.
     * Geld Einzahlen => negative betrag, positiver betrag, eingabe 0, kontostand wurde richtig erhoeht.
     * Geld Auszahlen => negative betrag, positiver betrag, eingabe 0, kontostand wurde richtig verringert.
     */
    public class Bankkonto : Konto
    {
        private decimal kontostand;
        private List<string> kontoHistorie = new List<string>();
        public Bankkonto(string email, string adresse, string kontoinhaber, string telefonnummer) : base(email, adresse, kontoinhaber, telefonnummer, BankWerteGenerieren(4), BankWerteGenerieren(10))
        {
            kontostand = 0;
        }
        public Bankkonto() : base("maxiemuster@gmail.com", "Berlinerstrasse 99", "Max Mustermann", "086535534233", "1111","DE1234567890")
        {
            kontostand = 0;
        }

        public decimal Kontostand
        {
            get { return kontostand; }
        }
        public List<string> KontoHistorie
        {
            get { return kontoHistorie; }
        }

        private static string BankWerteGenerieren(int laenge)
        {
            string resultat = "";
            Random rnd = new Random();
            if (laenge > 4)
            {
                resultat += "DE";
            }
            for (int i = 0; i < laenge; i++)
            {
                resultat += rnd.Next(0, 10);
            }
            Console.WriteLine("Aktuelles Wert: " + resultat);
            return resultat;
        }

        public override bool PasswortAktualisieren()
        {
            Console.WriteLine("Unser BankPin, darf nicht veraendert werden.");
            return false;
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

        public bool GeldEinzahlen(decimal betrag)
        {
            Console.WriteLine("Geld Einzahlen: ");
            if (PinUeberpruefen(passwort))
            {
                kontostand += betrag;
                kontoHistorie.Add($"Einzahlung: ${betrag} am {DateTime.Now}");
                return true;
            }
            return false;
        }
        public bool GeldAuszahlen(decimal betrag)
        {
            Console.WriteLine("Geld Auszahlen: ");
            if (PinUeberpruefen(passwort))
            {
                kontostand -= betrag;
                kontoHistorie.Add($"Auszahlung: ${betrag} am {DateTime.Now}");
                return true;
            }
            return false;
        }
        private bool PinUeberpruefen(string eingabe)
        { 
            for (int i = 1; i <= 3; i++)
            {
                if (eingabe == passwort)
                {
                    Console.WriteLine("Wilkommen!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Falsches Pin eingegeben.");
                    Console.WriteLine("Sie haben noch " + (3-i) + " versuche uebrig.");
                }
            }
            Console.WriteLine("Konto wurde gesperrt.");
            Console.WriteLine("Bitte Support anrufen.");
            return false;
        }
    }
}
