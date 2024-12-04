do
{
    Console.WriteLine("Wähle:");
    Console.WriteLine("\t1: Addition");
    Console.WriteLine("\t2: Subtraktion");
    Console.WriteLine("\t3: Multiplikation");
    Console.WriteLine("\t4: Flächenberechnung Rechteck");
    Console.WriteLine("\t5: Umrechnung Celsius -> Fahrenheit");
    Console.WriteLine("\t6: Beenden");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Addition();
            break;
        case "2":
            Subtraktion();
            break;
        case "3":
            Multiplikation();
            break;
        case "4":
            Flächeninhalt();
            break;
        case "5":
            CelsiusFahrenheit();
            break;
        case "6":
            // 😮😮😮😮😮
            goto Ende;
            break;
    }

    void Addition()
    {
        Console.WriteLine("Addition");
        Console.Write("a: ");
        decimal a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("b: ");
        decimal b = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("a + b = {0}", a + b);
    }
}
while (true);

void CelsiusFahrenheit()
{
    Console.WriteLine("Umrechnung Celsius -> Fahrenheit");
    Console.Write("Celsius: ");
    decimal c = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Fahrenheit: {0}", (c * 9 / 5) + 32);
}

void Flächeninhalt()
{
    Console.WriteLine("Flächeninhalt eines Rechtecks");
    Console.Write("a: ");
    decimal a = Convert.ToDecimal(Console.ReadLine());
    Console.Write("b: ");
    decimal b = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("a * b = {0}", a * b);
}

void Multiplikation()
{
    Console.WriteLine("Multiplikation");
    Console.Write("a: ");
    decimal a = Convert.ToDecimal(Console.ReadLine());
    Console.Write("b: ");
    decimal b = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("a * b = {0}", a * b);
}

void Subtraktion()
{
    {
        Console.WriteLine("Multiplikation");
        Console.Write("a: ");
        decimal a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("b: ");
        decimal b = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("a - b = {0}", a - b);
    }
}

Ende:;