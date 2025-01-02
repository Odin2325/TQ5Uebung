using System.Diagnostics;

namespace ProgramierenLernen
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            double tempInCelcius; 
            
            double tempInFahrenheit;
            
            
            Console.Write("Bitte geben Sie den Grad in Celsius ein: ");
            tempInCelcius = Convert.ToDouble(Console.ReadLine());

            //F = Celsius * 9 / 5 + 32;

            tempInFahrenheit = (tempInCelcius * 1.8) + 32;

            Console.WriteLine("Die Temperatur in Fahrenheit ist : " + tempInFahrenheit.ToString());
                
        }
    }
}

*******************************************************************************************************
using System.Diagnostics;

namespace ProgramierenLernen
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            double höhe; 
            double radius;
            double PI = 3.1415;

            double gekrümmterOberfläche;
            double gesamtoberfläche;
            double volume;


            Console.Write("Bitte geben Sie die Höhe ihres Zylinders ein: ");
            höhe = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie den Radius Ihres Zylinders ein: ");
            radius = Convert.ToDouble(Console.ReadLine());


            //Gekrümmter Oberflächenbereich des Zylinders = 2πrh
            gekrümmterOberfläche = 2 * PI * radius * höhe;

            // Gesamtoberfläche des Zylinders = 2πr(r + h)
            gesamtoberfläche = 2 * PI * radius * (radius + höhe);

            //  Volumen des Zylinders = V = πr2h
            volume = PI * radius * radius * höhe;

            Console.WriteLine("\nDie endgültige Berechnung .......\n");
            Console.WriteLine("Gekrümmter Oberflächenbereich des Zylinders ist : " + gekrümmterOberfläche.ToString() +"\n"); 
            Console.WriteLine("Gesamtoberfläche des Zylinders ist : " + gesamtoberfläche.ToString() + "\n");
            Console.WriteLine("Volumen des Zylinders ist : " + volume.ToString() + "\n");
            


        }
    }

****************************************************************************************************

using System.Diagnostics;

namespace ProgramierenLernen
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            double P;           // Anfangsinvestition (P)
            double r = 0.04;    // jährlichen Zinssatz
            int t;             // die Anzahl der Jahre
            short n = 1;       //Zinssatz wird jährlich 1 Mal pro Jahr aufgezinst (n=1)
            double A;           // der Geldbetrag am Ende des Prozesses


            Console.Write("Bitte geben Sie die Anfangsinvestition auf einem Sparkonto ein in Euro: ");
            P = Convert.ToDouble(Console.ReadLine());
            //double.Parse(Console.ReadLine());

            Console.Write("Bitte geben Sie die Anzahl der Jahre, in denen das Geld angelegt ist, ein: ");
            t = int.Parse(Console.ReadLine());

            A = P * Math.Pow((1 + r / n), n * t);


            Console.WriteLine("\nDie endgültige Berechnung .......\n");
            Console.WriteLine("der Geldbetrag am Ende des Prozesses ist : " + A.ToString() + "\n");
          
        }
    }
}


}
***************************************************************************************************************************
