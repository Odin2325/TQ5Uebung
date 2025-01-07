using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{
    public abstract class Roboter
    {
        public int Ladekapazität {get; set;}
        public bool aktiv = false;
        public string seriennummer = SeriennummerErstellen();

        static string SeriennummerErstellen()
        {
            string nummer = "";
            Random rnd = new Random();
            for (int i = 0; i < 11; i++)
                nummer += rnd.Next(0, 10);
            return nummer;
        }

        public virtual bool KannArbeiten()
        {
            if (!aktiv)
                { Console.WriteLine("Roboter ist nicht eingeschaltet!");
                return false;
            }
            else if (Ladekapazität <= 0)
                { Console.WriteLine("Akku leer, bitte laden!");
                return false;
            }
            return true;
        } 
        public virtual void PowerButton()
        {
            aktiv = !aktiv;
            Console.WriteLine("Roboter ist jetzt eingeschaltet!");
        }

        public virtual void Laden()
        {
            if (Ladekapazität >= 100)
                Console.WriteLine("Akku vollständig geladen.");
            else
                do
                {
                    Ladekapazität += 10;
                    Thread.Sleep(500);
                    Console.WriteLine($"Ladekapazität: {Ladekapazität}.");
                } while (Ladekapazität < 100);
        }
    }

    public class Roomba: Roboter
    {
        private Dictionary<string, List<int>> RaumMapping = new();
        private int müllKapazität = 0;

    public void MappingErstellen(string raum)
        {
            if (KannArbeiten())
            {
                List<int> mapping = new();
                Ladekapazität -= 30;
                RaumMapping.Add(raum, mapping);
                Console.WriteLine($"Mapping von {raum} erstellt. Ladekapazität:{Ladekapazität}.");
            }
        }
    public void MüllSammeln()
        {
           if (KannArbeiten())
           { 
              if (müllKapazität >= 100)
                    Console.WriteLine("Container voll. Bitte entleeren.");
              else
                    Console.WriteLine("Müll wird gesammelt.");
                    while (müllKapazität < 100 && Ladekapazität > 0)
                    {
                        müllKapazität += 10;
                        Ladekapazität -= 5;
                        Thread.Sleep(500);
                        Console.WriteLine($"Müll: {müllKapazität}, Akku: {Ladekapazität}.");
                    }
           }
        }
    public void MüllEntsorgen()
        {
            if (KannArbeiten())
            {
                if (müllKapazität <= 0)
                    Console.WriteLine("Container leer.");
                else
                    Console.WriteLine("Müll wird ausgeleert.");
                    while (müllKapazität > 0 && Ladekapazität > 0)
                    {
                        müllKapazität -= 10;
                        Ladekapazität -= 5;
                        Thread.Sleep(500);
                        Console.WriteLine($"Müll: {müllKapazität}, Akku: {Ladekapazität}.");
                    }
            }
         }
    }

    public class Polizeiroboter: Roboter
    {
        protected List<Person> bekannteKriminelle = new();

    static void PolizeiKontaktieren()
        {
            Console.WriteLine("Polizei wird angefordert.");
        }
    internal void KriminellenHinzufügen(Person person)
        {
            bekannteKriminelle.Add(person);
            Console.WriteLine($"Kriminelle Person {person.name} wurde der Liste hinzugefügt.");
        }
    internal void KriminellenEntfernen(Person person)
        {
            bekannteKriminelle.Remove(person);
            Console.WriteLine($"Rehabilitierte Person {person.name} wurde von der Liste entfernt.");
        }
        internal void KriminellenIdentifizieren(Person person)
        {
            if (KannArbeiten())
            {
                if (person.kriminell)
                {
                    if (!bekannteKriminelle.Contains(person))
                        KriminellenHinzufügen(person);
                    PolizeiKontaktieren();
                }
                else if (!person.kriminell && bekannteKriminelle.Contains(person))
                    KriminellenEntfernen(person);
            }
        }
    }     
}

