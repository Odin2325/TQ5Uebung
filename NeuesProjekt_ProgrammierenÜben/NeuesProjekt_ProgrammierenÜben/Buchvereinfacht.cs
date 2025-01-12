using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuesProjekt_ProgrammierenÜben
{
    internal class BuchVereinfacht
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

        internal BuchVereinfacht(int seitenanzahl, string autor, string titel, string genre, string? auflage, string isbn, decimal preis, string erscheinungsjahr, string inhalt)
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
        }

        internal string InhalteLesen()
        {
            return inhalt;
        }


    }
}
