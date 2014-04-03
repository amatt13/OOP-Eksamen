using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    abstract class Vehicle
    {
        string Name {
            get { return this.Name; }
            set {
                if (value != null)
                    this.Name = value;
                else
                    throw new ArgumentException("Name cannot be null");
            } 
        }
        int Km{
            get { return this.Km; }
            set{
                if (value >= 0)
                    this.Km = value;
                else
                    throw new ArgumentException("Km cannot be negative");
            }
        }
        string RegNum
        {
            get { return this.RegNum; }
            set
            {
                if (value.Length==7 && value.Any(Char.IsLetter)) // EDIT Check only if string contains a letter
                    this.RegNum = value;
                else
                    throw new ArgumentException("RegNum must be 7 char and the 2 first letters");
            }
        } //Registration number
        /*
         *   Et registreringsnummer skal bestå af to bogstaver (i denne opgave accepteres alle 
         *   bogstaver, ikke kun bogstaverne A-Z) efterfulgt af fem cifre. Forsøg på at tildele et 
         *   ulovligt registreringsnummer skal udløse en brugerdefineret exception. 
         *
         * Når et registreringsnummer aflæses, skal de to første og de to sidste tegn skjules. 
         *   Registreringsnummer XY12345 skal derfor vises som **123**. 
         */

        readonly int Year;
        decimal NewPrice{
            get { return this.NewPrice; }
            set
            {
                if (value >= 0)
                    this.NewPrice = value;
                else
                    this.NewPrice = 0;
            }
        }
        bool Hook { get; set; } // I denne opgave skal personbiler til erhverv være udstyret med en trækkrog. For alle andre køretøjer er det frivilligt at have trækkrog.
        int LicenseType { get; set; } //Change to enum
        abstract double MotorSize; // Different types of vehicles must implement getter and setter for specific allowed ranges
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

        public Vehicle() : this(0){} // if not year supplied set to 0

        public Vehicle(int year) //Needs better constructor with more vars
        {
            this.Year = year;
        }

        public override abstract string ToString(); // Subject to override
    }
}
