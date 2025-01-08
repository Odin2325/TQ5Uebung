//<Harry Potter, 23>,<Lord of the Rings, 12>,<Lord of the flies, 20>
//katalog[Lord of the flies] => 20
//katalog[Lord of the flies] += 2 => 20 += 2 => 22

namespace ProgrammierenLernen
{
    public class Bibliothek
    {
        string name;
        string adresse;
        List<BibKunde> kunden;
        Dictionary<BuchVereinfacht, int> katalog;
        static int kundeNummer = 1;

        public Bibliothek(string name, string adresse)
        {
            kunden = new List<BibKunde>();
            katalog = new Dictionary<BuchVereinfacht, int>();
            this.name = name;
            this.adresse = adresse;
        }

        public Dictionary<BuchVereinfacht, int> Katalog { get => katalog; }

        public List<BibKunde> BibKundes { get => kunden; }

        /// <summary>
        /// Geben Name, Adresse und Katalog Groesse von diese Bib aus.
        /// </summary>
        /// <returns></returns>
        public string Details()
        {
            return $"Name: {name}\nAdresse: {adresse}\nKatalog Groesse: {katalog.Count()}";
        }

        /// <summary>
        /// Geben in einen bestimmten Format alle buecher aus unser katalog mit die menge.
        /// </summary>
        /// <returns></returns>
        public string KatalogAusgeben()
        {
            string result = "";

            result += "Buch Name\t\t|Buch Anzahl";

            foreach(var kvp in katalog)
            {
                result += $"\n{kvp.Key.Titel}\t\t|{kvp.Value}";
            }

            Console.WriteLine(result);
            return result ;
        }

        private bool IstKunde(BibKunde kunde)
        {
            if (kunden.Contains(kunde))
            {
                return true;
            }
            return false;
        }

        private bool BuchInKatalogEnthalten(BuchVereinfacht buch)
        {
            return katalog.ContainsKey(buch);
        }

        /// <summary>
        /// Wir probieren einen Buch wieder zurueckzugeben zu die Bib.
        /// Wenn das Buch im Katalog enthalten ist und wenn der Kunde das Buch hat dann wird es zurueckgegeben.
        /// Ansonsten ist die Rueckgabe nicht erlaubt.
        /// </summary>
        /// <param name="kunde"></param>
        /// <param name="buch"></param>
        /// <returns></returns>
        public bool KundeBuch_Rueckgabe(BibKunde kunde, BuchVereinfacht buch)
        {
            if (BuchInKatalogEnthalten(buch))
            {
                if (kunde.BuchZurueckgeben(buch))
                {
                    katalog[buch] += 1;
                    Console.WriteLine("Erfolgreich zurueckgegeben.");
                    Console.WriteLine($"Zurueckgegebener Buch: {buch.Titel}\n" +
                        $"Jetzt sind im Katalog {katalog[buch]} viele Kopien verfuegbar.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Kunde hat das Buch nicht.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Buch ist nicht in unser Katalog enthalten.");
                return false;
            }
        }

        /// <summary>
        /// Wir probieren einen Buch auszuleiehn zum Kunde.
        /// Wenn das Buch im Katalog enthalten ist und wenn der Kunde das Buch nicht hat 
        /// und er nicht schon 3 buecher ausgeliehen hat dann wird es ausgeliehen.
        /// </summary>
        /// <param name="kunde"></param>
        /// <param name="buch"></param>
        /// <returns></returns>
        public bool KundeBuch_Ausleiehen(BibKunde kunde, BuchVereinfacht buch)
        {
            if (BuchInKatalogEnthalten(buch))
            {
                if (kunde.BuchAusleihen(buch))
                {
                    katalog[buch] -= 1;
                    Console.WriteLine("Erfolgreich ausgeliehen.");
                    Console.WriteLine($"Ausgeliehener Buch: {buch.Titel}\n" +
                        $"Jetzt sind im Katalog {katalog[buch]} viele Kopien verfuegbar.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Kunde hat schon die maximale Anzahl an Buecher ausgeliehen.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Buch ist nicht in unser Katalog enthalten.");
                return false;
            }
        }

        /// <summary>
        /// Wir erstellen hiermit einen neuen Kunde.
        /// </summary>
        /// <param name="bibKunde"></param>
        /// <returns></returns>
        public bool KundeHinzufuegen(BibKunde bibKunde)
        {
            if (!IstKunde(bibKunde))
            {
                kunden.Add(bibKunde);
                Console.WriteLine("Kunde erfolgreich hinzugefuegt.");
                return true;
            }
            else
            {
                Console.WriteLine("Kunde existiert schon.");
                return false;
            }
        }

        /// <summary>
        /// Wir entfernen einen Kunden von unsere Liste.
        /// </summary>
        /// <param name="bibKunde"></param>
        /// <returns></returns>
        public bool KundeLoeschen(BibKunde bibKunde)
        {
            if (IstKunde(bibKunde))
            {
                kunden.Remove(bibKunde);
                Console.WriteLine("Kunde erfolgreich entfernt.");
                return true;
            }
            else
            {
                Console.WriteLine("Kunde existiert nicht.");
                return false;
            }
        }

        /// <summary>
        /// Buch einkaufen gehen.
        /// </summary>
        /// <param name="buch"></param>
        /// <param name="menge"></param>
        public void BuecherKaufen(BuchVereinfacht buch, int menge)
        {
            if (katalog.ContainsKey(buch))
            {
                katalog[buch] += menge;
            }
            else
            {
                katalog.Add(buch, menge);
            }
        }


        /// <summary>
        /// Buch aus unsere Bib entfernen.
        /// </summary>
        /// <param name="buch"></param>
        /// <returns></returns>
        public bool BuecherEntfernen(BuchVereinfacht buch)
        {
            if (katalog.ContainsKey(buch))
            {
                katalog.Remove(buch);
                Console.WriteLine("Buch erfolgreich entfernt.");
                return true;
            }
            else
            {
                Console.WriteLine("Buch nicht im Katalog enthalten.");
                return false;
            }
        }
    }
}
