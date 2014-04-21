using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Van : PersonVehicle
    {
        private bool _safetybrace;
        private int _freightcapacity;

        public bool Safetybrace
        {
            get
            {
                return _safetybrace;
            }
            set
            {
                _safetybrace = value;
            }
        }

        public int Freightcapacity
        {
            get { return _freightcapacity; }
            set
            {
                _freightcapacity = value;
                if (value > 750)
                {
                    _licenseType = LicenseType.BE;
                }
                else
                {
                    _licenseType = LicenseType.B;
                }
            }
        }

        public override string ToString()
        {
            return
                string.Format("\n---Name: {0} \n---Type: Van \n---Kilometers: {1} \n---Registration: {2} \n---Year: {3} \n---New Price: {4:#,0} DKK \n---Tow Hook: {5} \n---Engine Size: {6:0.0}L \n---Kilometers Per Liter: {7:0.0} Km/L \n---Fuel Type: {8} \n---Energyclass: {9} \n---Required Drivers License: {10} \n---Minimum Price: {11:#,0} DKK \n---Safetybrace: {12} \n---Freightcapacity: {13}",
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
                    Safetybrace,
                    Freightcapacity);
        }

		public Van(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint seat, Size size, bool safetybrace, int freightcapacity, double engineSize)
			: base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice, seat, size,engineSize)
        {
            Safetybrace = safetybrace;
            Freightcapacity = freightcapacity;
            //Seat = 2;
        }
    }
}
