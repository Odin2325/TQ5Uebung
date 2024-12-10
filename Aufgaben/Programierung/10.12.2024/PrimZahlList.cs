using System;
using System.Security.Claims;

namespace BedingungTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> primzahlenListe = new List<int>();

            Console.Write("Bitte geben Sie eine Zahl ein : " );

            if (int.TryParse(Console.ReadLine(), out int zahl))
            {
                                   
                for (int i = 2; i <= zahl; i++)
                {
                    if (IstPrimZahl(i))
                    {
                        primzahlenListe.Add(i);
                        

                    }
                }
                    Console.WriteLine($"\nPrimzahlen: {string.Join(", ", primzahlenListe)}");
                }
                
            }

        static bool IstPrimZahl(int zahl)
        {
            if (zahl < 2) return false;
            for (int i = 2; i < Math.Sqrt(zahl); i++)
            {
                if(zahl % i == 0)
                {
                    return false ;
                }
            }
            return true;    
            
        }
            

    }
}



