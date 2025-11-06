**Beispiel Division Aufgabe mit Alter**

int summe;
double durchschnitt;
int alterNico = 90;
int alterAfsoon = 24;
int alterStalone = 25;
int alterHugo = 20;
            
//Durchschnitt formel summe aller werte / anzahl werte
//Resultat auf konsole ausgeben.

summe = alterNico + alterAfsoon + alterStalone + alterHugo;

//159
int alterSonja = 18;
//summe = summe + alterSonja;
summe += alterSonja;
//177
durchschnitt = summe / 5.0;
Console.WriteLine("Summe: " + summe);
Console.WriteLine("Durchschnitt: " + durchschnitt);


**Uebung Volume Cube**

/*
* Volume von einen kubus berechnen moechten.
* Gehen davon aus wir haben eine variable laenge die wir benutzen duerfen
* Programm soll so aussehen:
* 
* Program Start...
* Wir berechnen den Volumen von einen Cube...
* Laenge ist: 12...
* Volume ist: 12*12*12...
*/
//int laenge = 12;
//int volume = 12 * 12 * 12;

//Console.WriteLine("Program Start...");
//Console.WriteLine("Wir berechnen den Volumen von einen Cube...");
//Console.WriteLine("Laenge ist: " + laenge + "...");
//Console.WriteLine("Volume ist: " + volume + "...");

//int laenge = 12;

//int volumeCube = 12 * 12 * 12;

//Console.WriteLine("Program Start...");

//Console.WriteLine(volumeCube);


**Explizite Typ Konvertierungen**

Wir können Werte Explizit mit funktionen Konvertieren.
Dafür haben wir ein paar optionen.
1. Von etwas in int => int.TryParse(wasWirKonvertierenMoechten, out int variableWoWirDenResultatSpeichern)
int nur angeben, wenn die Variable noch erstellt werden muss.
Diese Methode Liefert auch einen Boolean als Resultat Zurück was wir auch abspeichern könnten.
1. Mit Convert.ToInt32() können wir zu einen int konvertieren. Es gibt in die Klasse Convert, viele unterschiedliche Methode um Typen zu konvertieren.
1. Viele Datentypen variablen haben die möglichkeit die Methode .ToString() von sich aufzurufen um sich zu einen String zu konvertieren.

*Beispiel:*

string laengeStringVersion = "1287654324567897654678765678765467879897857567678574556";

bool hatFunktioniert = int.TryParse(laengeStringVersion, out int laenge);

Console.WriteLine(hatFunktioniert);

Console.WriteLine(laenge*laenge*laenge);

*Beispiel 2:*

/*
* Wir haben die variable decimal geld = 300.50m
* Wir moechten jetzt den datentyp float haben.
* float gewechselterTyp;
* Ausgabe soll folgendermassen aussehen: 
* Console.WriteLine("Der Typ der variable ist: " + gewechselterTyp.GetType());
* Console.WriteLine("Wert = " + gewechselterTyp);
*/

**Benutzer Eingaben**