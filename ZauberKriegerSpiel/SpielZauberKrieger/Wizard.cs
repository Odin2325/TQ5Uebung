using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SpielZauberKrieger
{
    public class Wizard : Charakter
    {
        private bool spellPrepared = false;
        public void PrepareSpell()
        {
            spellPrepared = true;
        }

        public override int DamagePoint(Charakter charakter)
        {
            
            return spellPrepared ? 12 : 3;

           
        }

        public override string ToString()
        {
            return "Charakter ist ein Zauberer." ;
        }

        public override bool Vulnerable()
        {
            return !spellPrepared;
        }
    }
}
