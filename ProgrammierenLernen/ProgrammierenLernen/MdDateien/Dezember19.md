**Flugzeug Main Beispiel**

            Flugzeug a380 = new Flugzeug();

            Flugzeug boeing747 = new Flugzeug();

            boeing747.hersteller = "Boeing";
            boeing747.modell = "747";
            boeing747.sitzplaetze = 660;
            boeing747.reichweite = 14815;
            boeing747.maxGeschwindigkeit = 988;
            boeing747.flugHoehe = 13100;

            //Console.WriteLine(boeing747.hersteller);

            Console.WriteLine(Flugzeug.anzahlFlugzeuge);

            /*
             * Uebung1: 
             * Wir erstellen jetzt eine Klasse Auto.
             * Diese Klasse soll folgende Eigenschaften haben:
             * farbe
             * hersteller
             * modell
             * maxGeschwindigkeit
             * hat4WD
             * 
             * Ueberlegt euch 3 weitere Eigenschaften fuer die Klasse Auto.
             * Nachdem ihr die Klasse erstellt habt, erstellt 2 Objekte der Klasse Auto.
             */