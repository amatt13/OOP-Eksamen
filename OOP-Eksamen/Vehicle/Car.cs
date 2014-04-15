using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Car : PersonVehicle
    {
        private bool _isofix;

        public bool Isofix
        {
            get { return _isofix; }
            set { _isofix = value; }
        }

        public override string ToString() {
            return
                string.Format("------------ \nName: {0} \nKilometers: {1} \nRegistration: {2} \nYear: {3} \nNew Price: {4:#,0} DKK \nTow Hook: {5} \nEngine Size: {6:0.0}L \nKilometers Per Liter: {7:0.0} Km/L \nFuel Type: {8} \nEnergyclass: {9} \nRequired Drivers License: {10} \nMinimum Price: {11:#,0} DKK \nIsofix: {12}",
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
                    Isofix);
        }

        public Car(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint seats, Size sizeOfPv, bool isofix)
            : base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice, seats, sizeOfPv)
        {
            Isofix = isofix;
        }
    }
}
