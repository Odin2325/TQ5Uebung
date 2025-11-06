using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenLernen
{
    internal interface IAnimal
    {
        string Name { get; }
        void Geraeusch();
        void Essen(string futter);
    }

    public class Wolf : IAnimal
    {
        public string Name { get; } = "Wolf";

        public void Essen(string futter)
        {
            Console.WriteLine($"Ein Wolf isst {futter}.");
        }

        public void Geraeusch()
        {
            Console.WriteLine("Awoooooooooo");
        }
    }

    public class Giraffe : IAnimal
    {
        public string Name => "Giraffe";

        public void Essen(string futter)
        {
            Console.WriteLine($"Eine Giraffe isst {futter}.");
        }

        public void Geraeusch()
        {
            Console.WriteLine("mampf mampf mampf");
        }
    }


}
