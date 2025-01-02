using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedingungTest
{
    internal class Auto
    {


        internal string farbe;
        internal string hersteller;
        internal string modell;
        internal int maxGeschwindigkeit;
        internal bool hat4WD;
        internal int baujahr;
        internal string kraftstoffart;
        internal int sitzanzahl;
           
        internal Auto(string farbe, string hersteller, string modell, int maxGeschwindigkeit, bool hat4WD, int baujahr, string kraftstoffart, int sitzanzahl)
        {
            this.farbe = farbe;
            this.hersteller = hersteller;
            this.modell = modell;
            this.maxGeschwindigkeit = maxGeschwindigkeit;
            this.hat4WD = hat4WD;
            this.baujahr = baujahr;
            this.kraftstoffart = kraftstoffart;
            this.sitzanzahl = sitzanzahl;
        }
    }
}
