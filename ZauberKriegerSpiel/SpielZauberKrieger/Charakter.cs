using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpielZauberKrieger
{
    public abstract class Charakter
    {
        public abstract bool Vulnerable();
        public abstract int DamagePoint(Charakter charakter);
        public abstract string ToString();
        
    }


}
