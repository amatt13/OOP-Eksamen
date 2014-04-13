using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Bus : Vehicle
    {
        private uint _seats;
        private uint _beds;
        public bool _toilet;
        private Size _sizeOfBus;
        private double _weight;

        public uint Seats {
            get{
                return _seats;
            }
            set {
                if (value > 0) {
                    _seats = value;
                }
                else {
                    throw new ArgumentException("There have to be atleast 1 seat in a bus", "SeatTooLow");
                }
            }
        }

        public uint Beds {
            get {
                return _beds;
            }
            set {
                if (value < 999) {
                    _beds = value;
                }
                else {
                    throw new ArgumentException("The number of beds can't be a negative number", "BedTooLow");
                }
            }
        }

       public bool Toilet {
            get {
                return _toilet;
            }
            set {
                _toilet = value;
            }
        }
        public Size SizeOfBus {
            get {
                return _sizeOfBus;
            }
            set {
                if(_sizeOfBus.Depth > 0 || _sizeOfBus.Height > 0 || _sizeOfBus.Width > 0){
                    _sizeOfBus = value;
                }
                else {
                    throw new ArgumentException("One of these following values were below zero","");
                }
            }
        }

        public double Weight {
            get {return _weight;}
            set {       
                if (value > 1000) {//Hvad ville en god max vægt være? -Anders
                    _weight = value;
                }
                else {
                    throw new ArgumentException("The bus weights too little", "WeightTooLow");
                }
            }
        }

        public LicenseType Licence{
            get{
                return _licenseType;
            }
            set{
                if (_towHook == true){
                    value = LicenseType.DE;           }
                else{
                    value = LicenseType.D;
                }
            }
        }

        public Bus(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint seats, uint beds, bool toilet, Size sizeOfBus, double weight) : base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice){
            Seats = seats;
            Beds = beds;
            Toilet = toilet;
            SizeOfBus = sizeOfBus;
            Weight = weight;
        }
        

        public override string ToString() {

            string returnString;
            string Sseat = Seats.ToString();
            string Sbeds = Beds.ToString();
            string Stoilet = Toilet.ToString();
            string Shook = _towHook.ToString();
            string SsizeOfBusHeight = SizeOfBus.Height.ToString();
            string SsizeOfBusDepth = SizeOfBus.Depth.ToString();
            string SsizeOfBusWidth = SizeOfBus.Width.ToString();
            string Sweight = Weight.ToString();
            
            returnString = "This bus have " + Sseat + " seats, " + Sbeds + " beds, " + " and have " + Stoilet + " toilet(s), while it is " + Shook + " the bus have a hook. The dimentions is " + SsizeOfBusHeight + "m height, " + SsizeOfBusDepth + "m deep and " + SsizeOfBusWidth + "m width. The weight is " + Sweight + "kg.";
            return returnString;
        }
    }
}
