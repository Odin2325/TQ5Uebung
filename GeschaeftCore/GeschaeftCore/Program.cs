using System.Data.SQLite;

namespace GeschaeftCore
{
    internal class Program
    {
        /*
         * Wir moechten methoden schreiben um aus diese Datenbank informationen zu bekommen.
         * 1. KundeDetails()
         * 2. ProduktDetails()
         * 3. BestellungenSehen()
         * 4. BestellungNachKundeIDFinden()
         * 5. BestellungPreis()
         * 6. NeuerKundeHinzufuegen()
         * 7. KundeLoeschen(int id)
         * 8. ProduktHinzufuegen + Loeschen
         * 9. ProduktMengeVeraendern
         * 10.ProduktPreisVeraendern
         * 
         * Challenge: Datei Erstellen mit GeschaeftQ1Bericht
         * Alle Kunden auflisten
         * Alle Produkte mit menge und preis (ohne beschreibung oder material) auflisten
         * Alle Bestellungen auflisten mit Kunde - Produkt - GesamtPreis - MengeProduktGekauft
         * 
         * Kunden:
         * Name:                     - Adresse
         * Nicolas Arevalo Hoelscher - Muenchen
         * ...
         * 
         * ================================================
         * 
         * Produkte:
         * Name          - Menge - Preis
         * Kaffee Bohnen - 10    - $3.99
         * ...
         * 
         * ================================================
         * 
         * Bestellungen:
         * Kunde Name                   - Produkt Name  - MengeProduktGekauft - GesamtPreis
         * Nicolas Arevalo Hoelscher    - Kaffee Bohnen - 10                  - $39.90
         * ...
         * 
         * ================================================
         * 
         * GesamtGewinn = $43554.90
         */
        public static void CreateDatabase(string name)
        {
            SQLiteConnection.CreateFile($"{name}.sqlite");
            using (var connection = new SQLiteConnection($"Data Source={name}.sqlite;Version=3;"))
            {
                connection.Open();
                string sql = "CREATE TABLE Dinge (ID INTEGER PRIMARY KEY, Name TEXT, Menge INTEGER)";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Datenbank und Tabelle erstellt.");
        }

        public static void InsertTo(string databaseName, string name, int menge)
        {
            using (var connection = new SQLiteConnection($"Data Source={databaseName}.sqlite;Version=3;"))
            {
                connection.Open();
                string sql = "INSERT INTO Dinge (Name, Menge) VALUES (@name, @menge)";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@menge", menge);
                    command.ExecuteNonQuery();
                }
            }
            //Test test, wir machen veraenderungen...
            Console.WriteLine("Eintrag hinzugefügt.");
        }

        public static void ReadFrom(string databaseName)
        {
            using (var connection = new SQLiteConnection($"Data Source={databaseName}.sqlite;Version=3;"))
            {
                connection.Open();
                string sql = "SELECT * FROM Dinge";
                using (var command = new SQLiteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["ID"]}, Name: {reader["Name"]}, Menge: {reader["Menge"]}");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            CreateDatabase("TestDB");
            InsertTo("TestDB", "Cannabis", 10);
            InsertTo("TestDB", "Tabak", 5);
            ReadFrom("TestDB");
        }

    }
}
