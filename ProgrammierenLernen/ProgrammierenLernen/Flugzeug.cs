namespace ProgrammierenLernen
{
    public class Flugzeug
    {
        private string hersteller;
        private string modell;
        private int sitzplaetze;
        private double maxGeschwindigkeit;
        private double flugHoehe = 0;
        private double maxflugHoehe = 3800;
        private double aktuelleGeschwindigkeit = 0;
        private bool flapsAktiv = false;
        private bool motorGestartet = false;

        /*
         * Variablen => Konstruktor => Get/Set => Methoden
         * Uebung2: Erweitert die Klasse Auto um mind. 6 Methoden.
         * Konstruktor auch definieren.
         * Beispielsweise: schnellerFahren, bremsen, lichtAn, lichtAus, tuerOffenAlarm, autoDetailsAusgeben.
         */
        
        public Flugzeug(string hersteller, string modell, int sitzplaetze, double maxGeschwindigkeit)
        {
            if (string.IsNullOrEmpty(hersteller) || string.IsNullOrEmpty(modell))
            {
                throw new ArgumentNullException("Hersteller oder Modell fehlt!");
            }
            this.modell = modell;
            this.hersteller = hersteller;
            this.sitzplaetze = sitzplaetze;
            this.maxGeschwindigkeit = maxGeschwindigkeit;
        }

        //private=> nur innerhalb der Klasse sichtbar
        //protected=> nur innerhalb der Klasse und abgeleiteten Klassen sichtbar
        //internal=> nur innerhalb des Assemblies sichtbar
        //public=> ueberall sichtbar
        public string Hersteller
        {
            get
            {
                return hersteller;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Hersteller darf nicht null sein.");
                }
                else if (value.Length < 2)
                {
                    throw new ArgumentException("Hersteller muss mindestens 2 Zeichen lang sein.");
                }
                hersteller = value;
            }
        }

        //flapsAnOderAus()
        //steigen()
        //sinken()
        //tuerOeffnen()


        internal void SchnellerFahren(double gewuenschteGeschwindigkeit)
        {
            if (motorGestartet)
            {
                if (gewuenschteGeschwindigkeit > maxGeschwindigkeit)
                {
                    Console.WriteLine("Gewuenschte Geschwingikeit zu hoch. Wird auf Max Geschwindigkeit reduziert.");
                    gewuenschteGeschwindigkeit = maxGeschwindigkeit;
                }
                while (aktuelleGeschwindigkeit<gewuenschteGeschwindigkeit)
                {
                    aktuelleGeschwindigkeit += 10;
                    Console.WriteLine($"Aktuelle Geschwindigkeit: {aktuelleGeschwindigkeit}");
                }
                Console.WriteLine("Gewuenschte Geschwindigkeit erreicht.");
            }
            else
            {
                Console.WriteLine("Motor nicht aktiv.");
            }
        }
        internal void Bremsen(double gewuenschteGeschwindigkeit)
        {
            if (gewuenschteGeschwindigkeit < 0)
            {
                Console.WriteLine("Gewuenschte Geschwingikeit zu klein. Wird auf 0 erhoeht.");
                gewuenschteGeschwindigkeit = 0;
            }
            while (aktuelleGeschwindigkeit > gewuenschteGeschwindigkeit)
            {
                aktuelleGeschwindigkeit -= 10;
                Console.WriteLine($"Aktuelle Geschwindigkeit: {aktuelleGeschwindigkeit}");
            }
            Console.WriteLine("Gewuenschte Geschwindigkeit erreicht.");
        }
        internal void Starten()
        {
            if (motorGestartet)
            {
                Console.WriteLine("Motor ist schon gestarten worden.");
            }
            else
            {
                Console.WriteLine("Motor wird gestartet");
                motorGestartet = true;
            }
        }

        internal void Parken()
        {
            if(aktuelleGeschwindigkeit == 0)
            {
                Console.WriteLine("Wir sind gestoppt. Motor wird ausgeschaltet.");
                motorGestartet = false;
            }
            else
            {
                Console.WriteLine("Wir sind noch in Bewegung und koennen nicht parken.");
            }
        }
    }



}
