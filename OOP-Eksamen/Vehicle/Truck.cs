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
            return
                string.Format("\n---Name: {0} \n---Type: Truck \n---Kilometers: {1} \n---Registration: {2} \n---Year: {3} \n---New Price: {4:#,0} DKK \n---Tow Hook: {5} \n---Engine Size: {6:0.0}L \n---Kilometers Per Liter: {7:0.0} Km/L \n---Fuel Type: {8} \n---Energyclass: {9} \n---Required Drivers License: {10} \n---Minimum Price: {11:#,0} DKK \n---LoadCapacity: {12} \n---Height: {13}\n---Length: {14}\n---Weight: {15}",
                    Name,
                    Km,
                    Registration,
                    _year,
                    NewPrice,
                    _towHook,
                    _engineSize,
                    KmPerLiter,
                    Fuel,
                    _energyClass,
                    _licenseType,
                    MinPrice,
                    LoadCapacity,
                    Height,
                    Length,
                    Weight);
        }
    }
}
