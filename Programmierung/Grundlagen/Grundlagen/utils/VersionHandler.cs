using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.utils
{
    internal class VersionHandler
    {
        protected static string versionFilePath = "version.txt";
        public VersionHandler() { }

        public string Read()
        {
            if (File.Exists(versionFilePath))
            {
                return File.ReadAllText(versionFilePath);
            }
            return "0.0.0.0";
        }

        public void Save(string version)
        {
            DateTime date = DateTime.Now;
            File.WriteAllText(versionFilePath, version);
        }

        public string Update(string currentVersion)
        {
            string[] parts = currentVersion.Split('.');

            for (int i = parts.Length - 1; i >= 0; i--)
            {
                int part = int.Parse(parts[i]);

                if (part < 99)
                {
                    parts[i] = (part + 1).ToString("D2"); // Inkrementieren, mit führender Null
                    return string.Join(".", parts);
                }
                else
                {
                    parts[i] = "00"; // Zurücksetzen auf "00", wenn die Grenze erreicht ist
                }
            }

            // Wenn alle Teile "99" waren und zurückgesetzt wurden, erweitere die Struktur
            parts = new string[] { "1" }.Concat(parts).ToArray();
            return string.Join(".", parts);
        }
    }
}
