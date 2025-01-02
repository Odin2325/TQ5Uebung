       static void Main(string[] args)
       {
           
           Console.Write("Bitte geben Sie eine Zahl ein : " );

           if (int.TryParse(Console.ReadLine(), out int zahl))
           {
               if (IstPrimZahl(zahl))
               {
                   Console.WriteLine($"{zahl} ist eine Primzahl.");
               }
               else
               {
                   Console.WriteLine($"{zahl} ist eine Primzahl.");
               }
           }
           else
           {
               Console.WriteLine("\nBitte geben Sie eine gültige Zahl ein");
           }
       }

       static bool IstPrimZahl(int zahl)
       {
           for (int i = 2; i < Math.Sqrt(zahl); i++)
           {
               if(zahl % i == 0)
               {
                   return false ;
               }
           }
           return true;    
           
       }
            