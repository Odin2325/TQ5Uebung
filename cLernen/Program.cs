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
            /*
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
