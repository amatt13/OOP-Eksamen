using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    abstract class Vehicle
    {
        string Name { get; set; } //Navn må ikke være null. Forsøg på at tildele en null værdi skal udløse en passende exception
        int Km { get; set; } //Distance already driven. Km må ikke være et negativt tal. Forsøg på at tildele en negativ værdi skal udløse en passende exception. Registreringsnummer (nummerplade)
        string RegNum { get; set; } //Registration number
        /*
         *   Et registreringsnummer skal bestå af to bogstaver (i denne opgave accepteres alle 
         *   bogstaver, ikke kun bogstaverne A-Z) efterfulgt af fem cifre. Forsøg på at tildele et 
         *   ulovligt registreringsnummer skal udløse en brugerdefineret exception. 
         *
         * Når et registreringsnummer aflæses, skal de to første og de to sidste tegn skjules. 
         *   Registreringsnummer XY12345 skal derfor vises som **123**. 
         */
        readonly int Year { get; set; } //The year it was registred. Årgang skal være read-only, dvs. efter instantiering må værdien ikke kunne ændres. 
        decimal NewPrice { get; set; } //NyPris må ikke være et negativt tal. Forsøg på at tildele en negativ værdi skal håndteres ved at NyPris tildeles værdien 0.
        bool Hook { get; set; } // I denne opgave skal personbiler til erhverv være udstyret med en trækkrog. For alle andre køretøjer er det frivilligt at have trækkrog.
        int LicenseType { get; set; } //Change to enum
        double MotorSize { get; set; }
        double KmPerLiter { get; set; }
        bool FuelType { get; set; } //Change to enum maybe
        int EnergyClass { get; set; } //Change to enum
        int AuctionNumber { get; set; }
        decimal MinPrice { get; set; }

        public struct Size //To describe Size of Trunk and Truck
        {
            double Height;
            double Width;
            double Depth;
        }

        public override abstract string ToString(); // Subject to override
    }
}
