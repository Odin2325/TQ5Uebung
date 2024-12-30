using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{
    internal class Buch
    {
        protected int seitenanzahl;
        protected string autor;
        public string titel { get; set; }
        protected string genre;
        protected string? auflage;
        protected string isbn;
        protected decimal preis;
        protected string erscheinungsjahr;

        public Buch(int seitenanzahl, string autor, string titel, string genre, string? auflage, string isbn, decimal preis, string erscheinungsjahr)
        {
            this.seitenanzahl = seitenanzahl;
            this.autor = autor;
            this.titel = titel;
            this.genre = genre;
            this.auflage = auflage;
            this.isbn = isbn;
            this.preis = preis;
            this.erscheinungsjahr = erscheinungsjahr;
        }
    }
    }
