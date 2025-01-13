using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zauberer_und_Krieger.utils
{
    internal class Nachichten
    {
        public void KriegerNachichten(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public void ZaubererNachichten(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public void SystemNachichten(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public void InfoNachichten(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public void NextRound(int roundNumber)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"======================== Runde {roundNumber} ========================");
            Console.ResetColor();
        }

        public void EndRound()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"======================== Runde beendet ========================");
            Console.ResetColor();
        }
    }
}
