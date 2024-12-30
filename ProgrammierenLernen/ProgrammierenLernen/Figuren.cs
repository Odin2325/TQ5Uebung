using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenLernen
{
    public interface IFiguren
    {
        int X { get; set; }
        int  Y{ get; set; }
        double Laenge { get; set; }
        double Hoehe { get; set; }
        double Oberflaeche();
        double Perimiter();
    }

    public class RDreieck : IFiguren
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Laenge { get; set; }
        public double Hoehe { get; set; }

        public double Oberflaeche()
        {
            return 0.5 * Laenge * Hoehe;
        }

        public double Perimiter()
        {
            double hypotenuse = Math.Sqrt(Laenge*Laenge + Hoehe*Hoehe);

            return hypotenuse + Laenge + Hoehe;
        }
    }
}
