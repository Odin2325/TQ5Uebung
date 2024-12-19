using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.utils
{
    internal class ListUtils
    {
        Outputs outputs;
        public ListUtils()
        {
            outputs = new Outputs();
        }

        // Filter-Methode: Nimmt ein Prädikat und eine Liste und gibt eine gefilterte Liste zurück
        public List<T> Filter<T>(Func<T, bool> praedikat, List<T> liste)
        {
            List<T> result = new List<T>();
            foreach (T element in liste)
            {
                if (praedikat(element))
                {
                    result.Add(element);
                }
            }
            return result;
        }

        // Reverse-Methode: Kehrt die Reihenfolge einer Liste um
        public List<T> Reverse<T>(List<T> liste)
        {
            List<T> result = new List<T>();
            for (int i = liste.Count - 1; i >= 0; i--)
            {
                result.Add(liste[i]);
            }
            return result;
        }

        // Append-Methode: Fügt ein Element ans Ende der Liste hinzu
        public List<T> Append<T>(List<T> liste, T element)
        {
            List<T> result = new List<T>(liste);
            result.Add(element);
            return result;
        }

        // Concatenate-Methode: Verbindet zwei Listen miteinander
        public List<T> Concatenate<T>(List<T> liste1, List<T> liste2)
        {
            List<T> result = new List<T>(liste1);
            foreach (T element in liste2)
            {
                result.Add(element);
            }
            return result;
        }
    }
}
