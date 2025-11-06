**Beispiel Modulo**

int wert = 123475642;
int zahlModulo = 2;

Console.WriteLine("Ist der Wert " + wert + " durch " + zahlModulo + " teilbar? " + (wert%zahlModulo == 0));



**Noten Aufgabe**

//Variablen Erstellen

double anzahlNoten = 5;

int sophiaBiologie = 93;
int sophiaPhysik = 80;
int sophiaLK = 78;
int sophiaMathe = 50;
int sophiaChemie = 70;

int nicolasBiologie = 89;
int nicolasPhysik = 70;
int nicolasLK = 100;
int nicolasMathe = 90;
int nicolasChemie = 70;

int jeongBiologie = 93;
int jeongPhysik = 30;
int jeongLK = 96;
int jeongMathe = 90;
int jeongChemie = 99;


int summeSophia = sophiaBiologie + sophiaPhysik + sophiaLK + sophiaMathe + sophiaChemie;
int summeNicolas = nicolasBiologie + nicolasPhysik + nicolasLK + nicolasMathe + nicolasChemie;
int summeJeong = jeongBiologie + jeongPhysik + jeongLK + jeongMathe + jeongChemie;
Console.WriteLine("Summe Noten: \n");
Console.WriteLine($"Sophia: {summeSophia}");
Console.WriteLine("Nicolas: " + summeNicolas);
Console.WriteLine("Joeng: " + summeJeong);
Console.WriteLine("\n---------------------------------\n");

double durchschnittSophia = summeSophia / anzahlNoten;
double durchschnittNicolas = summeNicolas / anzahlNoten;
double durchschnittJeong = summeJeong / anzahlNoten;


Console.WriteLine("Endgueltige Noten: \n");
Console.WriteLine($"Sophia: \t{durchschnittSophia} \t C");
Console.WriteLine("Nicolas: \t" + durchschnittNicolas + "\t B");
Console.WriteLine("Joeng: \t\t" + durchschnittJeong + "\t B-");
Console.WriteLine("\n---------------------------------\n");

**Platzhalter**

