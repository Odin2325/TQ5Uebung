namespace cLernen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature in Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"{celsius} Celsius is {fahrenheit} in Fahrenheit.\n");
            Console.WriteLine("-~-~-~-~-~-~-\n");

            int height = 6;
            int radius = 3;
            double pi = 3.1415;
            double curved_surface = 2 * pi * height * radius;
            double surface = 2 * pi * radius * (radius + height);
            double volume = pi * radius * 2 * height;
            Console.WriteLine($"A cylinder of height {height} and radius {radius} has:\nA curved surface area of {curved_surface:F2}, a surface of {surface:F2} and a volume of {volume:F2}.\n");
            Console.WriteLine("-~-~-~-~-~-~-\n");

            Console.WriteLine("Enter a initial investment sum:");
            double investment = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the duration of investment in years:");
            int years = Convert.ToInt32(Console.ReadLine());
            double interestRate = 0.04;
            double output = investment * (Math.Pow((1 + interestRate / 1), years));
            Console.WriteLine($"Total amount after {years} years: {output:F2}.");
        }
    }
}
