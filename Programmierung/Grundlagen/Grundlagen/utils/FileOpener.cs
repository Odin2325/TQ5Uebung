using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.utils
{
    internal class FileOpener
    {
        Outputs outputs;
        public FileOpener() 
        { 
            outputs = new Outputs();
        }

        public void OpenWith(string path)
        {
            Dictionary<string, string> fileAssociations = new Dictionary<string, string>
            {
                { "txt", "notepad.exe" },
                { "pdf", "adobe.exe" },
                { "cs", "visualstudio.exe" },
                { "html", "microsoftedge.exe" }
            };

            string extension = GetFileExtension(path);
            string fileName = GetFileName(path);

            if (fileAssociations.ContainsKey(extension))
            {
                string application = fileAssociations[extension];
                outputs.SuccessOutput($"Die Datei \u001b[34m{fileName}\u001b[0m kann mit \u001b[34m{application}\u001b[0m geöffnet werden, da es eine \u001b[34m{extension}\u001b[0m Datei ist.");
            }
            else
            {
                outputs.SuccessOutput($"Für die Datei \u001b[34m{path}\u001b[0m wurde keine passende Anwendung gefunden.");
            }
        }

        private string GetFileExtension(string path)
        {
            int indexOfDot = path.LastIndexOf('.');

            if (indexOfDot == -1 || indexOfDot == path.Length - 1)
            {
                return string.Empty;
            }

            return path.Substring(indexOfDot + 1).ToLower();
        }

        private string GetFileName(string path)
        {
            path = path.Replace("\\", "/");

            int lastSlashIndex = path.LastIndexOf('/');
            string fileName = lastSlashIndex >= 0 ? path.Substring(lastSlashIndex + 1) : path;

            int lastDotIndex = fileName.LastIndexOf('.');
            return lastDotIndex > 0 ? fileName.Substring(0, lastDotIndex) : fileName;
        }
    }
}
