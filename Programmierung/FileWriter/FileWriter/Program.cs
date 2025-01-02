using FileWriter.utils;
using System;
using System.IO;
using System.Text;

class Program
{
    private static Outputs? outputs;
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        outputs = new Outputs();

        bool running = true;

        while (running)
        {
            outputs.NormalOutput("Hey, was willst du tun?");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Datei erstellen");
            sb.AppendLine("2. Datei löschen");
            sb.AppendLine("3. Datei beschreiben");
            sb.AppendLine("4. Datei überschreiben");
            sb.AppendLine("5. Beenden");
            Console.WriteLine(sb.ToString());

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateFile();
                    break;
                case "2":
                    DeleteFile();
                    break;
                case "3":
                    AppendToFile();
                    break;
                case "4":
                    OverwriteFile();
                    break;
                case "5":
                    outputs.NormalOutput("Programm wird beendet...");
                    running = false;
                    break;
                default:
                    outputs.ErrorOutput("Ungültige Eingabe. Bitte wähle eine Option von 1 bis 5.");
                    break;
            }
        }
    }

    static void CreateFile()
    {
        string path = GetPath();

        outputs?.NormalOutput("Gib den Dateinamen ein: ");
        string fileName = Console.ReadLine();

        string fullPath = Path.Combine(path, fileName);

        if (!File.Exists(fullPath))
        {
            File.Create(fullPath).Close();
            outputs?.SuccessOutput($"Datei '{fullPath}' wurde erstellt.");
        }
        else
        {
            outputs?.ErrorOutput("Datei existiert bereits.");
        }
    }

    static void DeleteFile()
    {
        string path = GetPath();

        outputs?.NormalOutput("Gib den Dateinamen ein: ");
        string fileName = Console.ReadLine();

        string fullPath = Path.Combine(path, fileName);

        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
            outputs?.SuccessOutput($"Datei '{fullPath}' wurde gelöscht.");
        }
        else
        {
            outputs?.ErrorOutput("Datei nicht gefunden.");
        }
    }

    static void AppendToFile()
    {
        string path = GetPath();

        outputs?.NormalOutput("Gib den Dateinamen ein: ");
        string fileName = Console.ReadLine();

        string fullPath = Path.Combine(path, fileName);

        if (File.Exists(fullPath))
        {
            outputs?.NormalOutput("Gib den Text ein, der angehängt werden soll: ");
            string content = Console.ReadLine();

            File.AppendAllText(fullPath, content + Environment.NewLine);
            outputs?.SuccessOutput("Text wurde angehängt.");
        }
        else
        {
            outputs?.ErrorOutput("Datei nicht gefunden.");
        }
    }

    static void OverwriteFile()
    {
        string path = GetPath();

        outputs?.NormalOutput("Gib den Dateinamen ein: ");
        string fileName = Console.ReadLine();

        string fullPath = Path.Combine(path, fileName);

        if (File.Exists(fullPath))
        {
            outputs?.NormalOutput("Gib den neuen Text ein: ");
            string content = Console.ReadLine();

            File.WriteAllText(fullPath, content);
            outputs?.SuccessOutput("Datei wurde überschrieben.");
        }
        else
        {
            outputs?.ErrorOutput("Datei nicht gefunden.");
        }
    }

    static string GetPath()
    {
        outputs?.NormalOutput("Gib den Pfad ein, in dem die Aktion ausgeführt werden soll: ");
        return Console.ReadLine();
    }
}
