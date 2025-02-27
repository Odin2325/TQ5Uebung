﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProgrammierenLernen
{/*
             * Veraender den namen der Klasse Auto zu PKW.
             * Wir erstellen dannach auch die Klasse LKW.
             * Hier brauchen wir mind. 5 eigenschaften.
             * Diese sollten alle private sein.
             * Wenn wir glauben ein benutzer die Werte veraendern sollte, 
             * dann auch einen getter/setter schreiben. Entweder mit Methode oder Properties.
             * Diese Klasse soll folgende Methoden haben: 
             * schnellerFahren, bremsen, hupen, parken, motorAnschalten/Ausschalten,
             * LKWBeladen, LKWEntladen.
             */

    /// <summary>
    /// Parent Class to represent all vehicles.
    /// </summary>
    public abstract class Fahrzeug
    {
        //Fields
        protected string marke;
        protected string klasse;
        protected int baujahr;
        protected string motor;
        protected int maxGeschwindigkeit = 120;
        protected bool motorLäuft = false;
        protected int aktuelleGeschwindigkeit = 0;

        /// <summary>
        /// Constructor for a generic vehicle
        /// </summary>
        /// <param name="marke"></param>
        /// <param name="klasse"></param>
        /// <param name="baujahr"></param>
        /// <param name="motor"></param>
        protected Fahrzeug(string marke, string klasse, int baujahr, string motor)
        {
            this.marke = marke;
            this.klasse = klasse;
            this.baujahr = baujahr;
            this.motor = motor;
        }

        //Properties
        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }
        public int Baujahr
        {
            get { return baujahr; }
        }

        public string Klasse
        {
            get { return klasse; }
        }

        public string Marke
        {
            get { return marke; }
            set { marke = value; }
        }

        /// <summary>
        /// Allows parking only if the motor is off and the speed is 0.
        /// Otherwise we turn the motor off or brake until we reach the speed 0.
        /// </summary>
        /// <returns>Boolean: Ob wir geparkt sind.</returns>
        public bool Parken()
        {
            if (aktuelleGeschwindigkeit == 0 && !motorLäuft)
            {
                Console.WriteLine("Wir sind geparkt.");
            }
            else if (aktuelleGeschwindigkeit == 0)
            {
                Console.WriteLine("Motor ist noch angeschaltet.");
                ManageMotor();
                Console.WriteLine("Wir sind geparkt.");
            }
            else
            {
                Console.WriteLine("Wir sind noch in bewegung.");
                Console.WriteLine("Wir bremsen.");
                while (aktuelleGeschwindigkeit > 0)
                {
                    Bremsen(10);
                }
                Console.WriteLine("Wir sind geparkt.");
            }
            return true;
        }
        /// <summary>
        /// Abstract method to implement the sound of a vehicles horn.
        /// </summary>
        public abstract void Hupen();

        /// <summary>
        /// Method to decrease the speed of the vehicle given a specific increment.
        /// </summary>
        /// <param name="inkrement">Dies ist der inkrement, der unsere geschwindigkeit erhoeht.</param>
        public void Bremsen(int inkrement)
        {
            if (aktuelleGeschwindigkeit > 0)
            {
                aktuelleGeschwindigkeit -= inkrement;
                Console.WriteLine($"Geschwindigkeit: {aktuelleGeschwindigkeit}");
            }
            else
            {
                Console.WriteLine("Wir sind angehalten.");
            }
        }
        /// <summary>
        /// Increase the speed of our vehicle given a specific increment.
        /// </summary>
        /// <param name="inkrement"></param>
        public void SchnellerFahren(int inkrement)
        {
            if (!motorLäuft)
            {
                Console.WriteLine("Motor ist nicht angeschaltet.");
                return;
            }
            if (aktuelleGeschwindigkeit < maxGeschwindigkeit)
            {
                aktuelleGeschwindigkeit += inkrement;
                Console.WriteLine($"Geschwindigkeit: {aktuelleGeschwindigkeit}");
            }
            else
            {
                Console.WriteLine("Maximale Geschwindigkeit erreicht.");
            }
        }
        /// <summary>
        /// Change the current state of the motor.
        /// </summary>
        public void ManageMotor()
        {
            Console.WriteLine(motorLäuft ? "Schalte Motor ab..." : "Starte Motor...");
            motorLäuft = !motorLäuft;
            Console.WriteLine(motorLäuft ? "Motor gestartet!" : "Motor abgeschalten.");
        }
    }

    /// <summary>
    /// Class to represent motorcycles.
    /// </summary>
    public class Motorrad : Fahrzeug
    {
        public Motorrad(string marke, string klasse, int baujahr, string motor) : base(marke, klasse, baujahr, motor)
        {
            base.maxGeschwindigkeit = 240;
        }

        public override void Hupen()
        {
            Console.WriteLine("NEAUUUUU");
        }
    }
    public class PKW : Fahrzeug
    {
        public PKW(string marke, string klasse, int baujahr, string motor) : base(marke, klasse, baujahr, motor)
        {
            base.maxGeschwindigkeit = 200;
        }
        public override void Hupen()
        {
            Console.WriteLine("MEEP MEEP");
        }
    }

    internal class LKW2 : Fahrzeug
    {

        //Fields
        private double hoehe;
        private double maxVolume = 50;
        private double maxGewicht = 80000;
        private List<(string produktName, double volume, double gewicht)> ladung = new List<(string produktName, double volume, double gewicht)>();

        /// <summary>
        /// Values necessary to create a Truck.
        /// </summary>
        /// <param name="marke"></param>
        /// <param name="klasse"></param>
        /// <param name="baujahr"></param>
        /// <param name="motor"></param>
        /// <param name="hoehe"></param>
        public LKW2(string marke, string klasse, int baujahr, string motor, double hoehe) : base(marke, klasse, baujahr, motor)
        {   
            this.hoehe = hoehe;
        }

        //Properties.
        public double Hoehe { get { return hoehe; } }
        
        public int MaxGeschwindigkeit
        {
            get => maxGeschwindigkeit;
            set
            {
                if(value>maxGeschwindigkeit)
                    Console.WriteLine("Super Motor hinzugefuegt.");
                else
                    Console.WriteLine("Motor ist nicht so gut.");
                maxGeschwindigkeit = value;
            }
        }

        /// <summary>
        /// Overwritten Sound method.
        /// </summary>
        public override void Hupen()
        {
            Console.WriteLine("TÖRRRÖÖÖÖÖÖ BEEEEEEEEEP MOOOOVE");
        }

        /// <summary>
        /// Method to load the truck.
        /// </summary>
        public void Beladen()
        {
            do
            {
                Console.WriteLine("Moechten Sie Produkte beladen?");
                string antwort = Console.ReadLine().ToLower();
                if(antwort== "nein")
                {
                    break;
                }
                else if(antwort == "ja")
                {

                }
                else
                {
                    continue;
                }
                Console.WriteLine("Welches Produkt moechten Sie im LKW beladen?");
                string produktName = Console.ReadLine();
                Console.WriteLine("Wie viel Volumen hat das Produkt?");
                double volume = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wie viel Gewicht hat das Produkt?");
                double gewicht = Convert.ToDouble(Console.ReadLine());

                if (GetCurrentValues("volume") + volume > maxVolume)
                {
                    Console.WriteLine("Produkt zu gross.");
                    continue;
                }
                else if (GetCurrentValues("gewicht") + gewicht > maxGewicht)
                {
                    Console.WriteLine("Produkt zu schwer.");
                    continue;
                }
                else
                {
                    ladung.Add((produktName, volume, gewicht));
                }
            } while (GetCurrentValues("volume")<maxVolume && GetCurrentValues("gewicht")<maxGewicht);
        }

        /// <summary>
        /// Method to empty the truck.
        /// </summary>
        public void Entladen()
        {
            List<(string produktName, double volume, double gewicht)> temp = new List<(string produktName, double volume, double gewicht)>();
            foreach(var item in ladung)
            {
                temp.Add(item);
            }

            foreach (var item in temp)
            {
                Console.WriteLine($"Produkt: {item.produktName}, Volume: {item.volume}, Gewicht: {item.gewicht}");
                ladung.Remove(item);
            }
        }

        /// <summary>
        /// Help method to extract values from out list.
        /// </summary>
        /// <param name="valueType"></param>
        /// <returns></returns>
        private double GetCurrentValues(string valueType)
        {
            if (valueType == "volume")
            {
                double currentVolume = 0;
                foreach (var item in ladung)
                {
                    currentVolume += item.volume;
                }
                return currentVolume;
            }
            else
            {
                double currentGewicht = 0;
                foreach (var item in ladung)
                {
                    currentGewicht += item.gewicht;
                }
                return currentGewicht;
            }
        }

        /// <summary>
        /// Method to show the details of our truck.
        /// </summary>
        public void InfosZeigen()
        {
            Console.WriteLine($"Marke: {marke}\nKlasse: {klasse}\nBaujahr: {baujahr}\nMotor: {motor}\nHoehe: {hoehe}\nMaxSpeed: {maxGeschwindigkeit}");
        }
    }


    internal class LKW
    {
        private bool motorLäuft = false;
        private int maxKMH = 120;
        private int currentKMH = 0;
        private bool hupe = false;
        private bool parken = true;
        private int maxLadung = 300;
        private int currentLadung = 0;
        private bool amLaden = false;

        private Outputs outputs;

        public LKW()
        {
            outputs = new Outputs();
        }

        public void ManageMotor()
        {
            outputs.NormalOutput(motorLäuft ? "Schalte Motor ab..." : "Starte Motor...");
            motorLäuft = !motorLäuft;
            outputs.SuccessOutput(motorLäuft ? "Motor gestartet!" : "Motor abgeschalten.");
        }

        public void Fahren()
        {
            if (!motorLäuft)
            {
                outputs.ErrorOutput("Du musst erst den Motor starten..!");
                return;
            }

            int increment = 5;

            outputs.NormalOutput("Fahrt beginnt...");

            while (currentKMH < maxKMH)
            {
                if (Brake())
                {
                    currentKMH -= increment;
                    if (currentKMH < 0)
                    {
                        currentKMH = 0;
                    }
                    outputs.NormalOutput($"Bremsen: Geschwindigkeit reduziert auf {currentKMH} km/h");

                    if (currentKMH == 0)
                    {
                        outputs.SuccessOutput("Erfolgreich angehalten!");
                        parken = true;
                        outputs.SuccessOutput("Du parkst nun...achte darauf dies nur im sicheren Gelände zu machen!");

                        if (parken)
                        {
                            outputs.NormalOutput("Möchtest du dein LKW beladen oder entladen? (B/E)");
                            string userInput = Console.ReadLine()?.ToUpper();

                            if (userInput == "B")
                            {
                                outputs.NormalOutput("Starte Beladung...");
                                ManageLadung(ref currentLadung, maxLadung, true);
                            }
                            else if (userInput == "E")
                            {
                                outputs.NormalOutput("Starte Entladung...");
                                ManageLadung(ref currentLadung, maxLadung, false);
                            }
                        }
                    }
                }
                else
                {
                    currentKMH += increment;
                    if (currentKMH > maxKMH)
                    {
                        currentKMH = maxKMH;
                    }
                    outputs.NormalOutput($"Geschwindigkeit: {currentKMH} km/h");

                    if (currentKMH == maxKMH)
                    {
                        outputs.SuccessOutput("Maximale Geschwindigkeit erreicht!");
                    }
                }

                Thread.Sleep(100);
            }
        }

        private bool Brake()
        {
            outputs.NormalOutput("Drücke 'B', um zu bremsen...");
            string input = Console.ReadLine();

            return input?.ToUpper() == "B";
        }

        private bool ManageLadung(ref int currentLadung, int maxLadung, bool laden)
        {
            int increment = 20;
            amLaden = true;

            if (laden)
            {
                outputs.NormalOutput("Ladevorgang gestartet...");
            }
            else
            {
                outputs.NormalOutput("Entladung gestartet...");
            }

            while (amLaden)
            {
                if (laden)
                {
                    currentLadung += increment;
                    if (currentLadung >= maxLadung)
                    {
                        currentLadung = maxLadung;
                        amLaden = false; // Laden abgeschlossen
                    }
                }
                else
                {
                    currentLadung -= increment;
                    if (currentLadung <= 0)
                    {
                        currentLadung = 0;
                        amLaden = false; // Entladung abgeschlossen
                    }
                }

                outputs.NormalOutput($"Aktuelle Ladung: {currentLadung}%");
                System.Threading.Thread.Sleep(100);
            }

            outputs.SuccessOutput(laden ? "Ladevorgang abgeschlossen!" : "Entladung abgeschlossen!");
            return amLaden;
        }
    }
}
