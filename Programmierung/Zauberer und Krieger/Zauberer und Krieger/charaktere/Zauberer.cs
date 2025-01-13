using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zauberer_und_Krieger.utils;

namespace Zauberer_und_Krieger.charaktere
{
    internal class Zauberer : Charakter
    {
        public int ZaubertrankRunden { get; set; } = 0;
        public int ZaubertrankCooldown { get; set; } = 0;

        private Nachichten nachichten;

        public Zauberer()
        {
            nachichten = new Nachichten();
            Angriff = 3; // Standard-Angriff für den Zauberer
        }

        public void ZaubertrankBrauen()
        {
            if (ZaubertrankCooldown == 0)
            {
                ZaubertrankRunden = 3;
                ZaubertrankCooldown = 2; // Cooldown von 2 Runden nach dem Brauen
                nachichten.ZaubererNachichten("Zauberer braut einen Zaubertrank! Er macht für die nächsten 3 Runden mehr Schaden.");
                Vulnerable = true;
            }
            else
            {
                nachichten.ZaubererNachichten($"Zaubertrank ist noch auf Cooldown! ({ZaubertrankCooldown} Runden)");
            }
        }

        public override void SchadenBerechnen(Charakter ziel)
        {
            if (ziel.Vulnerable)
            {
                if (ZaubertrankRunden > 0)
                {
                    nachichten.ZaubererNachichten("Zauberer greift mit Zaubertrank an und verursacht 12 Schaden!");
                    ziel.Vita -= 12;
                    ZaubertrankRunden--; // Reduziert die Zaubertrank-Runden
                }
                else
                {
                    nachichten.ZaubererNachichten("Zauberer greift an und verursacht 3 Schaden.");
                    ziel.Vita -= 3;
                }
            }
            else
            {
                nachichten.ZaubererNachichten($"Krieger erhält in dieser runde keinen schaden");
            }
        }

        public void ZaubertrankCooldownReduzieren()
        {
            if (ZaubertrankCooldown > 0)
            {
                ZaubertrankCooldown--; // Reduziert den Cooldown um 1

                if (ZaubertrankCooldown == 0)
                {
                    Vulnerable = false;
                }
            }
        }
    }
}
