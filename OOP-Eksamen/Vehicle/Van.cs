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

        public bool Safetybrace{
            get{
                return _safetybrace;
            }
            set{
                _safetybrace = value;
            }
        }

		public int Freightcapacity{
            get { return _freightcapacity; }
            set{
                _freightcapacity = value;
                if (value > 750){
                    _licenseType = LicenseType.BE;
                }
                else{
                    _licenseType = LicenseType.B;
                }
            }
		}

		public override string ToString(){
            return
                string.Format("------------ \nName: {0} \nKilometers: {1} \nRegistration: {2} \nYear: {3} \nNew Price: {4:#,0} DKK \nTow Hook: {5} \nEngine Size: {6:0.0}L \nKilometers Per Liter: {7:0.0} Km/L \nFuel Type: {8} \nEnergyclass: {9} \nRequired Drivers License: {10} \nMinimum Price: {11:#,0} DKK \nSafetybrace: {12} \nFreightcapacity: {13}", 
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

        public Van(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint seat, Size size, bool safetybrace, int freightcapacity)
            :base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice, seat, size){
                Safetybrace = safetybrace;
                Freightcapacity = freightcapacity;
                //Seat = 2;
        }
	}
}
