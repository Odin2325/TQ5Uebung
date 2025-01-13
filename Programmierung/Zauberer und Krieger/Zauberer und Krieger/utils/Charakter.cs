using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zauberer_und_Krieger.utils
{
    internal class Charakter
    {
        public int Vita { get; set; } = 100;
        public int Angriff { get; set; }
        public bool Vulnerable { get; set; }
        private Nachichten nachichten = new Nachichten();

        public virtual void SchadenBerechnen(Charakter ziel)
        {
            // Standard-Schadenberechnung, kann in den abgeleiteten Klassen überschrieben werden
        }

        public virtual void RundeBeenden()
        {

        }
    }
}
