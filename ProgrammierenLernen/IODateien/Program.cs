namespace IODateien
{
    /// <summary>
    /// Unsere Methode um Dateien Informationen zu schreiben und zu lesen.
    /// </summary>
    public class IOAufgaben
    {
        /// <summary>
        /// Schreibt Informationen in eine Datei.
        /// </summary>
        /// <param name="path">Der Pfad zu die gewuenschte Datei.</param>
        /// <param name="text">Die Informationen die gespeichert werden sollen.</param>
        /// <exception cref="IOException"></exception>"
        public static void WriteToFile(string path, string text)
        {
            File.AppendAllText(path, text);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("test.txt", "Hallo Welt");
        }
    }
    /*
     * Moechten Sie neue Informationen zu eine Datei schreiben (S) oder Informationen von eine Datei auslesen (A) oder Beenden (B)?
     * ER
     * Ungueltige eingabe bitte nur S oder A oder B eingeben
     * S
     * Zu welche Datei moechten Sie schreiben?
     * eefhkjlfswsf
     * Ungueltiger Pfad bitte geben Sie einen gueltigen Pfad ein
     * Desktop/Files/ChatLogs.txt
     * Was moechten Sie zu die Datei "ChatLogs" schreiben?
     * Hallo ich bin Nicolas
     * 
     * Es wurde erfolgreich abgespeichert.
     * Console.Clear();
     * Moechten Sie neue Informationen zu eine Datei schreiben (S) oder Informationen von eine Datei auslesen (A) oder Beenden (B)?
     */
}
