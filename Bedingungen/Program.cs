void Aufgabe1()
{
    int eingabe;
    var random = new Random();
    int zufallszahl = random.Next(1, 101);

    do
    {
        Console.Write("Zahl raten zwischen 1 und 100: ");
        Eingabe(out eingabe);

        if (zufallszahl > eingabe)
        {
            Console.WriteLine("Zu klein!");
        }
        if (zufallszahl < eingabe)
        {
            Console.WriteLine("Zu groß!");
        }
        if (zufallszahl == eingabe)
        {
            Console.WriteLine("Treffer!");
        }
    } while (zufallszahl != eingabe);
}

void Aufgabe2()
{
    int temp;

    Console.Write("Temperatur: ");
    Eingabe(out temp);

    if (temp > 30)
    {
        Console.WriteLine("Es ist heiß. Trinke viel Wasser!");
    }
    else if (temp >= 15)
    {
        Console.WriteLine("Das Wetter ist angenehm.");
    }
    else
    {
        Console.WriteLine("Jackenwetter");
    }
}

void Aufgabe3()
{
    int wochentag;

    Eingabe(out wochentag);

    string ausgabe = wochentag switch
    {
        1 => "Montag",
        2 => "Dienstag",
        3 => "Mittwoch",
        4 => "Donnerstag",
        5 => "Freitag",
        6 => "Samstag",
        7 => "Sonttag",
        _ => "Ungültige Eingabe",
    };

    Console.WriteLine(ausgabe);
}

void Aufgabe4()
{
    int eingabe;
    string ausgabe;

    Console.Write("Zahl zwischen 1 und 20: ");
    Eingabe(out eingabe);

    if (eingabe < 10)
    {
        ausgabe = eingabe switch
        {
            2 => "Primzahl",
            3 => "Primzahl",
            5 => "Primzahl",
            7 => "Primzahl",
            _ => "Keine Primzahl"
        };
    }
    else
    {
        ausgabe = "Zahl zu groß für Überprüfung.";
    }

    Console.WriteLine(ausgabe);
}

void Aufgabe5()
{
    int alter;
    int wochentag;

    Console.Write("Alter: ");
    Eingabe(out alter);

    Console.Write("Wochentag: ");
    Eingabe(out wochentag);

    string eintritt = alter >= 18 ? "Normaler Eintritt" : "Ermäßigter Eintritt";
    string wochenende = wochentag >= 6 ? "Wochenende" : "Werktag";

    Console.WriteLine($"{eintritt} - {wochenende}");
}

void Eingabe(out int eingabe)
{
    while (!int.TryParse(Console.ReadLine(), out eingabe)) {
        Console.WriteLine("Ungültige Eingabe! Neuer Versuch:");
    }
}