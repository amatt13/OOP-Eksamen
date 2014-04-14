using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Truck : Vehicle
    {
        public uint LoadCapacity { get; set; }
        private double _height;
        private double _length;
        private double _weight;
        private LicenseType _license;
        private string p1;
        private int p2;
        private string p3;
        private int p4;
        private int p5;
        private bool p6;


        public double Weight {
            get {
                return _weight;
            }
            set {
                if (value > 0) {
                    _weight = value;
                }
                else {
                    throw new ArgumentException("The truck weights too little", "WeightTooLow");
                }
            }
        }

        public double Height {
            get {
                return _height;
            }
            set {
                if (value > 0) {
                    _height = value;
                }
                else {
                    throw new ArgumentException("The truck can not have a negative height value", "HeightTooLow");
                }
            }
        }

        public double Length {
            get {
                return _length;
            }
            set {
                if (value > 0) {
                    _length = value;
                }
                else {
                    throw new ArgumentException("The truck can not have a negative lenght value", "LenghtTooLow");
                }
            }
        }

        public LicenseType License {
            get {
                return _license;
            }
            set {
                if (_towHook == true) {
                    value = LicenseType.CE;
                }
                else {
                    value = LicenseType.C;
                }
            }
        }

        public Truck():base("test",1234,"AZ23412",1999,0,false,0,Vehicle.FuelType.Gasoline,0){
            Length = 1;
        }

        public Truck(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint loadcapacity , double height, double weight, double length) 
            : base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice)
        {
            LoadCapacity = loadcapacity;
            Height = height;
            Weight = weight;
            Length = length;
            License = _license;
        }

        public override string ToString() {
            string SloadCapacity = LoadCapacity.ToString();
            string Sheight = Height.ToString();
            string Slenght = Length.ToString();
            string Sweight = Weight.ToString();
            string StowHook = _towHook.ToString();
            string Slicence = License.ToString();

            return "This truck have " + SloadCapacity +"kg loadcapacity, is " + Sheight + "m high, " + Slenght + "m long and weights " + Sweight + "kg. Is is " + StowHook + " that there is a hook attached and the licenstype needed is " + Slicence + ".";
        }
    }
}
