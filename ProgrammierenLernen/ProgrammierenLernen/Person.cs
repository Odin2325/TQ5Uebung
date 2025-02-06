using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenLernen
{
    public class Person
    {
        public string name;
        public string adresse;
        public bool krimineller;

        public Person(string name, string adresse, bool krimineller)
        {
            this.name = name;
            this.adresse = adresse;
            this.krimineller = krimineller;
        }
    }
}
