using Grundlagen.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Fortgeschritten
{
    internal class CalculateTwo
    {
        private Outputs outputs;

        public CalculateTwo() 
        { 
            outputs = new Outputs();
        }

        private readonly double MERKUR_UMLAUFZEIT = 0.2408467;
        private readonly double VENUS_UMLAUFZEIT = 0.61519726;
        private readonly double ERDE_UMLAUFZEIT = 1.0;
        private readonly double MARS_UMLAUFZEIT = 1.8808158;
        private readonly double JUPITER_UMLAUFZEIT = 11.862615;
        private readonly double SATURN_UMLAUFZEIT = 29.447498;
        private readonly double URANUS_UMLAUFZEIT = 84.016846;
        private readonly double NEPTUN_UMLAUFZEIT = 164.79132;

        private readonly double SEKUNDEN_PRO_ERDJAHR = 31557600.0;
        public void TerraAlter()
        {
            outputs.NormalOutput("Bitte gebe die Menge an Sekunden an die du umrechnen möchtest...");
            Console.ForegroundColor = ConsoleColor.Blue;
            double.TryParse(Console.ReadLine(), out double sekunden);
            Console.ResetColor();

            outputs.NormalOutput($"Alter in Sekunden: {sekunden}");
            outputs.SuccessOutput($"Auf der Erde: {BerechneAlter(sekunden, ERDE_UMLAUFZEIT):F2} Jahre");
            outputs.SuccessOutput($"Auf Merkur: {BerechneAlter(sekunden, MERKUR_UMLAUFZEIT):F2} Jahre");
            outputs.SuccessOutput($"Auf Venus: {BerechneAlter(sekunden, VENUS_UMLAUFZEIT):F2} Jahre");
            outputs.SuccessOutput($"Auf Mars: {BerechneAlter(sekunden, MARS_UMLAUFZEIT):F2} Jahre");
            outputs.SuccessOutput($"Auf Jupiter: {BerechneAlter(sekunden, JUPITER_UMLAUFZEIT):F2} Jahre");
            outputs.SuccessOutput($"Auf Saturn: {BerechneAlter(sekunden, SATURN_UMLAUFZEIT):F2} Jahre");
            outputs.SuccessOutput($"Auf Uranus: {BerechneAlter(sekunden, URANUS_UMLAUFZEIT):F2} Jahre");
            outputs.SuccessOutput($"Auf Neptun: {BerechneAlter(sekunden, NEPTUN_UMLAUFZEIT):F2} Jahre");
        }

        private double BerechneAlter(double sekunden, double planetenUmlaufzeit)
        {
            return sekunden / (SEKUNDEN_PRO_ERDJAHR * planetenUmlaufzeit);
        }

        public bool BerechneSchaltjahr(int jahr)
        {
            if (jahr % 4 == 0)
            {
                if (jahr % 100 == 0)
                {
                    return jahr % 400 == 0;
                }
                return true;
            }
            return false;
        }
    }
}
