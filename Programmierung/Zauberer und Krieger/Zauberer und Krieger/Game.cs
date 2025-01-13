using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zauberer_und_Krieger.charaktere;
using Zauberer_und_Krieger.utils;

namespace Zauberer_und_Krieger
{
    internal class Game
    {
        private Nachichten nachichten;
        public Game() 
        { 
            nachichten = new Nachichten();
        }

        public void StartGame()
        {
            nachichten.SystemNachichten("Hallo, Wähle dein Charakter:");
            nachichten.KriegerNachichten("1. Krieger ");
            nachichten.ZaubererNachichten("2. Zauberer");

            bool validateCharakter = true;
            bool validateChoose = int.TryParse(Console.ReadLine(), out int choosen);

            while (validateCharakter)
            {
                if (!validateChoose)
                {
                    nachichten.SystemNachichten("Das habe ich nicht verstanden, versuchs nochmal und gebe nur eine Zahl ein!");
                    validateChoose = int.TryParse(Console.ReadLine(), out choosen);
                }
                else
                {
                    if (choosen == 1)
                    {
                        nachichten.SystemNachichten("Du hast den Krieger gewählt.");

                        Krieger krieger = new Krieger();
                        Zauberer zauberer = new Zauberer();
                        Kampf(krieger, zauberer);

                        break;
                    }
                    else if (choosen == 2)
                    {
                        nachichten.SystemNachichten("Du hast den Zauberer gewählt.");

                        Zauberer zauberer = new Zauberer();
                        Krieger krieger = new Krieger();
                        Kampf(zauberer, krieger);

                        break;
                    }
                    else
                    {
                        nachichten.SystemNachichten("Ungültige Auswahl, bitte gib 1 für Krieger oder 2 für Zauberer ein.");
                        validateChoose = false;
                    }
                }
            }
        }

        private void Kampf(Charakter spieler, Charakter gegner)
        {
            bool fight = true;
            int roundNumber = 1;

            while (fight)
            {
                nachichten.InfoNachichten($"\nSpieler: {spieler.GetType().Name} - Vita: {spieler.Vita} | Gegner: {gegner.GetType().Name} - Vita: {gegner.Vita}");
                nachichten.NextRound(roundNumber);
                nachichten.SystemNachichten("Was möchtest du tun?");

                if (spieler.GetType().Name == "Krieger")
                {
                    nachichten.KriegerNachichten("1. Angreifen");
                    nachichten.KriegerNachichten("2. Ausweichen");
                }
                else if (spieler.GetType().Name == "Zauberer")
                {
                    nachichten.ZaubererNachichten("1. Angreifen");
                    nachichten.ZaubererNachichten("3. Zaubertrank brauen");
                }

                int auswahl = int.Parse(Console.ReadLine());
                switch (auswahl)
                {
                    case 1:
                        spieler.SchadenBerechnen(gegner);
                        break;
                    case 2 when spieler is Krieger krieger:
                        krieger.Ausweichen();
                        break;
                    case 3 when spieler is Zauberer zauberer:
                        zauberer.ZaubertrankBrauen();
                        break;
                    default:
                        nachichten.SystemNachichten("Ungültige Auswahl.");
                        continue;
                }

                // Gegner handelt nach Zufall
                Random zufall = new Random();
                int gegnerAktion = zufall.Next(1, 3);  // Wählt zufällig eine Aktion

                // Überprüfen des Gegnertyps und ausführen der passenden Aktion
                if (gegner is Krieger kriegerGegner)
                {
                    // Der Krieger kann nur Schaden anrichten oder ausweichen
                    switch (gegnerAktion)
                    {
                        case 1:
                            kriegerGegner.SchadenBerechnen(spieler);  // Krieger greift an
                            break;
                        case 2:
                            kriegerGegner.Ausweichen();  // Krieger weicht aus
                            break;
                    }
                }
                else if (gegner is Zauberer zauberer)
                {
                    // Der Zauberer kann nur Schaden anrichten oder einen Zaubertrank brauen
                    switch (gegnerAktion)
                    {
                        case 1:
                            zauberer.SchadenBerechnen(spieler);  // Zauberer greift an
                            break;
                        case 2:
                            zauberer.ZaubertrankBrauen();  // Zauberer braut einen Zaubertrank
                            break;
                    }
                }

                // Zaubertrank Cooldown für Zauberer
                if (spieler is Zauberer zaubererSpieler)
                {
                    zaubererSpieler.ZaubertrankCooldownReduzieren();
                }

                // Runde beenden
                spieler.RundeBeenden();
                gegner.RundeBeenden();

                roundNumber++;

                // Überprüfen, ob der Kampf vorbei ist
                if (spieler.Vita <= 0 || gegner.Vita <= 0)
                {
                    fight = false;
                    nachichten.InfoNachichten(spieler.Vita <= 0 ? "Der Gegner hat gewonnen!" : "Du hast gewonnen!");
                }
            }
        }
    }
}
