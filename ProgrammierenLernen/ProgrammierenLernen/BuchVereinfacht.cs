using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenLernen
{
    /*
     * Methode: Buch Details anzeigen: string zurueckgeben in die Form: "Autor: {autor}, Titel: {titel}, Genre: {genre}, Auflage: {auflage}, ISBN: {isbn}, Preis: {preis}, Erscheinungsjahr: {erscheinungsjahr}"
     * Properties fuer unsere Variablen erstellen.
     */
    public class BuchVereinfacht
    {
        int seitenanzahl;
        string autor;
        string titel;
        string genre;
        string? auflage;
        string isbn;
        decimal ausleihKosten;
        string erscheinungsjahr;
        string inhalt;
        DateOnly rueckgabeDatum;

        public BuchVereinfacht(int seitenanzahl, string autor, string titel, string genre, string? auflage, string isbn, decimal ausleihKosten, string erscheinungsjahr, string inhalt, DateOnly rueckgabeDatum)
        {
            this.seitenanzahl = seitenanzahl;
            this.autor = autor;
            this.titel = titel;
            this.genre = genre;
            this.auflage = auflage;
            this.isbn = isbn;
            this.ausleihKosten = ausleihKosten;
            this.erscheinungsjahr = erscheinungsjahr;
            this.inhalt = inhalt;
            this.rueckgabeDatum = rueckgabeDatum;
        }

        public int Seitenanzahl { get => seitenanzahl; }
        public string Autor { get => autor; }
        public string Titel { get => titel; }
        public string Genre { get => genre; }
        public string? Auflage { get => auflage; }
        public string ISBN { get => isbn; }
        public decimal Preis { get => ausleihKosten; }
        public string Erscheinungsjahr { get => erscheinungsjahr; }

        public string InhalteLesen { get => inhalt; }
        public DateOnly RueckgabeDatum { get => rueckgabeDatum; }


        public string BuchDetailsAnzeigen()
        {
            return $"Autor: {autor}, Titel: {titel}, Genre: {genre}, Auflage: {auflage}, ISBN: {isbn}, Preis: {ausleihKosten}, Erscheinungsjahr: {erscheinungsjahr}";
        }
    }
}
