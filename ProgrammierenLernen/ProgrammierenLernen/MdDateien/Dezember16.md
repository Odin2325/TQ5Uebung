**RNA Uebersetzung BeispielsLoesung**

        public static List<string> RnaUebersetzung(string rnaSequenz)
        {
            var proteinen = new List<string>();

            for(int i = 0; i < rnaSequenz.Length; i += 3)
            {
                if (i > rnaSequenz.Length-3)
                {
                    Console.WriteLine("Zeichenketten nicht durch 3 Teilbar.");
                    Console.WriteLine($"Nur bis zu index {i} gelaufen.");
                    break;
                }
                string codon = rnaSequenz.Substring(i, 3);

                string proteine = codon switch
                {
                    "AUG" => "Methionin",
                    "UUU" or "UUC" => "Phenylalanin",
                    "UUA" or "UUG" => "Leucin",
                    "UCU" or "UCC" or "UCA" or "UCG" => "Serin",
                    "UAU" or "UAC" => "Tyrosin",
                    "UGU" or "UGC" => "Cystein",
                    "UGG" => "Tryptophan",
                    "UAA" or "UAG" or "UGA" => "STOP",
                    _ => ""
                };

                if(proteine == "STOP")
                {
                    break;
                }
                if(proteine == "")
                {
                    Console.WriteLine("Ungueltige eingabe erreicht: " + codon);
                    break;
                }
                proteinen.Add(proteine);
            }
            return proteinen;
        }

**Regentropfen BeispielsLoesung**

        public static void RegentropfenFaktoren(int obereGrenze)
        {
            Console.WriteLine("Regentropfen Start");
            for (int i = 0; i < obereGrenze; i++)
            {
                string resultat = "";
                if (i % 3 == 0)
                {
                    resultat += "Pling";
                }
                if (i%5==0)
                {
                    resultat += "Plang";
                }
                if (i % 7 == 0)
                {
                    resultat += "Plong";
                }

                if (resultat.Length>0 && i!=0)
                {
                    Console.WriteLine($"{i} - {resultat}");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

**PlanetenAlter BeispielsLoesung**

        public static void PlanetenAlter()
        {
            Console.WriteLine("Wie alt bist du in Sekunden?");
            if(!double.TryParse(Console.ReadLine(), out double sekunden))
            {
                Console.WriteLine("Ungueltige eingabe.");
            }

            double erdJahren = sekunden / 31557600;

            Console.WriteLine("Merkur: " + Math.Round(erdJahren/0.2408467));
            Console.WriteLine("Venus: " + erdJahren / 0.61519726);
            Console.WriteLine("Erde: " + erdJahren);
            Console.WriteLine("Mars: " + erdJahren / 1.8808158);
            Console.WriteLine("Jupiter: " + erdJahren / 11.862615);
            Console.WriteLine("Saturn: " + erdJahren / 29.447498);
            Console.WriteLine("Uranus: " + erdJahren / 84.016846);
            Console.WriteLine("Neptun: " + erdJahren / 164.79132);
        }

**Schaltjahr BeispielLoesung**

        static void Schaltjahr()
        {
            Console.WriteLine("bitte gib eine Jahreszahl ein");
            int Jahr = int.Parse(Console.ReadLine());
            if (Jahr >= 0)
            {
                Console.WriteLine("gültige Jahreszahl");
                if ((Jahr % 4 == 0 && Jahr % 100 != 0) || (Jahr % 400 == 0))
                {
                    Console.WriteLine("ihre Jahreszahl entspricht einem Schaltjahr");
                }
                else
                {
                    Console.WriteLine("ihre Jahreszahl entspricht nicht einem Schaltjahr");
                }
            }
            else
            {
                Console.WriteLine("ungültige Eingabe!");
            }
        }

**Variante2**

        public bool BerechneSchaltjahr(int jahr)
        {
            if (jahr % 4 == 0)
            {
                if (jahr % 100 == 0)
                {
                    return jahr % 400 == 0;
                }
                return true;
            }
            return false;
        }

