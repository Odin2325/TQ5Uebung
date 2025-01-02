       static void Main(string[] args)
       {
           //Faktorielle
           Console.Write("geben Sie bitte eine Nummer ein :" );

           if (int.TryParse(Console.ReadLine(), out int number)){
               Faktorielle(number);
           }
           else
           {
               Console.WriteLine("Die Eingabe ist nicht Richtig");
           }


       }
       internal static void Faktorielle(int num)
       {
           int Resultat = 1;
           for (int i = num ; i > 1 ; i--)
           {
               Resultat *= i;

           }
           Console.WriteLine($"\nDie Fakultät der Zahl {num} ist: " + Resultat);
       }