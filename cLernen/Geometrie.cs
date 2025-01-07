using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{/*
 * Wir moechten einen Einfachen interface erstellen.
 * Dies soll ein interface fuer verschieden Figuren und wie die auf den Bildschirm angezeigt werden.
 * Wir muessen in diesen interface einen x, y coordinat definieren als Property.
 * Es soll ein getter und setter haben.
 * 
 * Wir muessen auch einen Property fuer die Dimensionen von die Figuren haben.
 * 
 * Wir brauechten eine Methode fuer den Oberflaeche, und eine Methode um den Perimeter zu berechnen.
 * 
 * Die moeglichen figuren sind:
 * Punkt, Viereck, Rechteck, Linie
 */
    public interface IGeometrie
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Länge { get; set; }
        void Oberfläche();
        void Umfang();
    }

    public class Viereck: IGeometrie
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Länge { get; set; }
        public void Oberfläche()
        {
            Console.WriteLine(Länge * Länge);
        }
        public void Umfang()
        {
            Console.WriteLine(Länge * 4);
        }
    }
}
