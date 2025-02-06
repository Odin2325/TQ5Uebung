**Beispiel 2d Array**

    //2d array
    int[,] werte = new int[2,4];
    //[[10,2,3,4],[5,6,7,8]]
    //  0 1 2 3   0 1 2 3
    //     0         1

    werte[0, 0] = 10;

**Method Overloading**

    //Method Overloading!
    //Mehrere Methoden mit den gleichen namen.
    //Parameter muessen sich jedoch unterscheiden.
    //Rueckgabetyp aendern => egal
    //Code block ist anders => egal

**Einkaufsliste in Datei speichern**

        List<string> unsereEinkaufsListe = EinkaufsListeGenerator();

        Console.WriteLine(unsereEinkaufsListe);

        File.WriteAllLines("einkaufsliste.txt", unsereEinkaufsListe);

**Pangram Aufgabe Kommentare**

            /*
             * Schritt 1: Satz aufteilen - Done
             * Schritt 2: Einzelner Wort in array konvertieren - Done
             * Schritt 3: Wort umdrehen - Done
             * Schritt 4: Dies in eine schleife fuer der ganze satz machen. - Done
             * Schritt 5: Woerter danach in string wieder umwandeln. - Done
             * Schritt 6: Alle woerter wieder in einen einzelnen string kombinieren. - Done
             * Schritt 7: Ausgeben => Fertig
             */