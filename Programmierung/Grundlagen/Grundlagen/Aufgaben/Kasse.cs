using Grundlagen.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Aufgaben
{
    internal class Kasse
    {
        private Outputs outputs;

        // Tuple-Array für Geld und Mengen
        private (int Schein, int Menge)[] geldBestaende;

        public Kasse()
        {
            outputs = new Outputs();

            // Ininitialisierung von Schein und Menge
            geldBestaende = new (int, int)[]
            {
            (5, 20), (10, 15), (20, 10), (50, 5), (100, 5)
            };
        }

        // Summe berechnen von Scheinen in der Kasse
        public int BerechneSumme()
        {
            return geldBestaende.Sum(scheine => scheine.Schein * scheine.Menge);
        }

        // Geld einzahlen
        public void GeldEinzahlen(int wert, int menge)
        {
            for (int i = 0; i < geldBestaende.Length; i++)
            {
                if (geldBestaende[i].Schein == wert)
                {
                    geldBestaende[i].Menge += menge;
                    outputs.SuccessOutput($"{menge} x {wert}-Euro hinzugefügt.");
                    return;
                }
            }
            outputs.ErrorOutput("Ungültiger Wert eingezahlt.");
        }

        // Geld auszahlen
        public bool GeldAuszahlen(int betrag)
        {
            if (betrag > BerechneSumme())
            {
                outputs.ErrorOutput("Nicht genügend Geld in der Kasse.");
                return false;
            }

            var auszuzahlen = betrag;
            for (int i = geldBestaende.Length - 1; i >= 0; i--)
            {
                int anzahlMünzen = Math.Min(auszuzahlen / geldBestaende[i].Schein, geldBestaende[i].Menge);
                auszuzahlen -= anzahlMünzen * geldBestaende[i].Schein;
                geldBestaende[i].Menge -= anzahlMünzen;
            }

            if (auszuzahlen == 0)
            {
                outputs.SuccessOutput($"{betrag}-Euro erfolgreich ausgezahlt.");
                return true;
            }

            outputs.ErrorOutput("Der Betrag konnte nicht ausgezahlt werden.");
            return false;
        }

        // Kassenstand ausgabe
        public void KassenstandAusgeben()
        {
            outputs.NormalOutput("Aktueller Kassenstand:");
            foreach (var geld in geldBestaende)
            {
                outputs.NormalOutput($"{geld.Schein}-Euro: {geld.Menge} Stück");
            }
            outputs.SuccessOutput($"Gesamtsumme: {BerechneSumme()} Euro");
        }

        // Methode zum Drucken einer Rechnung
        public void RechnungDrucken(int betrag)
        {
            outputs.SuccessOutput($"Rechnung:\n-----------------\nBetrag: {betrag} Euro\nVielen Dank für Ihren Einkauf!");
        }
    }
}