using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpielZauberKrieger
{
    public class Warrior : Charakter
    {
        public override int DamagePoint(Charakter charakter)
        {
            return charakter.Vulnerable() ? 10 : 6;
        }

        public override string ToString()
        {
            return "Charakter ist ein Krieger";
        }

        public override bool Vulnerable()
        {
            return false;
        }
    }
}
