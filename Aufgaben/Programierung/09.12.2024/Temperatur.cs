using System;
using System.ComponentModel.Design;

namespace BedingungTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Temperaturüberprüfen();
        }

        internal static void Temperaturüberprüfen()
        {
            String  inputString;
            int eingabe;

            Console.Write("Bitte geben Sie die Temperatur ein : ");
            inputString = Console.ReadLine();


            if (inputString == "" || inputString== null)
            {
                Console.WriteLine("\nDie Temperatur darf nicht null sein");
                return;
            }

            eingabe = int.Parse(inputString);
           
            if (eingabe > 30)
            {
                Console.WriteLine("\n Es ist heiß, trinke viel Wasser");
            }
            else if (eingabe >= 15 && eingabe <= 30)
            {
                Console.WriteLine("\n Das Wetter ist angenehm");
            }
            else if (eingabe <= 15)
            {
                Console.WriteLine("\n Es ist kalt, ziehe eine Jacke an");
            }
        }

    }
}
