// Aufgabe 1

int Fak(int value)
{
    if (value < 0) throw new ArgumentException("Value must be non-negative");

    if (value == 0)
    {
        return 1;
    }

    return value * Fak(value - 1);
}

Console.WriteLine(Fak(0));
Console.WriteLine(Fak(1));
Console.WriteLine(Fak(5));
Console.WriteLine(Fak(14)); 
Console.WriteLine(Fak(20)); // man müsste auf Überlauf prüfen 🤔


// Aufgabe 2

void Gerade(int grenze)
{
    for (int i = 0; i <= grenze; i += 2)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

Gerade(11);


// Aufgabe 3

bool Prime(int candidate)
{
    if (candidate < 1) throw new ArgumentException("Candidate must greater than zero");

    if (candidate == 1) return false;
    if (candidate == 2) return true;

    for (int div = 2; div * div <= candidate; div++)
    {
        if (candidate % div == 0)
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine(Prime(2));
Console.WriteLine(Prime(5));
Console.WriteLine(Prime(11));
Console.WriteLine(Prime(51));
Console.WriteLine(Prime(26099));


// Aufgabe 4

void PrintPrimes(int limit)
{
    if (limit < 2) return;

    Console.Write("Primzahlen: 2");

    for (int i = 3; i <= limit; i++)
    {
        if (Prime(i)) Console.Write($", {i}");
    }
}

PrintPrimes(100);