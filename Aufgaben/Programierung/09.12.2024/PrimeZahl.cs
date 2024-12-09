using System;

namespace BedingungTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Geben Sie eine Zahl zwischen 1 und 20 ein: ");

            if (int.TryParse(Console.ReadLine(), out int zahl))
            {
                if (zahl < 1 || zahl > 20)
                {
                    Console.WriteLine("\nUngültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 20 ein.");
                }
                else if (zahl < 10)
                {
                    //  die Zahl auf Primzahl zu prüfen
                    string ergebnis = zahl switch
                    {
                        2 => "Primzahl",
                        3 => "Primzahl",
                        5 => "Primzahl",
                        7 => "Primzahl",
                        _ => "Keine Primzahl"
                    };

                    Console.WriteLine($"\nDie Zahl {zahl} ist: {ergebnis}");
                }
                else
                {
                    Console.WriteLine("\nZahl ist zu groß für die Überprüfung.");
                }
            }
            else
            {
                Console.WriteLine("\nUngültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
            }
        }
