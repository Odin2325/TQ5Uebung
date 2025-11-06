**Array Anfang**

	//   0     1     2     3     4     5     6     7     8...
	//[false|false|false|false|false|false|false|true|false|false|false|false|false|false|false|false|false|false|false|false|false|false]
	bool[] garageBesetzt = new bool[30];

	garageBesetzt[7] = true;

	garageBesetzt[7] = false;

	Console.WriteLine(garageBesetzt[2]);

	**Beispiel Summe**

	int[] zahlen = [1, 43, 5, 65, 43, 23, 23, 65, 67, 87];
	zahlen.Sum();

**Foreach**

	string satz = "Hallo, mein name ist Nicolas.";
	string[] aufgeteilterSatz = satz.Split(' ');


	foreach(string wort in aufgeteilterSatz)
	{
	Console.WriteLine(wort);
	}

**Einfache Schleifen Uebung plus String[] beispiel**

	string satz = "Hallo, mein name ist Nicolas.";
    string[] aufgeteilterSatz = satz.Split(' ');


    foreach(string wort in aufgeteilterSatz)
    {
        Console.WriteLine(wort);
    }

    /*
    * Schreibt eine Methode die die Summe von einen int[] berechnet und zurueckgibt.
    * Rueckgabetyp soll int sein und parameter soll int[] sein.
    */

**Array Join Beispiel**

    /*
    * Aufgabe 1: Wir erstellen unsere eigene Join methode.
    * Die Methode Join() nimmt 2 parameter.
    * Einmal einen Array und einmal einen seperator.
    * Wir werden dann jedes element aus dieser Array in einen String verketten muessen.
    * Und mit den seperator teilen.
    * Bspw: Eingabe: array=["Hallo","ich","bin","Nicolas"], seperator='-'
    * Ausgabe erzeugen als String und zurueckgeben mit return: 
    * "Hallo-ich-bin-Nicolas"
    */

**Null**

            string[] neuerArr = new string[10];
            //0
            //null
            //""
            if (neuerArr[0] == null)
            {
                Console.WriteLine("Ist null");
            }
            else if(neuerArr[0] == "")
            {
                Console.WriteLine("Ist leerer string");
            }
            else
            {
                Console.WriteLine("Etwas anderes.");
            }

**Uebungen**

    /*
    * Aufgabe 1: Wir erstellen unsere eigene Join methode.
    * Die Methode Join() nimmt 2 parameter.
    * Einmal einen Array und einmal einen seperator.
    * Wir werden dann jedes element aus dieser Array in einen String verketten muessen.
    * Und mit den seperator teilen.
    * Bspw: Eingabe: array=["Hallo","ich","bin","Nicolas"], seperator='-'
    * Ausgabe erzeugen als String und zurueckgeben mit return: 
    * "Hallo-ich-bin-Nicolas"
    * 
    * Aufgabe 2: Erstellt eine Print array Methode, die einen string[]
    * in diese form ausgibt:
    * Eingabe: array=["Hallo","ich","bin","Nicolas"]
    * Ausgabe: {Hallo, ich, bin, Nicolas}
    * Rueckgabe typ dieser Methode soll void sein.
    * 
    * Aufgabe 3: Eine Reverse Methode erstellen.
    * Wo wir als eingabe parameter einen int[] bekommen.
    * Dies soll dann in die umgekeherte reihenfolge zurueckgegeben werden.
    * Eingabe: array=[1,2,3,4]
    * ausgabe=[4,3,2,1]
    * Rueckgabe typ dieser Methode soll int[] sein.
    * 
    * Aufgabe 4: FindIndexVonWert methode schreiben.
    * Hier sollen wir einen double[] als eingabe parameter bekommen.
    * Wir bekommen zusaetzlich eine andere Zahl als eingabe parameter.
    * Wenn diese Zahl in das array enthalten ist => geben wir den index vom ersten vorkommen dieser Zahl aus.
    * Ansonsten (zahl nicht enthalten) => -1 ausgeben.
    */