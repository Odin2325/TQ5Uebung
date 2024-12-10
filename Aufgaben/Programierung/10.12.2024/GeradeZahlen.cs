 static void Main(string[] args)
 {
     //Faktorielle
     Console.Write("Bitte geben Sie eine Grenze für Gerade Zahlen ein : " );

     if (int.TryParse(Console.ReadLine(), out int grenze)){
         GibGeradeZahlen(grenze);
     }
     else
     {
         Console.WriteLine("Bitte geben Sie eine gültige Zahl ein");
     }


 }
 internal static void GibGeradeZahlen(int grenze)
 {
     Console.WriteLine($"Alle geraden Zahlen bis {grenze} : ");
     for (int i = 0 ; i <= grenze  ; i +=2 )
     {
         Console.WriteLine(i);

     }
     
 }