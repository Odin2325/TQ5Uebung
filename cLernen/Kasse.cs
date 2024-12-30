using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLernen
{
    internal class Kasse
    {
        internal decimal totalAmount;
        internal decimal minAmount = 0;
        internal bool isOpen = false;
        

    public Kasse(decimal totalAmount)
        {
            this.totalAmount = totalAmount;
        }

    internal decimal ShowAmount()
        {
            return totalAmount;
        }
    
    internal void GetPayment(decimal payment)
        {
            if (payment <= 0)
                Console.WriteLine("No payment recieved.");
            else
            totalAmount += payment;
        }
    internal void Payout(decimal amount)
        {
            if (amount > totalAmount)
                Console.WriteLine("Error! Not enough money.");
            else
                totalAmount -= amount;
        }
    }   
}

/*
 * Erstellt eine neue Klasse namens Kasse.
 * Ueberlegt euch 3 attribute einer Kasse. Eins davon koennte beispielsweise sein wie viel geld in die kasse ist.
 * (Challenge: Komplexere variante, wo wir in ein tuple array angeben was fuer geld wir haben und die menge
 * Beispielsweise fuenfer = 3, zwanziger = 13, fuenfizger = 8, dann soll es auch eine methode spaeter geben wo wir die summe berechnen.)
 * 
 * Als funktionen, soll die kasse geld auszahlen koennen, geld bekommen, aktueller kassen stand ausgeben und rechnung drucken.
 */