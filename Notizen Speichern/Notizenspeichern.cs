namespace NotizenSpeichern
{
    /// <summary>
    /// Diese Klasse bietet Methoden, um Text in Dateien zu speichern und auszulesen.
    /// </summary>
    public class FileManager
    {
        /// <summary>
        /// Speichert den angegebenen Text in einer Datei an dem definierten Pfad.
        /// </summary>
        /// <param name="filePath">Der Pfad, wo die Datei gespeichert werden soll.</param>
        /// <param name="text">Der Text, der in die Datei geschrieben werden soll.</param>
        /// <exception cref="IOException">Wird ausgelöst, wenn beim Zugriff auf die Datei ein Fehler auftritt.</exception>
        public static void SaveToFile(string filePath, string text)
        {
            try
            {
                // Datei erstellen und Text schreiben
                File.AppendAllText(filePath, text + Environment.NewLine);
                Console.WriteLine("Der Text wurde erfolgreich gespeichert.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }

        /// <summary>
        /// Liest den Inhalt der angegebenen Datei und gibt ihn in der Konsole aus.
        /// </summary>
        /// <param name="filePath">Der Pfad der Datei, die gelesen werden soll.</param>
        /// <exception cref="FileNotFoundException">Wird ausgelöst, wenn die Datei nicht existiert.</exception>
        public static void ReadFromFile(string filePath)
        {
            try
            {
                // Prüfen, ob die Datei existiert
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("Die angegebene Datei wurde nicht gefunden.");
                }

                // Datei lesen und ausgeben
                string content = File.ReadAllText(filePath);
                Console.WriteLine("Inhalt der Datei:");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            }
        }
    }

    class Notizenspeichern
    {
        /// <summary>
        /// Hauptprogramm zur Interaktion mit dem Benutzer.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen im Notizen-Speicher!");

            while (true)
            {
                Console.WriteLine("\nMöchten Sie:");
                Console.WriteLine("S - Neue Informationen zu einer Datei schreiben");
                Console.WriteLine("A - Informationen von einer Datei auslesen");
                Console.WriteLine("B - Beenden");
                Console.Write("Ihre Auswahl: ");
                string choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "S":
                        // Benutzer nach dem Dateipfad fragen
                        Console.Write("Bitte geben Sie den Pfad der Datei ein, in die Sie schreiben möchten: ");
                        string writePath = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(writePath))
                        {
                            Console.WriteLine("Ungültiger Pfad. Bitte versuchen Sie es erneut.");
                            continue;
                        }

                        // Benutzer nach dem Text fragen
                        Console.Write($"Was möchten Sie in die Datei '{Path.GetFileName(writePath)}' schreiben? ");
                        string text = Console.ReadLine();

                        // Speichern
                        FileManager.SaveToFile(writePath, text);
                        break;

                    case "A":
                        // Benutzer nach dem Dateipfad fragen
                        Console.Write("Bitte geben Sie den Pfad der Datei ein, die Sie lesen möchten: ");
                        string readPath = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(readPath))
                        {
                            Console.WriteLine("Ungültiger Pfad. Bitte versuchen Sie es erneut.");
                            continue;
                        }

                        // Datei lesen
                        FileManager.ReadFromFile(readPath);
                        break;

                    case "B":
                        Console.WriteLine("Programm wird beendet. Auf Wiedersehen!");
                        return;

                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie S, A oder B.");
                        break;
                }
            }
        }
    }
}
