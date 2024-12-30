using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{
    public abstract class Fahrzeug
    {
        protected string hersteller;
        protected string modell;
        protected string farbe;
        protected double maxGeschwindigkeit;
        protected double aktuelleGeschwindigkeit = 0;

        public Fahrzeug(string hersteller, string modell, string farbe, double maxGeschwindigkeit)
        {
            if (string.IsNullOrEmpty(hersteller) || string.IsNullOrEmpty(modell))
                throw new ArgumentNullException("Hersteller oder Modell fehlt!");
            this.hersteller = hersteller;
            this.modell = modell;
            this.farbe = farbe;
            this.maxGeschwindigkeit = maxGeschwindigkeit;
        }

        internal void Beschleunigen(double geschwindigkeit)
        {
            if (geschwindigkeit + aktuelleGeschwindigkeit > maxGeschwindigkeit)
                Console.WriteLine("Maximale Geschwindigkeit überschritten!.");
            else
                aktuelleGeschwindigkeit += geschwindigkeit;
            Console.WriteLine($"Aktuelle Geschwindigkeit: {aktuelleGeschwindigkeit}.");
        }

        public virtual void Honk()
        {
            Console.WriteLine("MEEP MEEP!");
        }

        internal void Bremsen()
        {
            if (aktuelleGeschwindigkeit <= 0)
                Console.WriteLine("Langsamer als 0 geht nicht!");
            else
                Console.WriteLine("Auto steht.");
        }
        // public abstract void Honk(); -> abstrakte Klasse
    }

    public class LKW: Fahrzeug
    {
        private double ladekapazität;
        private double aktuelleLadung = 0;

        public double AktuelleGeschwindigkeit
        {
            get => aktuelleGeschwindigkeit;
            set { if (aktuelleGeschwindigkeit + value < maxGeschwindigkeit) aktuelleGeschwindigkeit += value; }
        }
        public double AktuelleLadung
        {
            get => AktuelleLadung;
            set { if (AktuelleLadung + value < ladekapazität) AktuelleLadung += value; }
        }

        public LKW(string hersteller, string modell, string farbe, double maxGeschwindigkeit, double ladekapazität): base(hersteller, modell, farbe, maxGeschwindigkeit)
        {
            this.ladekapazität = ladekapazität;
        }

        public override void Honk()
        {
            Console.WriteLine("MOOOOVE!");
        }

    }
}
