using Grundlagen.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Fortgeschritten
{
    internal class Switches
    {
        Outputs outputs;

        public string choosenWährung = "";
        public Switches() 
        { 
            outputs = new Outputs();
        }

        public decimal Währungsrechner()
        {
            outputs.NormalOutput("Bitte gebe in € an wieviel zu umrechnen willst.");
            if (!decimal.TryParse(Console.ReadLine(), out decimal euroBetrag))
            {
                return 0;
            }

            outputs.NormalOutput("Bitte gebe die Zielwährung an.\nYen\nINR\nGBP\nUSD");
            string währung = Console.ReadLine().ToUpper();

            decimal wechselkurs;
            switch (währung)
            {
                case "YEN":
                    wechselkurs = 159.14558m;
                    choosenWährung = "YEN";
                    break;
                case "INR":
                    wechselkurs = 89.655121m;
                    choosenWährung = "INR";
                    break;
                case "GBP":
                    wechselkurs = 0.82812935m;
                    choosenWährung = "GBP";
                    break;
                case "USD":
                    wechselkurs = 1.0581981m;
                    choosenWährung = "USD";
                    break;
                default:
                    outputs.ErrorOutput("Ungültige Währung. Die verfügbaren Währungen sind: YEN, INR, GBP, USD.");
                    return 0;
            }

            decimal neueGeldmenge = euroBetrag * wechselkurs;
            return neueGeldmenge;
        }
    }
}
