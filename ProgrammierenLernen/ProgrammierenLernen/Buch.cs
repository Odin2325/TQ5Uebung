using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenLernen
{
    internal class Buch
    {
        int seitenanzahl;
        string autor;
        string titel;
        string genre;
        string? auflage;
        string isbn;
        decimal preis;
        string erscheinungsjahr;
        string inhalt;
        //public (int nummer, string[] inhalt)[] seiten;
        
        internal Buch(int seitenanzahl, string autor, string titel, string genre, string? auflage, string isbn, decimal preis, string erscheinungsjahr, string inhalt)
        {
            this.seitenanzahl = seitenanzahl;
            this.autor = autor;
            this.titel = titel;
            this.genre = genre;
            this.auflage = auflage;
            this.isbn = isbn;
            this.preis = preis;
            this.erscheinungsjahr = erscheinungsjahr;
            this.inhalt = inhalt;
            //this.seiten = new (int nummer, string[] inhalt)[seitenanzahl];
            //BuchBefuellen();
        }

        internal string InhalteLesen()
        {
            return inhalt;
        }

        //private void BuchBefuellen()
        //{
        //    string[] inhaltDatei;
        //    foreach (string file in Directory.GetFiles("C:\\Users\\MYTQ-Trainer\\Documents\\GitHub\\TQ5Uebung\\Buecher"))
        //    {
        //        if ((file).ToLower().Contains(titel.ToLower()))
        //        {
        //            inhaltDatei = File.ReadAllLines(file);
        //            //seiten = inhaltDatei.Chunk(30).Select((zeilen, index) => (index + 1, zeilen)).ToArray();
        //            BuchBefuellenNoLambda2(inhaltDatei, 30);
        //            return;
        //        }
        //    }
        //}

        //public void BuchBefuellenNoLambda(string[] inhaltDatei, int chunkSize)
        //{
        //    var result = new List<(int nummer, string[] inhalt)>();
        //    int totalChunks = (int)Math.Ceiling((double)inhaltDatei.Length / chunkSize);

        //    for (int i = 0; i < totalChunks; i++)
        //    {
        //        int start = i * chunkSize;
        //        int count = Math.Min(chunkSize, inhaltDatei.Length - start);
        //        var chunk = new string[count];

        //        Array.Copy(inhaltDatei, start, chunk, 0, count);
        //        result.Add((i + 1, chunk));
        //    }

        //    seiten = result.ToArray();
        //}

        //void BuchBefuellenNoLambda2(string[] inhaltDatei, int chunkSize)
        //{
        //    var result = new List<(int nummer, string[] inhalt)>();

        //    int seitennummer = 1;
        //    foreach (var zeilen in inhaltDatei.Chunk(chunkSize))
        //    {
        //        result.Add((seitennummer, zeilen));
        //        seitennummer++;
        //    }

        //    seiten = result.ToArray();
        //}

        //internal void OutputBook()
        //{
        //    foreach(var seite in seiten)
        //    {
        //        InhalteLesen(seite.nummer);
        //    }
        //}


        //internal string[] SeiteAufschlagen(int seiteNummer)
        //{
        //    foreach(var seite in seiten)
        //    {
        //        if(seiteNummer == seite.nummer)
        //        {
        //            return seite.inhalt;
        //        }
        //    }
        //    return null;
        //}



        //internal void InhalteLesen(int seiteNummer)
        //{
        //    foreach(var zeile in SeiteAufschlagen(seiteNummer))
        //    {
        //        Console.WriteLine(zeile);
        //    }
        //}

        //Klasse besteht aus:
        //Eigenschaften/Attributen
        //Methoden/Funktionen
        /*
         * Attributen:
         * seitenanzahl = int
         * autor = string
         * titel = string
         * genre = string
         * auflage = int
         * isbn = string
         * preis = decimal
         * inhalt = (int, string[])[] seiten = new (int, string[])[300];
         * 
         * Methoden/Funktionen
         * seiteAufschlagen => parameter: seite reuckgabewert: string[] 
         * inhalteLesen => parameter: zuletztGeleseneSeite
         */


    }
}
