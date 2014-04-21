using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Car : PersonVehicle //inherited from PeronVehicle which is inherited from Vehicle
    {
        private bool _isofix;

        public bool Isofix
        {
            get { return _isofix; }
            set { _isofix = value; }
        }

        public override string ToString()
        {
            return
                string.Format("\n---Name: {0} \n---Type: Car \n---Kilometers: {1} \n---Registration: {2} \n---Year: {3} \n---New Price: {4:#,0} DKK \n---Tow Hook: {5} \n---Engine Size: {6:0.0}L \n---Kilometers Per Liter: {7:0.0} Km/L \n---Fuel Type: {8} \n---Energyclass: {9} \n---Required Drivers License: {10} \n---Minimum Price: {11:#,0} DKK \n---Isofix: {12}",
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

        public Car(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint seats, Size sizeOfPv, bool isofix, double engineSize)
            : base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice, seats, sizeOfPv, engineSize)
        {//The enginesize is sent back to the Personvehicle constructor as they both use the same value.
            Isofix = isofix;
            _licenseType = LicenseType.B;
        }
    }
}