﻿using System;
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

                if (part < 9)
                {
                    parts[i] = (part + 1).ToString();
                    break;
                }
                else
                {
                    parts[i] = "0";

                    // Wenn wir am letzten Part angelangt sind und zurücksetzen, prüfen wir, ob wir eine weitere Stelle hinzufügen müssen
                    if (i == 0)
                    {
                        // Füge dem ersten Part eine Stelle hinzu
                        parts[i] = (part + 1).ToString();
                    }
                }
            }

            return string.Join(".", parts);
        }
    }
}