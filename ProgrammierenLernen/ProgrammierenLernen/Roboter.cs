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
        private List<string> mappings = new List<string>();
        private int muellEimerStand = 0;

        public Roomba(string modell) : base("Roomba",modell)
        {

        }

        public override void GerauescheMachen()
        {
            Console.WriteLine("Meep meep!");
        }

        public bool Putzen(int indexVonZimmer)
        {

            if (indexVonZimmer >= mappings.Count)
            {
                Console.WriteLine("Ungueltiger Zimmer index. " +
                    "Waehlen Sie bitte einen anderen Zimmer aus, " +
                    "oder mach einen Mapping von diesen neuen Zimmer zuerst.");
            }
            else if (muellEimerStand < 100)
            {
                Console.WriteLine($"Dein Zimmer: {mappings[indexVonZimmer]} wird geputzt.");
                muellEimerStand += 10;
                return true;
            }
            else
            {
                Console.WriteLine("Muelleimer ist voll. Bitte leeren.");
            }
            return false;
        }

        //     0          1      2       3       4        5
        //|fernsehraum|zimmer1|kueche|zimmer2|zimmer3|badezimmer|
        //Was ist der Count von diese Liste?
        //6
        public void MappingErstellen(string zimmer)
        {
            Console.WriteLine("Wir mappen dein zimmer: " + zimmer);
            mappings.Add(zimmer);
            Console.WriteLine($"Index von {zimmer} ist {mappings.Count - 1}");
        }

        public void MappingsAusgeben()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Mappings werden Ausgegeben:");
            for (int i = 0; i < mappings.Count; i++)
            {
                Console.WriteLine($"Zimmer: {mappings[i]} - Index: {i}");
            }
            Console.WriteLine("=====================================");
        }

        public bool MuellEntsorgen()
        {
            Console.WriteLine("Wir leeren das Muelleimer von unser Roomba.");
            muellEimerStand = 0;
            return true;
        }

    }




    public class PolizeiRoboter : Roboter
    {
        private List<Person> bekannteKriminelle = new List<Person>();
        private string einsatzAdresse;

        public PolizeiRoboter(string einsatzAdresse) : base("SkyNet", "T-100")
        {
            this.einsatzAdresse = einsatzAdresse;
        }

        public override void GerauescheMachen()
        {
            Console.WriteLine("NEEENAAAANEEENAAA!");
            Console.WriteLine("Stop in the name of love!");
        }

        public void PersonVergleichen(Person person)
        {
            foreach(var kriminellen in bekannteKriminelle)
            {
                if(kriminellen.name == person.name && kriminellen.adresse == person.adresse && kriminellen.krimineller == person.krimineller)
                {
                    Console.WriteLine("Wir rufen die Polizei an!");
                    GerauescheMachen();
                    return;
                }
            }
            Console.WriteLine("Sie duerfen rein.");
        }

        public void KriminellenHinzufuegen(Person person)
        {
            bekannteKriminelle.Add(person);
            Console.WriteLine("Du bist zu die Naughty liste hinzugefuegt worden.");
        }
        public void KriminellenEntfernen(Person person)
        {
            bekannteKriminelle.Remove(person);
            Console.WriteLine("Du bist wieder in die Nice liste.");
        }




    }
}
