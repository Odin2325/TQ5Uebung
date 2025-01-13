using SomeAufgaben.Bücherkatalog;
using SomeAufgaben.utils;
using System.Text;

namespace SomeAufgaben
{
    internal class Program
    {
        private static Outputs outputs;
        static void Main(string[] args)
        {
            outputs = new Outputs();

            outputs.Trennung();
            outputs.NormalOutput("Login oder Register?");
            string input = Console.ReadLine();

            Kunde kunde = new Kunde();

            if (!input.Equals("Login", StringComparison.OrdinalIgnoreCase) && !input.Equals("Register", StringComparison.OrdinalIgnoreCase))
            {
                outputs.ErrorOutput("Das habe ich nicht verstanden. Programm wird beendet.");
                outputs.Trennung();
                return;
            }
            else 
            {
                string kundennummer = "";
                bool loggedIn = false;
                if (input.Equals("Register", StringComparison.OrdinalIgnoreCase) && !loggedIn)
                {
                    kunde = Register();

                    if (kunde != null)
                    {
                        outputs.SuccessOutput("Registrierung erfolgreich\n");
                        outputs.NormalOutput("Was möchtest du jetzt tun?\n\n");
                        loggedIn = true;
                    }
                    else
                    {
                        outputs.ErrorOutput("Registrierung fehlgeschlagen. Beende Programm");
                        outputs.Trennung();
                    }
                }
                else if (input.Equals("Login", StringComparison.OrdinalIgnoreCase) && !loggedIn)
                {
                    kunde = Login();

                    if (kunde != null)
                    {
                        outputs.SuccessOutput("Login erfolgreich\n");
                        outputs.NormalOutput("Was möchtest du jetzt tun?\n\n");
                        loggedIn = true;
                    }
                    else
                    {
                        outputs.ErrorOutput("Login fehlgeschlagen. Beende Programm");
                        outputs.Trennung();
                    }
                }

                if (loggedIn)
                {
                    var stringBuilder = new StringBuilder()
                            .AppendLine("Gebe folgende Zahlen ein:")
                            .AppendLine("1 - Ausgeliehende Bücher anzeigen")
                            .AppendLine("2 - Buch ausleihen")
                            .AppendLine("3. - Buch zurück geben");

                    outputs.NormalOutput(stringBuilder.ToString());
                

                int.TryParse(Console.ReadLine(), out int choose);

                    switch (choose)
                    {
                        case 1:
                            {
                                outputs.Trennung();

                                Katalog katalog = new Katalog();
                                katalog.ShowAusgelieheneBücher(kunde);
                                break;
                            }
                        case 2:
                            {
                                outputs.Trennung();

                                Katalog katalog = new Katalog();
                                katalog.BuchAusleihen(kunde);
                                break;
                            }
                        case 3:
                            {
                                outputs.Trennung();

                                Katalog katalog = new Katalog();
                                katalog.BuchZurückGeben(kunde);
                                break;
                            }
                    }
                }
            }
        }

        private static Kunde? Register()
        {
            outputs.NormalOutput("Bitte wähle einen Nutzernamen:");
            string userName = Console.ReadLine().Trim();

            Kunde kunde = new Kunde();

            // Überprüfen, ob der Nutzername bereits existiert
            if (kunde.kunden.ContainsKey(userName))
            {
                outputs.ErrorOutput("Dieser Nutzername ist bereits vergeben. Bitte wähle einen anderen.");
                return null;
            }

            outputs.NormalOutput("Bitte wähle ein Passwort:");
            string password = Console.ReadLine().Trim();

            // Kundennummer generieren (z. B. 10-stellige Zufallszahl)
            string kundenNummer = new Random().Next(10000, 20000).ToString(); // Bereich für eindeutige Nummern

            // Kunden hinzufügen
            kunde.kunden.Add(userName, new Kunde
            {
                Passwort = password,
                KundenNummer = kundenNummer
            });

            outputs.SuccessOutput($"Registrierung erfolgreich! Deine Kundennummer lautet: {kundenNummer}");
            return kunde;
        }

        private static Kunde? Login()
        {
            Kunde kundeClass = new Kunde();

            outputs.NormalOutput("Bitte gebe deinen Nutzernamen ein.");
            string userName = Console.ReadLine().Trim();

            outputs.NormalOutput("Bitte gebe dein Passwort ein.");
            string password = Console.ReadLine().Trim();

            try
            {
                if (kundeClass.kunden.ContainsKey(userName))
                {
                    Kunde kunde = kundeClass.kunden[userName];
                    if (kunde.Passwort == password)
                    {
                        outputs.SuccessOutput($"Login erfolgreich. Deine Kundennummer ist: {kunde.KundenNummer}");
                        return kunde;
                    }
                    else
                    {
                        outputs.ErrorOutput("Falsches Passwort!");
                        return null;
                    }
                }
                else
                {
                    outputs.ErrorOutput("Kein Kunde mit diesem Nutzernamen gefunden.");
                    return null;
                }
            }
            catch (Exception e)
            {
                outputs.ErrorOutput("Fehler beim Login aufgetreten: " + e.ToString());
            }
            return null;
        }
    }
}
