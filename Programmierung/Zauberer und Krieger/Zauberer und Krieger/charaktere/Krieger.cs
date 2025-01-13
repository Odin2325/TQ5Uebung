using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zauberer_und_Krieger.utils;

namespace Zauberer_und_Krieger.charaktere
{
    internal class Krieger : Charakter
    {
        int ausweichRunden = 1; // Runden ohne Schaden
        private Nachichten nachichten;

        public Krieger()
        {
            nachichten = new Nachichten();
            Angriff = 6; // Standard-Angriff für den Krieger
        }

        public override void SchadenBerechnen(Charakter ziel)
        {
            if (ziel.Vulnerable)
            {
                nachichten.KriegerNachichten("Krieger greift an und verursacht 10 Schaden!");
                ziel.Vita -= 10;
            }
            else
            {
                nachichten.KriegerNachichten("Krieger greift an und verursacht 6 Schaden!");
                ziel.Vita -= 6;
            }
        }

        public void Ausweichen()
        {
            // Krieger kann ausweichen und den Schaden in der nächsten Runde verhindern
            nachichten.KriegerNachichten("Krieger weicht aus und erleidet in der nächsten Runde keinen Schaden.");
            Vulnerable = false;
        }

        public override void RundeBeenden()
        {
            if (ausweichRunden == 0)
            {
                Vulnerable = true;
                nachichten.EndRound();
            }
            else
            {
                ausweichRunden--;
                nachichten.EndRound();
            }
        }
    }
}
