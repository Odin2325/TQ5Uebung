using Grundlagen.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Aufgaben
{
    internal class LKW
    {
        private bool motorLäuft = false;
        private int maxKMH = 120;
        private int currentKMH = 0;
        private bool hupe = false;
        private bool parken = true;
        private int maxLadung = 300;
        private int currentLadung = 0;
        private bool amLaden = false;

        private Outputs outputs;

        public LKW()
        {
            outputs = new Outputs();
        }

        public void ManageMotor()
        {
            outputs.NormalOutput(motorLäuft ? "Schalte Motor ab..." : "Starte Motor...");
            motorLäuft = !motorLäuft;
            outputs.SuccessOutput(motorLäuft ? "Motor gestartet!" : "Motor abgeschalten.");
        }

        public void Fahren()
        {
            if (!motorLäuft)
            {
                outputs.ErrorOutput("Du musst erst den Motor starten..!");
                return;
            }

            int increment = 5;

            outputs.NormalOutput("Fahrt beginnt...");

            while (currentKMH < maxKMH)
            {
                if (Brake())
                {
                    currentKMH -= increment;
                    if (currentKMH < 0)
                    {
                        currentKMH = 0;
                    }
                    outputs.NormalOutput($"Bremsen: Geschwindigkeit reduziert auf {currentKMH} km/h");

                    if (currentKMH == 0)
                    {
                        outputs.SuccessOutput("Erfolgreich angehalten!");
                        parken = true;
                        outputs.SuccessOutput("Du parkst nun...achte darauf dies nur im sicheren Gelände zu machen!");

                        if (parken)
                        {
                            outputs.NormalOutput("Möchtest du dein LKW beladen oder entladen? (B/E)");
                            string userInput = Console.ReadLine()?.ToUpper();

                            if (userInput == "B")
                            {
                                outputs.NormalOutput("Starte Beladung...");
                                ManageLadung(ref currentLadung, maxLadung, true);
                            }
                            else if (userInput == "E")
                            {
                                outputs.NormalOutput("Starte Entladung...");
                                ManageLadung(ref currentLadung, maxLadung, false);
                            }
                        }
                    }
                }
                else
                {
                    currentKMH += increment;
                    if (currentKMH > maxKMH)
                    {
                        currentKMH = maxKMH;
                    }
                    outputs.NormalOutput($"Geschwindigkeit: {currentKMH} km/h");

                    if (currentKMH == maxKMH)
                    {
                        outputs.SuccessOutput("Maximale Geschwindigkeit erreicht!");
                    }
                }

                System.Threading.Thread.Sleep(100);
            }
        }

        private bool Brake()
        {
            outputs.NormalOutput("Drücke 'B', um zu bremsen...");
            string input = Console.ReadLine();

            return input?.ToUpper() == "B";
        }

        private bool ManageLadung(ref int currentLadung, int maxLadung, bool laden)
        {
            int increment = 20;
            amLaden = true;

            if (laden)
            {
                outputs.NormalOutput("Ladevorgang gestartet...");
            }
            else
            {
                outputs.NormalOutput("Entladung gestartet...");
            }

            while (amLaden)
            {
                if (laden)
                {
                    currentLadung += increment;
                    if (currentLadung >= maxLadung)
                    {
                        currentLadung = maxLadung;
                        amLaden = false; // Laden abgeschlossen
                    }
                }
                else
                {
                    currentLadung -= increment;
                    if (currentLadung <= 0)
                    {
                        currentLadung = 0;
                        amLaden = false; // Entladung abgeschlossen
                    }
                }

                outputs.NormalOutput($"Aktuelle Ladung: {currentLadung}%");
                System.Threading.Thread.Sleep(100);
            }

            outputs.SuccessOutput(laden ? "Ladevorgang abgeschlossen!" : "Entladung abgeschlossen!");
            return amLaden;
        }
    }
}
