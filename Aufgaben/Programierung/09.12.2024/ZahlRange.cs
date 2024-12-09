using System;
using System.ComponentModel.Design;

namespace BedingungTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ZahlRangeüberprüf();
        }

        internal static void ZahlRangeüberprüf()
        {
            String  inputString;
            int eingabe;

            Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 10 ein : ");
            inputString = Console.ReadLine();
            if (inputString == "" || inputString== null)
            {
                Console.WriteLine("\nDie Zahl darf nicht null sein");
                return;
            }
            eingabe = int.Parse(inputString);
            if (eingabe < 0 || eingabe > 10)
            {
                Console.WriteLine("\nDie Zahl ist nicht zwischen 1 und 10 ");
                return;
            }
            if (eingabe > 5 && eingabe <= 10)
            {
                Console.WriteLine("\nDie Zahl ist größer als 5");
            }
            else if (eingabe > 0 && eingabe <=5)  
            {
                Console.WriteLine("\nDie Zahl ist kleiner oder gleich 5");
            }
        }

    }
}