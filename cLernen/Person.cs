using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{
    public class Person
    {
        public string name;
        public string addresse;
        public bool kriminell;

        public Person(string name, string addresse, bool kriminell)
        {
            this.name = name;
            this.addresse = addresse;
            this.kriminell = kriminell;
        }
    }
}
