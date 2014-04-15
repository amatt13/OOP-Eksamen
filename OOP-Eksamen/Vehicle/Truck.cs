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
                string.Format("------------ \nName: {0} \nKilometers: {1} \nRegistration: {2} \nYear: {3} \nNew Price: {4:#,0} DKK \nTow Hook: {5} \nEngine Size: {6:0.0}L \nKilometers Per Liter: {7:0.0} Km/L \nFuel Type: {8} \nEnergyclass: {9} \nRequired Drivers License: {10} \nMinimum Price: {11:#,0} DKK \nLoadCapacity: {12} \nHeight: {13}\nLength: {14}\nWeight: {15}",
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
