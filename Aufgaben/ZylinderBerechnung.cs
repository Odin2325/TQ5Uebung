namespace Übungen05DEZEMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                const double PI = 3.1415;

                // Demander à l'utilisateur d'entrer la hauteur et le rayon du cylindre
                Console.Write("Höhe des Zylinders eingeben (h) : ");
                double höhe = Convert.ToDouble(Console.ReadLine());

                Console.Write("Radius des Zylinders eingeben (r) : ");
                double radius = Convert.ToDouble(Console.ReadLine());

                // Calculs
                double GekrümmteOberfläche = 2 * PI * radius * höhe;
                double Gesamtfläche = 2 * PI * radius * (radius + höhe);
                double volume = PI * Math.Pow(radius, 2) * höhe;

                // Afficher les résultats
                Console.WriteLine("Gekrümmte Oberfläche des Zylinders : " + GekrümmteOberfläche.ToString("F2"));
                Console.WriteLine("Gesamtfläche des Zylinders : " + Gesamtfläche.ToString("F2"));
                Console.WriteLine("Volumen des Zylinders : " + volume.ToString("F2"));

            }
        }
    }
}
