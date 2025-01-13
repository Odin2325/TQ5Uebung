using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Reflection.Metadata;


namespace cLernen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior conan = new Warrior("Conan the Barbarian");
            Wizard rincewind = new Wizard("Rincewind");
            Console.WriteLine(rincewind.ToString());
            Console.WriteLine(conan.ToString());
            Console.WriteLine(conan.Vulnerable);
            Console.WriteLine(rincewind.Vulnerable);
            rincewind.DoDamage(conan);
            Console.WriteLine($"Conan Health: {conan.health}.");
            conan.DoDamage(rincewind);
            Console.WriteLine($"Rincewind Health: {rincewind.health}.");
            rincewind.PrepareSpell();
            rincewind.DoDamage(conan);
            Console.WriteLine($"Conan Health: {conan.health}.");
            conan.DoDamage(rincewind);
            Console.WriteLine($"Rincewind Health: {rincewind.health}.");
            conan.DoDamage(rincewind);
            conan.DoDamage(rincewind);
            conan.DoDamage(rincewind);
            conan.DoDamage(rincewind);
            Console.WriteLine(rincewind.Vulnerable);
            rincewind.DoDamage(conan);
            Console.WriteLine(rincewind.Vulnerable);


            /*
            Bibliothek uniBib = new Bibliothek("Unibibliothek", "Hollywood 1-3");
            Bibkunde john = new Bibkunde("John", "Wick", 42, "Hollywood 4", uniBib.KundennummerErstellen());
            Bibkunde john2 = new Bibkunde("John", "Doe", 18, "Bronx", uniBib.KundennummerErstellen());
            Buch dogTraining = new Buch(375, "Cesar Millan", "Be the Pack Leader", "Bildung", "87664533578", "2007", new DateTime(2025, 1, 1));
            Buch fevreDream = new Buch(450, "George R. R. Martin", "Fevre Dream", "Fantasy", "576907857", "1982", new DateTime(2023,01,01));
            //john.GuthabenAufladen(10m);
            uniBib.BuchAusleihen(dogTraining, john);
            uniBib.BuchAusleihen(fevreDream, john);
            Console.WriteLine(john.KundenDetails());
            Console.WriteLine(john2.KundenDetails());
            john.BücherAnzeigen();

            Person john = new Person("John Wick", "Hollywood", true);
            Person bob = new Person("BobtheBuilder", "Next Door", false);
            Person chucky = new Person("Chucky", "Your Room", false);
            Polizeiroboter sonny = new Polizeiroboter();
            sonny.KriminellenHinzufügen(chucky);
            sonny.KriminellenIdentifizieren(bob);
            sonny.PowerButton();
            sonny.KriminellenIdentifizieren(john);
            sonny.Laden();
            sonny.KriminellenIdentifizieren(john);
            sonny.KriminellenIdentifizieren(bob);
            sonny.KriminellenIdentifizieren(chucky);

            Roomba bob = new Roomba();
            bob.MappingErstellen("kinderzimmer");
            bob.PowerButton();
            bob.MüllSammeln();
            bob.Laden();
            bob.MappingErstellen("kinderzimmer");
            bob.MüllSammeln();
            bob.MüllEntsorgen();
            */
            /*
            Büchereikonto frankbuch = new Büchereikonto("Me", "me@gmail.de", "here", "0123456", "MeeMee");
            Buch hogfather = new Buch(345, "Terry Pratchett", "Hogfather", "Fantasy", "2", "123456", 13.99m, "1988");
            Buch snuff = new Buch(345, "Terry Pratchett", "Snuff", "Fantasy", "2", "123456", 13.99m, "1988");
            Buch jingo = new Buch(345, "Terry Pratchett", "Jingo", "Fantasy", "2", "123456", 13.99m, "1988");
            Buch mort = new Buch(345, "Terry Pratchett", "Mort", "Fantasy", "2", "123456", 13.99m, "1988");
            frankbuch.BuchAusleihen(hogfather);
            frankbuch.BuchAusleihen(snuff);
            frankbuch.BuchAusleihen(jingo);
            frankbuch.BuchAusleihen(mort);

            LKW testlkw = new LKW("MAN", "Big Boi", "schwarz", 110, 30); 
            testlkw.Beschleunigen(50);
            Console.WriteLine(testlkw.AktuelleGeschwindigkeit);
            testlkw.Beschleunigen(50);
            Console.WriteLine(testlkw.AktuelleGeschwindigkeit);
            testlkw.Honk();

            Auto auto1 = new Auto("VW", "Passat", "braun", 250, false);
            auto1.Honk();
            auto1.Beschleunigen(99.5);
            auto1.Bremsen();
            */
            Console.ReadKey();
        }
    }
}
