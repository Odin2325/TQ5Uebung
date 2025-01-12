using System;
using System.Reflection.Emit;
using static Magier_und_Krieger.CharacterSelection;

namespace Magier_und_Krieger
{
    internal class Combat
    {
        static void Main(Character character, Enemy enemy)
        {            
            Console.WriteLine("Hallo Abenteurer, möchtest du als Magier oder Krieger spielen?");
            Console.WriteLine("Bitte gib Magier oder Krieger in die Konsole ein");
            Character chosenCharacter = CharacterSelection.SelectCharacter();
            Console.WriteLine($"Du hast den {chosenCharacter.Name} (Level {chosenCharacter.Level}) gewählt!");
            Console.WriteLine($"Leben: {chosenCharacter.Health}, Stärke: {chosenCharacter.Power}, Ausweichen: {chosenCharacter.Dodge}, Blocken: {chosenCharacter.Block}");
            Enemy randomEnemy = EnemyManager.GetRandomEnemy();
            Console.WriteLine($"Kurz nachdem du deine Reise beginnst und dich im nahen Wald nach ein paar Früchten suchst hörst du plötzlich einm Geräusch als ein {randomEnemy.Name} der Stufe{randomEnemy.Level} erscheint");
        }
        static void Aktionsauswahl(Character character)
        {
            Console.WriteLine("Was möchtest du tun?");
            Console.WriteLine("1 - Flucht()");
            Console.WriteLine("2 - Angreifen");
            Console.WriteLine("3 - Ausweichen");
            Console.WriteLine("4 - Blocken");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Random rand = new Random();
                    int diceRollD20 = rand.Next(1, 21);
                    if (diceRollD20 > 10)
                    {
                        Console.WriteLine("Du konntest erfolgreich fliehen");
                    } else
                    {
                        Console.WriteLine("Die Flucht ist nicht geglückt, das Monster greift an");
                    }
                    break;
                case "2":
                    if(character is Krieger)
                    {
                        Console.WriteLine("Du ziehst deine Waffe und schlägst zu!");
                    }
                    else if (character is Magier)
                    {
                        Console.WriteLine("Du ziehst deinen Zauberstab und beginnst, Magie zu wirken!");
                    }
                    break;
                case "3":
                    Console.WriteLine("Du versuchst, auszuweichen!");
                    break;
                case "4":
                    Console.WriteLine("Du machst dich bereit zum blocken!");
                    break;
                default : Console.WriteLine("ungültige Eingabe, du wirst überrascht, das Monster greift an!");
                    break;
            }
        }
        static void Angreifern(Character character, Enemy enemy)
        {
            Random rand = new Random();
            int diceRollD20 = rand.Next(1, 21);
            int diceRollD12 = rand.Next(1, 13);
            int diceRollD6 = rand.Next(1, 7);

            int critrollFighter = diceRollD12 + 4 * 2;
            int critrollMage = diceRollD6 + 4 * 2;

            int actualDamageFighter = diceRollD12 + 4 - enemy.Block;
            int actualDamageMage = diceRollD6 + 4 - enemy.Block;

            actualDamageFighter = actualDamageFighter < 0 ? 0 : actualDamageFighter;
            actualDamageMage = actualDamageMage < 0 ? 0 : actualDamageMage;
            if (character is Krieger)
            {
                if (diceRollD20+ 4 > enemy.Dodge && diceRollD20 > 18)
                {
                    Console.WriteLine("Wow ein kritischer Treffer!");
                    Console.WriteLine($"Du Trieffst mit deiner Waffe! und verursachst {critrollFighter} Schaden, Krits können nicht geblockt werden");
                    enemy.Health -= critrollFighter;
                }
                if (diceRollD20 + 4 > enemy.Dodge)
                {
                    Console.WriteLine($"Du Trieffst mit deiner Waffe! und verursachst {diceRollD12+4} - {enemy.Block} Schaden, wovon {enemy.Block} geblockt werden");
                    enemy.Health -= actualDamageFighter;
                }
                if (diceRollD20 + 4 <= enemy.Dodge)
                {
                    Console.WriteLine("Der Gegner konnte deinem Angriff ausweichen");
                }
            }
            if (character is Magier)
            {
                if (diceRollD20 > 18)
                {
                    Console.WriteLine("Wow ein kritischer Treffer!");
                    Console.WriteLine($"Du Trieffst mit deiner Waffe! und verursachst {critrollMage} Schaden, Krits können nicht geblockt werden!");
                    enemy.Health -= critrollMage;
                    ShowHealthStatus(enemy);
                }
                else 
                {
                    Console.WriteLine($"Du Trieffst mit deinem Zauber und verursachst {diceRollD6 + 4} Schaden");
                    enemy.Health -= actualDamageMage;
                    ShowHealthStatus(enemy);
                    GameUtils.PerformLevelUp(magier);
                }
            }
        }
        static void Ausweichen (Character character, Enemy enemy)
        {
            Random rand = new Random();
            int dodgeValue = character.Dodge * 2;
            int diceRollD20 = rand.Next(1, 21);
            int diceRollD12 = rand.Next(1, 13);
            int diceRollD10 = rand.Next(1, 11);
            int diceRollD8 = rand.Next(1, 9);
            int diceRollD4 = rand.Next(1, 5);

            int enemyWolfEberAttack = diceRollD4 + 1;
            int enemyKrokodilAttack = diceRollD8 + 4;
            int enemyYetiAttack = diceRollD10 + 6;
            int enemyDämonAttack = diceRollD12 + 10;

            int critWolfEber = enemyWolfEberAttack * 2;
            int critKroko = enemyKrokodilAttack * 2;
            int critYeti= enemyYetiAttack * 2;
            int critDämon =enemyDämonAttack * 2;

            int actualDamageWolfEeber = enemyWolfEberAttack - character.Block;
            int actualDamageKroko = enemyKrokodilAttack - character.Block;
            int actualDamageYeti = enemyYetiAttack - character.Block;
            int actualDamageDämon = enemyDämonAttack - character.Block;

            actualDamageWolfEeber = actualDamageWolfEeber < 0 ? 0 : actualDamageWolfEeber;
            actualDamageKroko = actualDamageKroko < 0 ? 0 : actualDamageKroko;
            actualDamageYeti = actualDamageYeti < 0 ? 0 : actualDamageYeti;
            actualDamageDämon = actualDamageDämon < 0 ? 0 : actualDamageDämon;

            Console.WriteLine("Du machst dich bereit dem Angriff auszuweichen!");
            int ausweichrolle = character.Dodge * 2;
            if (enemy.Name == "Wolf" || enemy.Name == "Eber")
            {
                if (diceRollD20 + 1 > ausweichrolle && diceRollD20 > 18)
                {
                    Console.WriteLine("Wow ein kritischer Treffer vom Gegner!");
                    Console.WriteLine($"Er Trifft dich und verursacht {critWolfEber} Schaden");
                    int Lebenspunkte = character.Health -= critWolfEber;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 1 > ausweichrolle)
                {
                    Console.WriteLine($"Er Trifft dich trotzdem und verursacht {enemyWolfEberAttack} Schaden");
                    character.Health -= actualDamageWolfEeber;
                    int Lebenspunkte = character.Health -= actualDamageWolfEeber;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 1 <= ausweichrolle)
                {
                    Console.WriteLine("Super du bist ausgewichen!");
                }
            }
            if (enemy.Name == "Yeti")
            {
                if (diceRollD20 + 6 > ausweichrolle && diceRollD20 > 18)
                {
                    Console.WriteLine("Wow ein kritischer Treffer vom Gegner!");
                    Console.WriteLine($"Er Trifft dich und verursacht {critYeti} Schaden");
                    int Lebenspunkte = character.Health -= critYeti;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 6 > ausweichrolle)
                {
                    Console.WriteLine($"Er Trifft dich trotzdem und verursacht {enemyWolfEberAttack} Schaden");
                    character.Health -= actualDamageWolfEeber;
                    int Lebenspunkte = character.Health -= actualDamageWolfEeber;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 6 <= ausweichrolle)
                {
                    Console.WriteLine("Super du bist ausgewichen!");
                }
            }
            if (enemy.Name == "Krokodil")
            {
                if (diceRollD20 + 4 > ausweichrolle && diceRollD20 > 18)
                {
                    Console.WriteLine("Wow ein kritischer Treffer vom Gegner!");
                    Console.WriteLine($"Er Trifft dich und verursacht {critKroko} Schaden");
                    int Lebenspunkte = character.Health -= critKroko;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 4 > ausweichrolle)
                {
                    Console.WriteLine($"Er Trifft dich trotzdem und verursacht {enemyKrokodilAttack} Schaden");
                    character.Health -= actualDamageKroko;
                    int Lebenspunkte = character.Health -= actualDamageKroko;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 4 <= ausweichrolle)
                {
                    Console.WriteLine("Super du bist ausgewichen!");
                }
            }
            if (enemy.Name == "Dämon")
            {
                if (diceRollD20 + 10 > ausweichrolle && diceRollD20 > 18)
                {
                    Console.WriteLine("Wow ein kritischer Treffer vom Gegner!");
                    Console.WriteLine($"Er Trifft dich und verursacht {critDämon} Schaden");
                    int Lebenspunkte = character.Health -= critDämon;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 10 > ausweichrolle)
                {
                    Console.WriteLine($"Er Trifft dich trotzdem und verursacht {enemyDämonAttack} Schaden");
                    character.Health -= actualDamageDämon;
                    int Lebenspunkte = character.Health -= actualDamageDämon;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 10 <= ausweichrolle)
                {
                    Console.WriteLine("Super du bist ausgewichen!");
                }
            }
        }
        static void Block(Character character, Enemy enemy)
        {
            Console.WriteLine("Du machst dich bereit den Angriff zu blocken!");
            Random rand = new Random();
            int dodgeValue = character.Dodge * 2;
            int diceRollD20 = rand.Next(1, 21);
            int diceRollD12 = rand.Next(1, 13);
            int diceRollD10 = rand.Next(1, 11);
            int diceRollD8 = rand.Next(1, 9);
            int diceRollD4 = rand.Next(1, 5);

            int enemyWolfEberAttack = diceRollD4 + 1;
            int enemyKrokodilAttack = diceRollD8 + 4;
            int enemyYetiAttack = diceRollD10 + 6;
            int enemyDämonAttack = diceRollD12 + 10;

            int critWolfEber = enemyWolfEberAttack * 2;
            int critKroko = enemyKrokodilAttack * 2;
            int critYeti = enemyYetiAttack * 2;
            int critDämon = enemyDämonAttack * 2;

            int starkerBlock = character.Block * 3;

            int actualDamageWolfEeber = enemyWolfEberAttack - starkerBlock;
            int actualDamageKroko = enemyKrokodilAttack - starkerBlock;
            int actualDamageYeti = enemyYetiAttack - starkerBlock;
            int actualDamageDämon = enemyDämonAttack - starkerBlock;

            actualDamageWolfEeber = actualDamageWolfEeber < 0 ? 0 : actualDamageWolfEeber;
            actualDamageKroko = actualDamageKroko < 0 ? 0 : actualDamageKroko;
            actualDamageYeti = actualDamageYeti < 0 ? 0 : actualDamageYeti;
            actualDamageDämon = actualDamageDämon < 0 ? 0 : actualDamageDämon;


            Console.WriteLine("Du machst dich bereit dem Angriff auszuweichen!");
            if (enemy.Name == "Wolf" || enemy.Name == "Eber")
            {
                if (diceRollD20 + 1 > character.Dodge && diceRollD20 > 18)
                {
                    Console.WriteLine("Wow ein kritischer Treffer vom Gegner!");
                    Console.WriteLine($"Er Trifft dich und verursacht {critWolfEber} Schaden, diesen Angriff hast du nicht kommen sehen");
                    int Lebenspunkte = character.Health -= critWolfEber;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 4 > character.Dodge)
                {
                    Console.WriteLine($"Er Trifft dich trotzdem und verursacht {enemyWolfEberAttack} - {starkerBlock} Schaden");
                    character.Health -= actualDamageWolfEeber;
                    int Lebenspunkte = character.Health -= actualDamageWolfEeber;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 4 <= character.Dodge)
                {
                    Console.WriteLine("Der feind hat verfehlt!");
                }
            }
            if (enemy.Name == "Yeti")
            {
                if (diceRollD20 + 6 > character.Dodge && diceRollD20 > 18)
                {
                    Console.WriteLine("Wow ein kritischer Treffer vom Gegner!");
                    Console.WriteLine($"Er Trifft dich und verursacht {critYeti} Schaden");
                    int Lebenspunkte = character.Health -= critYeti;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 6 > character.Dodge)
                {
                    Console.WriteLine($"Er Trifft dich trotzdem und verursacht {enemyWolfEberAttack} - {starkerBlock} Schaden");
                    character.Health -= actualDamageWolfEeber;
                    int Lebenspunkte = character.Health -= actualDamageWolfEeber;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 6 <= character.Dodge)
                {
                    Console.WriteLine("Der feind hat verfehlt!");
                }
            }
            if (enemy.Name == "Krokodil")
            {
                if (diceRollD20 + 4 > character.Dodge && diceRollD20 > 18)
                {
                    Console.WriteLine("Wow ein kritischer Treffer vom Gegner!");
                    Console.WriteLine($"Er Trifft dich und verursacht {critKroko} Schaden");
                    int Lebenspunkte = character.Health -= critKroko;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 4 > character.Dodge)
                {
                    Console.WriteLine($"Er Trifft dich trotzdem und verursacht {enemyKrokodilAttack} - {starkerBlock} Schaden");
                    character.Health -= actualDamageKroko;
                    int Lebenspunkte = character.Health -= actualDamageKroko;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 4 <= character.Dodge)
                {
                    Console.WriteLine("Der feind hat verfehlt!");
                }
            }
            if (enemy.Name == "Dämon")
            {
                if (diceRollD20 + 10 > character.Dodge && diceRollD20 > 18)
                {
                    Console.WriteLine("Wow ein kritischer Treffer vom Gegner!");
                    Console.WriteLine($"Er Trifft dich und verursacht {critDämon} Schaden");
                    int Lebenspunkte = character.Health -= critDämon;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 10 > character.Dodge)
                {
                    Console.WriteLine($"Er Trifft dich trotzdem und verursacht {enemyDämonAttack} - {starkerBlock} Schaden");
                    character.Health -= actualDamageDämon;
                    int Lebenspunkte = character.Health -= actualDamageDämon;
                    Console.WriteLine($"Deine Lebenspunkte betragen {Lebenspunkte}");
                }
                if (diceRollD20 + 10 <= character.Dodge)
                {
                    Console.WriteLine("Der feind hat verfehlt!");
                }
            }
        }
        static void LevelUp(Character character, Enemy enemy)
        {                 
                Level += 1;
                Health += 25;  
                Power += 5;    
                Dodge += 2;    
                Block += 2;   
                Console.WriteLine("Was ein toller Kampf, du bist stärker geworden! Du bist nun Stufe 2");
                Krieger.levelup;
        }
        static void ShowHealthStatus(Enemy enemy)
        {
            double healthPercentage = (double)enemy.Health / 100;
            if (enemy.Health <= 0)
            {
                Console.WriteLine("Der Gegner ist besiegt!");
            }
            else if (healthPercentage > 0.75)
            {
                Console.WriteLine("Der Gegner ist kaum verletzt.");
            }
            else if (healthPercentage >= 0.40 && healthPercentage <= 0.60)
            {
                Console.WriteLine("Der Gegner ist sehr verletzt.");
            }
            else if (healthPercentage < 0.25)
            {
                Console.WriteLine("Der Gegner ist schwer verletzt!");
            }
        }
    }

}
