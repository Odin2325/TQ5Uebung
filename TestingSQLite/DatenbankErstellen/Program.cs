using System.Data.SQLite;

namespace DatenbankErstellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string databaseFile = "Clients.db";

            string connectionString = @"Data Source=Clients.db;Version=3;";

            string createTable = @"
                    CREATE TABLE IF NOT EXISTS Clients (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT NOT NULL,
                        LastName TEXT NOT NULL,
                        Email TEXT NOT NULL
                    );";

            try
            {
                SQLiteConnection.CreateFile(databaseFile);
                Console.WriteLine("Datenbank Datei erfolgreich erstellt.");

                //Verbinden an Datenbankdatei
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Wir sind an unsere Datenbank verbunden.");

                    //TabelleErstellen
                    using (SQLiteCommand command = new SQLiteCommand(createTable, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Tabelle Clients erfolgreich erstellt.");
                    }

                    for(int i = 1; i<=300; i++)
                    {
                        string vorname = "Vorname" + i;
                        string nachname = "Nachname" + i;
                        string email = "Email" + i;
                        //INSERT INTO tabelleName (firstname, lastname, email)
                        //Values (@vorname,@nachname...)
                        string insertQuery = @"
                            INSERT INTO Clients (FirstName, LastName, Email)
                            VALUES (@FirstName, @LastName, @Email);";

                        using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", vorname);
                            command.Parameters.AddWithValue("@LastName", nachname);
                            command.Parameters.AddWithValue("@Email", email);
                            command.ExecuteNonQuery();
                        }
                    }
                    Console.WriteLine("300 Beispiels Werte Hinzugefuegt.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}
