using System.Numerics;
using System.Reflection;
using System.Text;

namespace ProgrammierenLernen
{
    /*
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
     * Punkt, Viereck, rechtwinkliges Dreieck, Linie
     */

    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Punkt x:{x}, y:{y}");
        }
    }

    internal class Program
    {
        //enum
        //struct
        public static void TierDetails(IAnimal animal)
        {
            Console.WriteLine($"Tierart: {animal.Name}");
            animal.Geraeusch();
            animal.Essen("Fisch");
        }

        public enum Richtungen
        {
            Forwaerts,
            Rueckwaerts,
            Rechts,
            Links
        }

        static void Main(string[] args)
        {
            
        }

    }

}
