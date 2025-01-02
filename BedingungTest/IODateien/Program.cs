using System.Linq.Expressions;

namespace IODateien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Möchten Sie \n" +
                                "neue Informationen zu eine Datei schreiben (S) \n" +
                                "oder Informationen von eine Datei auslesen (A) \n" +
                                "oder Beenden (B)? ");
            // S / A / B

            string input = Console.ReadLine().ToUpper();
            while (true)
            {
                switch (input)
                {
                    case "S":

                        DateiSchreiben();
                        Console.ReadKey();
                        break;

                    case "A":
                        DateiLesen();
                        Console.ReadKey();
                        break;

                    case "B":
                        Console.WriteLine("Programm beendet.");
                        return;

                    default:
                        Console.WriteLine("Ungültige Eingabe, bitte nur S, A oder B eingeben.");
                        break;
                }
                Console.Clear();
                Console.Write("Möchten Sie neue Informationen zu eine Datei schreiben (S) \n " +
                                "oder Informationen von eine Datei auslesen (A) \n " +
                                " oder Beenden (B)?");

                 input = Console.ReadLine().ToUpper();

            }
        }
        /// <summary>
        /// Writes user input to a specified file.
        /// If the file does not exist, it will be created automatically.
        /// 
        /// </summary>
        /// <exception cref="IOException"
        static void DateiSchreiben()
        { 
            try
            {
                Console.WriteLine("Zu welche Datei moechten Sie schreiben: ");
                string dateiPfad = Console.ReadLine();
                /*
                 *   string path1 = @"C:\Users\Documents\file.txt";  true
                 *   string path2 = @"file.txt";                     false
                 *   string path3 = @"\\server\share\file.txt";      true
                 *   
                 *   Path.IsPathRooted(filePath)
                 */
                if (string.IsNullOrWhiteSpace(dateiPfad) || !Path.IsPathFullyQualified(dateiPfad))
                {
                    Console.WriteLine("Ungültiger Pfad, bitte geben Sie einen gültigen Pfad ein.");
                    return;
                }
                string fileName = Path.GetFileName(dateiPfad);
                Console.WriteLine($"Was möchten Sie zur Datei \"{fileName}\" schreiben?");
                
                string text = Console.ReadLine();                
                File.AppendAllText(dateiPfad, text +" \n");
                Console.WriteLine("Die Informationen wurden erfolgreich abgespeichert.");

            }
            catch(Exception ex) 
            {
                Console.WriteLine("An error occurred: " + ex.Message);

            }
        }



        /// <summary>
        /// Ermöglicht dem Benutzer, den Inhalt einer Datei zu lesen.
        /// </summary>
        /// <exception cref="IOException"/>
        public static void DateiLesen()
        {
            try
            {
                Console.WriteLine("Von welcher Datei möchten Sie Informationen auslesen?");
                string dateiPfad = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(dateiPfad) || !File.Exists(dateiPfad))
                {
                    Console.WriteLine("\n\n **  Ungültiger Pfad oder Datei existiert nicht. Bitte geben Sie einen gültigen Pfad ein.");
                    return;
                }

                string content = File.ReadAllText(dateiPfad);
                Console.WriteLine($"Inhalt der Datei \"{Path.GetFileName(dateiPfad)}\": \n\n");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }
    }
}
