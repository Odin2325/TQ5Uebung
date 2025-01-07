using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{
    public class Buch
    {
        int seitenanzahl;
        string autor;
        string titel;
        string genre;
        string isbn;
        decimal kosten;
        string erscheinungsjahr;
        DateTime aufnahmedatum;

        public Buch(int seitenanzahl, string autor, string titel, string genre, string isbn, string erscheinungsjahr, DateTime aufnahmedatum)
        {
            this.seitenanzahl = seitenanzahl;
            this.autor = autor;
            this.titel = titel;
            this.genre = genre;
            this.isbn = isbn;
            this.erscheinungsjahr = erscheinungsjahr;
            this.aufnahmedatum = aufnahmedatum;
            this.kosten = KostenFestlegen();
        }
        public int Seitenanzahl { get => seitenanzahl; }
        public string Autor { get => autor; }
        public string Titel { get => titel; }
        public string Genre { get => genre; }
        public string ISBN { get => isbn; }
        public decimal Kosten { get => kosten; }
        public string Erscheinungsjahr { get => erscheinungsjahr; }
        public DateTime Aufnahmedatum { get => aufnahmedatum; }


        public string BuchDetailsAnzeigen()
        {
            return $"Autor: {autor}, Titel: {titel}, Genre: {genre}, ISBN: {isbn}, Gebühren: {kosten}, Erscheinungsjahr: {erscheinungsjahr}";
        }
        internal decimal KostenFestlegen()
        {
            decimal kosten = 0m;
            if (genre == "Kinder" || genre == "Bildung")
                return kosten;
            else if ((DateTime.Today - aufnahmedatum.Date).Days < 256)
                kosten = 1.0m;
            else
                kosten = 0.5m;
            return kosten;
        }
    }
    }
