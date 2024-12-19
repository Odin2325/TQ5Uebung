using Grundlagen.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Simple
{
    internal class MessageWorker
    {
        Outputs outputs;
        public MessageWorker()
        {
            outputs = new Outputs();
        }

        public string CallBack(string message)
        {
            string msg = message.ToUpper();
            return msg;
        }

        public string Login(string userName, string pass)
        {
            string answer = "Ein fehler ist aufgetreten...";
            string user = "admin1";
            string password = "adminPass1234";

            if (userName == user && pass == password)
            {
                answer = "Willkommen Administrator";
                return answer;
            }
            else
            {
                if (userName == user && pass != password)
                {
                    answer = "Ups, falsches Passwort";
                    return answer;
                }
                else if (userName != user)
                {
                    answer = "Kein Nutzer mit diesem Username bekannt.";
                    return answer;
                }
            }
            return answer;
        }

        public void WürfelGame()
        {
            Random random = new Random();
            bool finish = false;

            while (!finish)
            {
                // Würfel werfen
                int würfel1 = random.Next(1, 7);
                int würfel2 = random.Next(1, 7);
                int würfel3 = random.Next(1, 7);
                int summe = würfel1 + würfel2 + würfel3;

                // Bonuspunkte berechnen
                int bonusPunkte = 0;
                outputs.SuccessOutput("Game wird gestartet...");
                outputs.SuccessOutput("==============================================");
                if (würfel1 == würfel2 && würfel2 == würfel3)
                {
                    bonusPunkte = 5;
                    outputs.SuccessOutput("3er Pasch! +5 Bonuspunkte!");
                }
                else if (würfel1 == würfel2 || würfel1 == würfel3 || würfel2 == würfel3)
                {
                    bonusPunkte = 1;
                    outputs.SuccessOutput("2er Pasch! +1 Bonuspunkt!");
                }
                else
                {
                    outputs.NormalOutput("Kein Pasch. Keine Bonuspunkte.");
                }

                if (summe >= 16)
                {
                    outputs.SuccessOutput($"Gesamt-Bonuspunkte: {bonusPunkte}");
                    outputs.NormalOutput($"Es wurde gewürfelt:\nWürfel1: {würfel1}\nWürfel2: {würfel2}\nWürfel3: {würfel3}");
                    outputs.NormalOutput($"Gesamtsumme: {summe}");
                    outputs.SuccessOutput($"Du hast ein Dodge Charger gewonnen! Viel Spass mit deinem Preis!");
                }
                else if (summe >= 10)
                {
                    outputs.NormalOutput($"Es wurde gewürfelt:\nWürfel1: {würfel1}\nWürfel2: {würfel2}\nWürfel3: {würfel3}");
                    outputs.NormalOutput($"Gesamtsumme: {summe}");
                    outputs.SuccessOutput("Du hast einen Laptop gewonnen!");
                }
                else if (summe == 7)
                {
                    outputs.NormalOutput($"Es wurde gewürfelt:\nWürfel1: {würfel1}\nWürfel2: {würfel2}\nWürfel3: {würfel3}");
                    outputs.NormalOutput($"Gesamtsumme: {summe}");
                    outputs.SuccessOutput("Du hast ein One-Way-Ticket nach Jamaica gewonnen!");
                }
                else
                {
                    outputs.NormalOutput($"Es wurde gewürfelt:\nWürfel1: {würfel1}\nWürfel2: {würfel2}\nWürfel3: {würfel3}");
                    outputs.NormalOutput($"Gesamtsumme: {summe}");
                    outputs.SuccessOutput("Du hast verloren. Als bestrafung erhälst du eine Katze");
                }
                outputs.SuccessOutput("==============================================");
                outputs.SuccessOutput("Game beendet...\n");
                Console.WriteLine("Möchtest du noch eine Runde spielen? (Gebe JA oder NEIN ein)");

                string input = Console.ReadLine();
                if (input.Equals("nein", StringComparison.OrdinalIgnoreCase))
                {
                    finish = true;
                }
            }
        }

        public void ValidateInput()
        {
            outputs.NormalOutput("Bitte gebe eine Zahl zwischen 0 und 15 ein.");

            int versuche = 0;
            int zahl;
            bool validate;

            while (true)
            {
                validate = int.TryParse(Console.ReadLine(), out zahl);

                if (!validate)
                {
                    outputs.ErrorOutput("Bitte gebe eine Zahl ohne Kommastelle oder Buchstabe/Sonderzeichen ein.");
                    versuche++;
                    continue;
                }

                if (zahl >= 0 && zahl <= 15)
                {
                    outputs.SuccessOutput($"Du hast die {zahl} als gültige Zahl eingegeben.\nDu brauchtest {versuche + 1} Versuche.");
                    break;
                }
                else
                {
                    outputs.ErrorOutput("Die Zahl liegt nicht im Bereich von 0 bis 15.");
                    versuche++;
                }
            }
        }

        public void RepeatInput()
        {
            outputs.NormalOutput("Bitte gebe ein Zeichen oder einen Text ein:");
            string input = Console.ReadLine();

            outputs.NormalOutput("Wie oft soll es wiederholt werden?");
            if (!int.TryParse(Console.ReadLine(), out int height) || height <= 0)
            {
                outputs.ErrorOutput("Bitte gebe eine gültige Zahl größer als 0 ein.");
                return;
            }

            for (int i = 1; i <= height; i++)
            {
                string spaces = new string(' ', (height - i) * 2);

                string layer = string.Join("   ", Enumerable.Repeat(input, i));

                outputs.NormalOutput(spaces + layer);
            }
        }

        public void NameChecker()
        {
            outputs.NormalOutput("Bitte gebe deinen Namen ein...");
            string name = Console.ReadLine();

            if (!string.IsNullOrEmpty(name))
            {
                outputs.SuccessOutput($"Eins für {name} und eins für mich.");
            }
            else
            {
                outputs.SuccessOutput("Eins für dich, eins für mich.");
            }
        }
    }
}
