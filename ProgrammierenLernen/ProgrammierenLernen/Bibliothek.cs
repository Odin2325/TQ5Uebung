using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenLernen
{
    internal class Bibliothek
    {
        /*
         * Fields:
         * name, adresse, kundenListe, katalog.
         * dictionary buch : anzahlBuecher
         * 
         * Methoden:
         * Details() => wir moechten name, adresse und katalog.Count.
         * KatalogAusgeben() => Wir geben alle Buecher in unser Katalog zurueck und auch die anzahlen.
         * "
         * Buch Name            |Buch Anzahl
         * Prisoner of Azkaban  |3
         * Musterman Adventures |19
         * "
         * private Methode bool istKunde(kunden)
         * bool KundeBuchRueckgabe(kunden) => ist er/sie ein kunde? wenn ja darf er ein buch zurueckgeben
         * d.h. das buch soll aus den kunden ausgeliehen buecher array entfernt werden und zu den katalog hinzugefuegt werden.
         * Bedeutet anzahlBuecher erhoehen. Nur aber wenn das Buch in unser katalog definiert ist.
         * 
         * bool KundeBuchAusleihen(kunden, buch) => Wert aus katalog entfernen (anzahlBuecher reduzieren).
         * kunde.BuchAusleihen(buch) aufrufen um ihn das buch zu geben.
         * Dies soll aber nur funktionieren wenn der kunde weniger als 3 buecher hat.
         * 
         * Buecher kaufen methode womit wir buecher zu den katalog hinzufuegen. Wir moechten eins oder mehrere auf einmal hinzufuegen koennen.
         * 
         * Buecher entfernen methode womit wir buecher aus unser katalog permanent entfernen.
         * 
         * Danach auch Testing machen, auch alles mit XML Kommentare dokumentieren und dann in docfx erstellen.
         */
    }
}
