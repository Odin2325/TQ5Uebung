using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{
    abstract public class Character
    {
        protected bool vulnerable = false;
        public int health = 50;
        public string? charClass;
        protected string? name;

        public bool Vulnerable { get => vulnerable;}
        abstract public override string ToString();
        abstract public void DoDamage(Character opponent);
    }

    public class Wizard: Character
    {
        internal bool spellPrepared = false;

        public Wizard(string name) : base()
        {
            this.name = name;
            base.charClass = "wizard";
            base.vulnerable = true;
        }

        public override string ToString()
        {
            return $"{name} is a {charClass}.";
        }
        public void PrepareSpell()
        {
            spellPrepared = true;
            base.vulnerable = false;
        }
        public override void DoDamage(Character opponent)
        {
            if (opponent.health <= 0)
            {
                Console.WriteLine("Can't kill dead people. That's Death's job.");
                return;
            }
            if (spellPrepared)
            {
                spellPrepared = false;
                base.vulnerable = true;
                opponent.health -= 12;

            }
            else
                opponent.health -= 3;
            if (opponent.health <= 0)
                Console.WriteLine("Opponent died. You won!");
        }
    }

    public class Warrior: Character
    {
        

        public Warrior(string name) : base()
        {
            this.name = name;
            base.charClass = "warrior";
        }

        public override string ToString()
        {
            return $"{name} is a {charClass}.";
        }
        public override void DoDamage(Character opponent)
        {
            if (opponent.health <= 0)
            {   
                Console.WriteLine("Can't kill dead people. That's Death's job.");
                return;
            }
            if (opponent.Vulnerable)
                opponent.health -= 10;
            else
                opponent.health -= 6;
            if (opponent.health <= 0)
                Console.WriteLine("Opponent died. You won!");
        }
    }
}
