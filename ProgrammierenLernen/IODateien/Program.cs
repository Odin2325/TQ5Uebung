namespace IODateien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("test.txt", "Hallo Welt");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        /// <exception cref="IOException"></exception>"
        public static void WriteToFile(string path, string text)
        {
            File.AppendAllText(path, text);
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
     * 
     */
}
