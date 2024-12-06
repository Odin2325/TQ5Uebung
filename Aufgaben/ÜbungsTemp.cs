namespace Übungen05DEZEMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float temperaturCelsius;

            Console.WriteLine("temperatur in Fahrenheit: ");

            
           double celsius = Convert.ToDouble(Console.ReadLine());

            // Calcul la temperature en Fahrende
            double fahrenheit = celsius * (1.8 + 32);


            // Affichez le resultat
            Console.WriteLine(celsius + " Grad Celsius " + fahrenheit.ToString("F2") + " Grad Fahrenheit");

        }
    }
}
