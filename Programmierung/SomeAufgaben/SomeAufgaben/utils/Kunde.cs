using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAufgaben.utils
{
    internal class Kunde
    {

        public Dictionary<string, Kunde> kunden = new Dictionary<string, Kunde>();
        public string Passwort { get; set; }
        public string KundenNummer { get; set; }
        public List<string> ausgeliehendeBücher { get; set; }
    }
}
