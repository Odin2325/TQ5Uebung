using System;
using System.ComponentModel.Design;

namespace BedingungTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WochenTage();
        }

        internal static void WochenTage()
        {
            Console.Write("Geben Sie eine Zahl für den Wochentag (1-7) ein: ");


            if (int.TryParse(Console.ReadLine(), out int tag))
            {


                string wochentag = tag switch
                {
                    1 => "Montag",
                    2 => "Dienstag",
                    3 => "Mittwoch",
                    4 => "Donnerstag",
                    5 => "Freitag",
                    6 => "Samstag",
                    7 => "Sonntag",
                    _ => "Ungültige Eingabe"
                };

                Console.WriteLine($"\nDer Wochentag ist: {wochentag}");
            }
            else
            {
                Console.WriteLine("\nUngültige Eingabe");
                
            }
        }

    }
}