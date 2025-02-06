int test = 99;
int zahl = 10;

if (zahl < 0 || test > 20)
{

}

switch (zahl)
{
    case <0 or >20:
            break;
}

bool istGueltig = zahl switch
{
    < 0 or > 20 => false
};

**Schleifen**

int wert = 0;
do
{
    Console.WriteLine("Geben Sie mir einen Wert zwischen 1-10: ");
    int.TryParse(Console.ReadLine(), out wert);
    if(wert == 11)
    {
        continue;
        //Springe zu bedingung hin und ueberpruefe es nochmal.
        //Gehe in die naechste iteration.
    }

} while (wert > 10 || wert < 1);
//Im fall direkt richtige antwort => 1mal bedingung ueberprueft


while (wert > 10 || wert < 1)
{
    Console.WriteLine("Geben Sie mir einen Wert zwischen 1-10: ");
    int.TryParse(Console.ReadLine(), out wert);
    if (wert == 99)
    {
        Console.WriteLine("Sonderfall gefunden!");
        break;
    }
}
//Im fall direkt richtige antwort => 2mal bedinung ueberprueft

**Schleife Beispiel While**
int i = 0;
string text = "Dies ist ein Test";
int j = 500;
while (i < 10)
{
    if (i == 5)
    {
        Console.WriteLine("Halbwegs durch.");
        Console.WriteLine("Wir ueberspringen die Zahl 51.");
        i += 2;
        continue;
                    
    }
    Console.WriteLine($"Zahl: {i}");
    i++;
}