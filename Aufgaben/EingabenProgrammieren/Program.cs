
while (true)
{
    Console.WriteLine("Temperaturumrechnung: 1");
    Console.WriteLine("Zylinderberechnung:   2");
    Console.WriteLine("Zinseszins:           3");
    Console.WriteLine("Großbuchstaben:       4");
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
        case "4":
            Großbuchstaben();
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

    decimal fahrenheit = CelsiusToFahrenheit(celsius);

    Console.WriteLine($"{celsius} °C sind {fahrenheit} °F");
}

decimal CelsiusToFahrenheit(decimal celsius)
{
    return celsius * 1.8m + 32;
}

void Zylinderberechnung()
{
    decimal radius;
    decimal hoehe;

    Console.Write("Höhe des Zylinders: ");
    if (!Eingabe(out hoehe)) return;

    Console.Write("Radius des Zylinders: ");
    if (!Eingabe(out radius)) return;

    decimal huelle = ZylinderHuelle(radius, hoehe);
    decimal oberflaeche = ZylinderOberfläche(radius, hoehe);
    decimal volumen = ZylinderVolumen(radius, hoehe);

    Console.WriteLine($"Die Hülle ist {huelle}, die Gesamtoberfläche ist {oberflaeche} und das Volumen ist {volumen}");
}

decimal ZylinderHuelle(decimal radius, decimal hoehe)
{
    return 2 * radius * hoehe * (decimal)Math.PI;
}

decimal ZylinderOberfläche(decimal radius, decimal hoehe)
{
    return 2 * radius * (decimal)Math.PI * (radius + hoehe);
}

decimal ZylinderVolumen(decimal radius, decimal hoehe)
{
    return 2 * radius * hoehe * (decimal)Math.PI;
}

void Zinseszins()
{
    decimal n = 1m;
    decimal r = 0.04m;
    decimal P;
    decimal t;

    Console.Write("Anfangsinvestition: ");
    if (!Eingabe(out P)) return;

    Console.Write("Dauer: ");
    if (!Eingabe(out t)) return;

    decimal A = ZinsesZinsBerechnen(P, r, t, n);

    Console.WriteLine(
            $"Nach Anlegen von {P} über {n} Jahre bei einem Zinssatz von " +
            $"{r} p.a. sind auf dem Konto: {A}"
        );
}

decimal ZinsesZinsBerechnen(decimal P, decimal r, decimal t, decimal n)
{
    return P * (decimal)Math.Pow((double)((1 + r / n)), (double)(n * t));
}

void Großbuchstaben()
{
    Console.WriteLine("Was möchtest du konvertieren? ");
    string eingabe = Console.ReadLine();

    Console.WriteLine(eingabe.ToUpper());
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