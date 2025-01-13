using System.Numerics;
using System.Reflection;
using System.Text;

namespace ProgrammierenLernen
{
    /*
     * Wir moechten einen Einfachen interface erstellen.
     * Dies soll ein interface fuer verschieden Figuren und wie die auf den Bildschirm angezeigt werden.
     * Wir muessen in diesen interface einen x, y coordinat definieren als Property.
     * Es soll ein getter und setter haben.
     * 
     * Wir muessen auch einen Property fuer die Dimensionen von die Figuren haben.
     * 
     * Wir brauechten eine Methode fuer den Oberflaeche, und eine Methode um den Perimeter zu berechnen.
     * 
     * Die moeglichen figuren sind:
     * Punkt, Viereck, rechtwinkliges Dreieck, Linie
     */

    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Punkt x:{x}, y:{y}");
        }
    }

    internal class Program
    {
        static Bibliothek bib = new Bibliothek("StaatsBib", "Leopoldstrasse 1");
        static BuchVereinfacht buchVereinfacht1 = new BuchVereinfacht(279, "Jane Austen", "Pride and Prejudice", "Fiction, Historical Fiction, Literature, Historical Romance", "2023 Edition", "1441341706", 0.99m, "1813", "Inhalt", new DateOnly());
        static BuchVereinfacht buchVereinfacht2 = new BuchVereinfacht(340, "George Orwell", "1984", "Classic Fiction", "3", "B0DRNQWLFT", 2.99m, "1985", "London", new DateOnly());
        static BuchVereinfacht buchVereinfacht3 = new BuchVereinfacht(473, "Charles Dickens", "Great Expectations", "Literature", "3", "B08NTM6WFN", 0.99m, "1941", "Inhalt", new DateOnly());
        static BuchVereinfacht buchVereinfacht4 = new BuchVereinfacht(406, "Gregory Maguire", "Wicked", "Fantasy", "2", "B000FC14JY", 8.99m, "2023", "Inhalt", new DateOnly());

        static void Main(string[] args)
        {
            bib.BuecherKaufen(buchVereinfacht1, 12);
            bib.BuecherKaufen(buchVereinfacht2, 13);
            bib.BuecherKaufen(buchVereinfacht3, 6);
            bib.BuecherKaufen(buchVereinfacht4, 30);
            
            Console.WriteLine($"Sie sind im System von: {bib.Name}. Was moechten Sie tun?");
            while (OberMenue());
        }

        internal static bool OberMenue()
        {
            Console.WriteLine("Sie sind im Menue.");
            Console.WriteLine("Bitte Waehle eins der optionen aus.");
            Console.WriteLine("1. Einloggen");
            Console.WriteLine("2. Kunde werden");
            Console.WriteLine("3. Account loeschen");
            Console.WriteLine("4. Beenden");

            var menueAuswahl = Console.ReadLine();
            switch (menueAuswahl)
            {
                case "1":
                    Console.WriteLine("Sie moechten sich einloggen.");
                    var kunde = KundeFinden();
                    if(kunde != null)
                    {
                        while(KundeMenue(kunde));
                    }
                    else
                    {
                        Console.WriteLine("Kundennummer oder Passwort Falsch oder Konto noch nicht erstellt.");
                    }
                    AufKundeWarten();
                    return true;
                case "2":
                    bib.KundeHinzufuegen(KundeErstellen());
                    Console.WriteLine("Kunde erfolgreich erstellt!");
                    AufKundeWarten();
                    return true;
                case "3":
                    KundeLoeschenAusBib();
                    AufKundeWarten();
                    return true;
                case "4":
                    Console.WriteLine("Programm wird beendet.");
                    AufKundeWarten();
                    return false;
                default:
                    Console.WriteLine("Ungueltige eingabe.");
                    return true;
            }
        }

        internal static void AufKundeWarten()
        {
            Console.WriteLine("Druecke auf eine Taste um weiter zu kommen.");
            Console.ReadKey();
            Console.Clear();
        }

        internal static void KundeLoeschenAusBib()
        {
            Console.WriteLine("Sie moechten Ihr Konto loeschen.");
            var kunde = KundeFinden();
            if (kunde == null)
                return;

            if (bib.KundeLoeschen(kunde))
            {
                Console.WriteLine("Kunde erfolgreich geloscht!");
            }
            else
            {
                Console.WriteLine("Konto nicht gefunden.");
            }
        }

        internal static BibKunde KundeFinden()
        {
            Console.WriteLine("Geben Sie bitte Ihr Kundennummer und Passwort ein:");
            Console.Write("Kundennummer eingeben: ");
            int.TryParse(Console.ReadLine(), out int kndnmr);
            Console.Write("Passwort eingeben: ");
            var pass = Console.ReadLine();
            var kunde = bib.KundeFinden(kndnmr, pass);
            if (kunde != null)
                return kunde;
            else
                return null;
        }

        internal static bool KundeMenue(BibKunde kunde)
        {
            Console.WriteLine("Sie sind eingeloggt.");
            Console.WriteLine("Bitte Waehle eins der optionen aus.");
            Console.WriteLine("1. Katalog Anschauen");
            Console.WriteLine("2. Buch Ausleihen");
            Console.WriteLine("3. Buch Zurueckgeben");
            Console.WriteLine("4. Ausloggen");
            var menueAuswahl = Console.ReadLine();

            switch (menueAuswahl)
            {
                case "1":
                    Console.WriteLine("========================================================");
                    Console.WriteLine("Katalog wird ausgegeben.");
                    bib.KatalogAusgeben();
                    Console.WriteLine("========================================================");
                    AufKundeWarten();
                    return true;
                case "2":
                    Console.WriteLine("Welches Buch moechten Sie ausleihen?");
                    Console.WriteLine("Geben Sie bitte das Titel ein: ");
                    var titelA = Console.ReadLine();
                    var buchA = bib.BuchNachTitelSuchen(titelA);
                    if(kunde == null || buchA == null) 
                    {
                        Console.WriteLine("Ungueltiger Kunder oder Buch titel.");
                        return true;
                    }
                    bib.KundeBuch_Ausleiehen(kunde,buchA);
                    AufKundeWarten();
                    return true;
                case "3":
                    Console.WriteLine("Welches Buch moechten Sie zurueckgeben?");
                    Console.WriteLine("Geben Sie bitte das Titel ein: ");
                    var titelR = Console.ReadLine();
                    var buchR = bib.BuchNachTitelSuchen(titelR);
                    if (kunde == null || buchR == null)
                    {
                        Console.WriteLine("Ungueltiger Kunder oder Buch titel.");
                        return true;
                    }
                    bib.KundeBuch_Rueckgabe(kunde, buchR);
                    AufKundeWarten();
                    return true;
                case "4":
                    Console.WriteLine("Sie moechten ausloggen.");
                    AufKundeWarten();
                    return false;
                default:
                    Console.WriteLine("Ungueltige eingabe.");
                    return true;
            }
        }

        internal static BibKunde KundeErstellen()
        {
            Console.WriteLine("Geben Sie bitte die folgenden Informationen ein:");
            Console.Write("Vorname: ");
            string vorname = Console.ReadLine();
            Console.Write("Nachname: ");
            string nachname = Console.ReadLine();
            Console.Write("Alter: ");
            int.TryParse(Console.ReadLine(), out int alter);
            Console.Write("Adresse: ");
            string adresse = Console.ReadLine();
            Console.Write("Guthaben: ");
            decimal.TryParse(Console.ReadLine(), out decimal guthaben);
            Console.Write("Passwort: ");
            string passwort = Console.ReadLine();



            return new BibKunde(vorname, nachname, alter, adresse, guthaben, passwort);
        }

    }

}
