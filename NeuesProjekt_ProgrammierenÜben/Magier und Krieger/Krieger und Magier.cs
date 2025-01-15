using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Magier_und_Krieger
{
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
        public int Dodge { get; set; }
        public int Block { get; set; }
        public Character(string name, int level, int health, int power, int dodge, int block)
        {
            Name = name;
            Level = level;
            Health = health;
            Power = power;
            Dodge = dodge;
            Block = block;
        }
    }
    public static class CharacterSelection
    {
        private static Dictionary<int, Character> characterDictionary = new Dictionary<int, Character>
        {
            { 1, new Krieger("Charakter1", 1, "Krieger", 100, 4, 5, 5) },
            { 2, new Magier("Charakter2", 1, "Magier", 80, 4, 8, 2) }
        };
        public static Character SelectCharacter()
        {
            Console.WriteLine("Wähle deinen Charakter:");
            Console.WriteLine("1: Krieger");
            Console.WriteLine("2: Magier");

            int choice = 0;
            while (choice != 1 && choice != 2)
            {
                Console.Write("Gib 1 für Krieger oder 2 für Magier ein: ");
                choice = int.Parse(Console.ReadLine());

                if (choice != 1 && choice != 2)
                {
                    Console.WriteLine("Ungültige Auswahl. Versuche es nochmal.");
                }
            }
            return characterDictionary[choice];
        }
        internal class Krieger : Character
        {
            public string ClassType {  get; set; }
            public Krieger(string name, int level, string classType, int health, int power, int dodge, int block) : base(name, level, health, power, dodge, block)
            { 
                classType = classType;
            }
            public override void LevelUp()
            {
                base.LevelUp();  
                Power += 2;      
                Health += 25;    
            }
        }
        internal class Magier : Character
        {
            public string ClassType { get; set; }
            public Magier(string name, int level, string classType, int health, int power, int dodge, int block) : base(name, level, health, power, dodge, block)
            {
                classType = classType;
            }
            public override void LevelUp()
            {
                base.LevelUp();
                Power += 2;
                Health += 25;
            }
        }
        public class Enemy : Character
        {
            public Enemy(string name, int level, int health, int power, int dodge, int block) : base(name, level, health, power, dodge, block)
            {
            }
        }
        public static class EnemyManager
        {
            private static Dictionary<int, Enemy> enemyDictionary = new Dictionary<int, Enemy>
            {
                { 1, new Enemy("Wolf",1, 50, 20, 20,0) },
                { 2, new Enemy("Yeti",5, 200, 60,5,0) },
                { 3, new Enemy("Dämon",10, 300, 100,10,10) },
                { 4, new Enemy("Eber",1, 15, 10,0,0) },
                { 5, new Enemy("Krokodil",3, 60, 25,5,0) }
            };
            public static Enemy GetRandomEnemy()
            {
                Random rand = new Random();
                int randomKey = rand.Next(1, enemyDictionary.Count + 1);
                return enemyDictionary[randomKey];
            }
        }
    }
    public static class CharacterManager
    {
        public static Dictionary<int, Character> characterDictionary = new Dictionary<int, Character>();

        public static void UpdateCharacterDictionary(int key, Character character)
        {
            if (characterDictionary.ContainsKey(key))
            {
                characterDictionary[key] = character; 
                Console.WriteLine($"{character.Name} wurde im Dictionary aktualisiert!");
            }
            else
            {
                characterDictionary.Add(key, character);
                Console.WriteLine($"{character.Name} wurde zum Dictionary hinzugefügt!");
            }
        }
    }
    public static class GameUtils
    {
        public static void PerformLevelUp(Character character)
        {
            character.LevelUp();
            Console.WriteLine($"Der Charakter {character.Name} hat jetzt Level {character.Level} und ist stärker!");
        }
    }
}
