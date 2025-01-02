using System;
using System.Security.Claims;
using System.Collections.Generic;
using System.IO;
using System.Buffers;
using System.ComponentModel.Design;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;


namespace BedingungTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Auto toyota = new Auto("Rot", "Toyota", "RAV4", 200, true, 2022, "Benzin", 5);

            Console.WriteLine(toyota.modell);
            Console.WriteLine(toyota.baujahr);
        }



       
     /*   public static (double Durchschnitt, double Summe, double Min, double Max, int Anzahl) ListStatistics(List<double> zahlen)
        {
            double durchschnitt = BerechneDurchschnitt(zahlen);
            double summe = BerechneSumme(zahlen);
            double min = FindeMin(zahlen);
            double max = FindeMax(zahlen);
            int anzahl = zahlen.Count;

            return (durchschnitt, summe, min, max, anzahl);



        }
     */

        public static double BerechneSumme(List<double> zahlen)
        {
            //List<double> summe = [23.2,235.34,3.45,34.5,36.4,45,6.75,756,878,67,7978.97,0890,8];

            if (zahlen == null || !zahlen.Any())
                return 0;
            return zahlen.Sum();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="zahlen"></param>
        /// <returns></returns>
        public static double BerechneDurchschnitt(List<double> zahlen)
        {
            if (zahlen == null || !zahlen.Any())
                return 0;
            return BerechneSumme(zahlen) / zahlen.Count;
        }

      /*  public static double FindeMin(List<double> zahlen)
        {
            foreach (double x in zahlen)    
            return zahlen.Min();
        }
      */
        public static double FindeMax(List<double> zahlen)
        {
            if (zahlen == null || zahlen.Count == 0)
                return double.NaN;

            double max = zahlen[0];
            foreach (var zahl in zahlen)
            {
                if (zahl > max)
                    max = zahl;
            }    
            return max;
        }
        


        public static string CleanPhoneNumber(string telNummer)
        {
            //string cleanedNumber = CleanPhoneNumber("+1 (613)-995-0253");
            //(NXX)-NXX - XXXX
            // N=> 2-9
            // X => 0-9
            //\D bedeutet alle Zeichen, die keine Ziffer (0–9) sind.   \d: Eine Ziffer von 0 bis 9.     \D: Alles außer Ziffern.
            string cleaned = Regex.Replace(telNummer, @"\D", "");
            Console.WriteLine($"{telNummer}  -  { cleaned}");
            return cleaned;
        }


        public static int BerechneCollatzSchritte(int num)
        {
            /*
              Console.Write("geben Sie ein Positive Zahl ein: ");
              if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
              {
                  int steps = BerechneCollatzSchritte(num);
                  Console.WriteLine($"\nAnzahl der Schritte, um 1 zu erreichen: {steps}");
            }
              else
              {
                  Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive ganze Zahl ein.");
              }
             */
            int result;
            Console.WriteLine($"Das Ergebnis ist :\n  1 - {num}");

            int schritte = 0;

            while (num != 1) 
            {
                if (num % 2 == 0)
                {
                    result = num / 2;
                }
                else
                {
                    result = num * 3 + 1;
                }
                num = result;
                Console.WriteLine($"       {result}");

         //       if (num == 1) { break; }

                schritte ++;
            }
            //Console.WriteLine(num); // Zeigt die finale 1 an
            return schritte;
        }


        public static void PyramideErstellen(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = n ; k >= i; k--)
                    Console.Write(" ");

                for (int j = 0; j < i + 1 ; j++)
                {
                   Console.Write("* ");
                }
                Console.WriteLine();  
            }

        }

        public static List<string> readRnaSequence(string rnaInput)
        {
            /*
             *      Console.WriteLine("Geben Sie eine RNA Sequence ein: ");
                    string rnaInput = Console.ReadLine().ToUpper()  ;
                    List<string> protein = readRnaSequence(rnaInput);

                    Console.WriteLine(string.Join(", ", protein));
             * 
             */
            var condonTabele = new Dictionary<string, string>()
            {
                {"AUG", "Methionin"},
                {"UUU", "Phenylalanin"}, {"UUC", "Phenylalanin"},
                {"UUA", "Leucin"}, {"UUG", "Leucin"},
                {"UCU", "Serin"}, {"UCC", "Serin"}, {"UCA", "Serin"}, {"UCG", "Serin"},
                {"UAU", "Tyrosin"}, {"UAC", "Tyrosin"},
                {"UGU", "Cystein"}, {"UGC", "Cystein"},
                {"UGG", "Tryptophan"},
                {"UAA", "STOP"}, {"UAG", "STOP"}, {"UGA", "STOP"}
             };


            var protein = new List<string>();
            for (int i = 0; i < rnaInput.Length; i+=3)
            {
                string condon = rnaInput.Substring(i, 3);
                if (condonTabele.ContainsKey(condon))
                {
                    if (condonTabele[condon] == "STOP")
                        break;

                    protein.Add(condonTabele[condon]);

                }
            }            
            return protein; 
        }


    }

}





 /*public static void Main(string[] args)
        {
            bool result;
            Console.WriteLine("Geben Sie eine Jahreszahl ein: ");
            int jahr = Convert.ToInt32(Console.ReadLine());

            result = IstSchaltjahr(jahr);
            if (result)
            {
                Console.WriteLine($"{jahr} ist ein Schalt Jahr");
            }
            else {
                Console.WriteLine($"{jahr} ist nicht ein Schalt Jahr");
            }


        }


        public static bool IstSchaltjahr(int jahr) {

            if ((jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0))
            {
                return true;

            }
            return false;

   */     

    /*  public static void Main(string[] args)
      {
          {
              const double sekundenProErdjahr = 31557600; // 1 Erdjahr in Sekunden

              // Arrays für Planeten und ihre Umlaufzeiten
              string[] planeten = { "Merkur", "Venus", "Erde", "Mars", "Jupiter", "Saturn", "Uranus", "Neptun" };
              double[] umlaufzeiten = { 0.2408467, 0.61519726, 1.0, 1.8808158, 11.862615, 29.447498, 84.016846, 164.79132 };

              Console.Write("Geben Sie Ihr Alter in Sekunden ein: ");
              double alterInSekunden = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("\nIhr Alter auf den Planeten:");
              for (int i = 0; i < planeten.Length; i++)
              {
                  double alterInPlanetenjahren = alterInSekunden / (sekundenProErdjahr * umlaufzeiten[i]);
                  Console.WriteLine($"{planeten[i]}: {alterInPlanetenjahren:F2} Jahre");
              }
          }
      }

      */







/*        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string result = RegenTropfen(i);
                if (result == null || result == "") // result.lengh()
                {
                    Console.WriteLine($"{i}");
                }
                else
                {
                    Console.WriteLine($"{i} - {result}");
                }
            }

        }
        static string RegenTropfen(int eingabe)
        {
            String ousGabe = "";
            if (eingabe % 3 == 0) {
                ousGabe += "Pling ";

            }
            if (eingabe % 5 == 0) {
                ousGabe += "Plung ";

            }
            if (eingabe % 7 == 0) {
                ousGabe += "Plong ";

            }
            return ousGabe;
        }
    }

}


  */

/*
    static void Main(string[] args)
{
    string input = "Hallo mein name ist Nicolas";

    string result = pangram(input);

    Console.WriteLine(result);
}
 */
/*
        static string pangram(string sentence)
        {
            List<string> words = new List<string>(sentence.Split(' '));
            List<string> reversedWords = new List<string>();

            foreach (string word in words)
            {
                
                List<char> charList = new List<char>(word);

                
                charList.Reverse();

                reversedWords.Add(new string(charList.ToArray()));
            }

            
            return string.Join(" ", reversedWords);
        }

    


  */






/*
public static void findIndexArray(double[] array,int num)
{

    for (int i = array.Length; i > 0; i--)
    {
        Console.Write(array[i-1]);


        if (i > 0)
        {
            Console.Write(", ");
        }
    }
    Console.Write("}");
}

*/
/*
 *  int sum = 0;
            for (int i = 0; i < zahlen.Length; i++)
            {
                sum += zahlen[i];
            }
            return sum;
*******************************************


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
  */







// Pyramide
/*
            int num, i, j, k;
            Console.Write("enter the level:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j<num - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();

             }
*/
/* internal static void Waehrungsrechner()
 {
     const decimal yen = 159.14558m;
     const decimal inr = 89.655121m;
     const decimal gbp = 0.82812935m;
     const decimal usd = 1.0581981m;

     decimal endBetrag;
     int gewuenschteWaehrung;

     Console.WriteLine("-----------Waehrungsrechner-----------");
     Console.WriteLine("Geben Sie dein Betrag ein: ");
     decimal.TryParse(Console.ReadLine(), out decimal betragInEuro);

     Console.WriteLine("Wir arbeiten mit die folgenden Waehrungen. Waehlen Sie bitte eins davon aus, anhand der Zahl:");
     Console.WriteLine("1. YEN\n2. INR\n3. GBP\n4. USD");
      if(int.TryParse(Console.ReadLine(), out gewuenschteWaehrung))
     {
         do
         {
             Console.WriteLine("Wir arbeiten mit die folgenden Waehrungen. Waehlen Sie bitte eins davon aus, anhand der Zahl:");
             Console.WriteLine("1. YEN\n2. INR\n3. GBP\n4. USD");
             if (!int.TryParse(Console.ReadLine(), out  gewuenschteWaehrung))
         }
         while (gewuenschteWaehrung>= 1 && gewuenschteWaehrung <= 4)
         {
             endBetrag = gewuenschteWaehrung switch
             {
                 "1" => yen * betragInEuro,
                 "2" => inr * betragInEuro,
                 "3" => gbp * betragInEuro,
                 "4" => usd * betragInEuro,
                 _ => throw new Exception("Ungueltige Option.")
             };

         }
     };





     Console.WriteLine("Sie haetten: " + Math.Round(endBetrag, 2));


 }
*/
/*  internal static void EingabePrüfen(out int eingabe)
  {

          while (int.TryParse(Console.ReadLine(), out eingabe) > 15)
      {
          Console.WriteLine("Ungültige Eingabe! Neuer Versuch:");
      }
  }

  internal static void SummeRechnen(int startCounter, int endCounter)
  {
      int summe = 0;

      while (startCounter < endCounter)
      {
          summe += startCounter;
          startCounter++;
      }

      Console.WriteLine($"Die Summe von 1 bis 200 ist: {summe}");
  }
*/

/*
 * 
 * 
    Console.Write("Geben Sie eine Zahl zwischen 1 und 20 ein: ");

    if (int.TryParse(Console.ReadLine(), out int zahl))
    {
        if (zahl < 1 || zahl > 20)
        {
            Console.WriteLine("\nUngültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 20 ein.");
        }
        else if (zahl < 10)
        {
            // Verwenden der switch-Anweisung, um die Zahl auf Primzahl zu prüfen
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
 * 
 * 
 * */


