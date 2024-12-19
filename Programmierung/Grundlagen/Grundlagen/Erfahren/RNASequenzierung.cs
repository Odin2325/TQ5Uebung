using Grundlagen.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Erfahren
{
    internal class RNASequenzierung
    {
        private Outputs outputs;
        public RNASequenzierung()
        {
            outputs = new Outputs();
        }

        public List<string> CheckRNA(string rna)
        {
            var codonTable = new Dictionary<string, string>
            {
                { "AUG", "Methionin" },
                { "UUU", "Phenylalanin" }, { "UUC", "Phenylalanin" },
                { "UUA", "Leucin" }, { "UUG", "Leucin" },
                { "UCU", "Serin" }, { "UCC", "Serin" }, { "UCA", "Serin" }, { "UCG", "Serin" },
                { "UAU", "Tyrosin" }, { "UAC", "Tyrosin" },
                { "UGU", "Cystein" }, { "UGC", "Cystein" },
                { "UGG", "Tryptophan" },
                { "UAA", "STOP" }, { "UAG", "STOP" }, { "UGA", "STOP" }
            };

            var protein = new List<string>();
            for (int i = 0; i < rna.Length; i += 3)
            {
                if (i + 3 > rna.Length) break;

                string codon = rna.Substring(i, 3);

                if (codonTable.ContainsKey(codon))
                {
                    if (codonTable[codon] == "STOP") break;

                    protein.Add(codonTable[codon]);
                }
            }

            return protein;
        }
    }
}
