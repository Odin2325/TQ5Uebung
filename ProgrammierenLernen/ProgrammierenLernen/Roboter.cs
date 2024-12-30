using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenLernen
{
    //Italics => abstrakte Klasse
    public abstract class Roboter
    {
        //# => Protected: Zugriff von abgeleiteten Klassen
        //+ => Public: Zugriff von außen
        //- => Private: Zugriff nur innerhalb der Klasse
        protected string hersteller;
        protected string modell;
        protected string id;

        public Roboter(string hersteller, string modell)
        {
            this.hersteller = hersteller;
            this.modell = modell;
            this.id = Guid.NewGuid().ToString();
        }

        //Abstrakte Methode daher in Klassendiagramm mit Italics
        public abstract void GerauescheMachen();

        public void Start()
        {
            Console.WriteLine("Der Roboter startet.");
        }

        public void Stop()
        {
            Console.WriteLine("Der Roboter stoppt.");
        }
    }

    public class Roomba : Roboter
    {

    }


}
