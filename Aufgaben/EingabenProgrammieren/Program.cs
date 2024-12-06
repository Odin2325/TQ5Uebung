
while (true)
{
    Console.WriteLine("Temperaturumrechnung: 1");
    Console.WriteLine("Zylinderberechnung:   2");
    Console.WriteLine("Zinseszins:           3");
    Console.Write("Wähle: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Temperaturumrechnung();
            break;
        case "2":
            Zylinderberechnung();
            break;
        case "3":
            Zinseszins();
            break;
        default:
            return;
    }
}

void Temperaturumrechnung()
{
    decimal celsius;

    Console.Write("Temperatur in Grad Celsius: ");

    if (!Eingabe(out celsius)) return;

    decimal fahrenheit = celsius * 1.8m + 32;

    Console.WriteLine($"{celsius} °C sind {fahrenheit} °F");
}

void Zylinderberechnung()
{
    decimal radius;
    decimal hoehe;

    Console.Write("Höhe des Zylinders: ");
    if (!Eingabe(out hoehe)) return;

    Console.Write("Radius des Zylinders: ");
    if (!Eingabe(out radius)) return;

    decimal huelle = 2 * radius * hoehe * (decimal)Math.PI;
    decimal oberflaeche = 2 * radius * (decimal)Math.PI * (radius + hoehe);
    decimal volumen = 2 * radius * hoehe * (decimal)Math.PI;


    Console.WriteLine($"Die Hülle ist {huelle}, die Gesamtoberfläche ist {oberflaeche} und das Volumen ist {volumen}");
}
void Zinseszins()
{
    return;

    // N?

    //decimal P;
    //decimal t;

    //Console.Write("Anfangsinvestition: ");
    //if (!Eingabe(out P)) return;

    //Console.Write("Dauer: ");
    //if (!Eingabe(out t)) return;

    //decimal A = P(1+)

    //Console.WriteLine($"{}")
}

bool Eingabe(out decimal eingabe)
{
    bool success = decimal.TryParse(Console.ReadLine(), out eingabe);
    if (!success)
    {
        Console.WriteLine("Falsche Eingabe");
    }

    return success;
}