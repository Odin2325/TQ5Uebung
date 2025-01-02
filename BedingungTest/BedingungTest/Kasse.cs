using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BedingungTest
{
    internal class Kasse
    {
        private decimal kassenStand = 0;
       
        private int rechnungsNummer;

        private (int wert, int menge)[] geldBestandTuple;


        //public decimal KassenBestand { get => kassenBestand; set => kassenBestand = value; }




        public void geldAuszahlen(int betrag)
        {
            if (betrag > kassenStand)
            {
                Console.WriteLine("Nicht genug Geld in der Kasse!");
                return;
            }
            else
            {
                kassenStand -= betrag;
            }
        }

        public decimal GeldEinZahlen(int wert,int menge)
        {

            for (int i = 0; i < geldBestandTuple.Length; i++) 
            {
                if(geldBestandTuple[i].wert == wert)
                {
                    geldBestandTuple[i].menge += menge;
                }
                break;
            }
            kassenStand = ActuellerKassenStand();

        }

        public decimal ActuellerKassenStand()
        {
            decimal summe = 0;
            foreach( var (wert,menge) in geldBestandTuple)
            {
                summe += wert * menge;
            }
            return summe;   
        }






    }
}
