using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
	class PersonVehicleWork : PersonVehicle 
	{
        private bool _safetybrace;

        public bool Safetybrace{
            get{
                return _safetybrace;
            }
            set{
                _safetybrace = value;
            }
        }

		public int Freightcapacity{
			get{ return this.Freightcapacity;}
            set{
                if (value > 750){
                    _licenseType = LicenseType.BE;
                }
                else{
                    _licenseType = LicenseType.B;
                }
            }
		}

		public override string ToString(){
            string Isafetybrace = _safetybrace.ToString();
            string IlicenseType = _licenseType.ToString();

            return "This vehicle has a safety brace " + Isafetybrace + ", and its licencetype is " + IlicenseType + ".";
		}
        public PersonVehicleWork(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint seat, Size size, bool safetybrace, int freightcapacity)
            :base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice, seat, size){
                Safetybrace = safetybrace;
                Freightcapacity = freightcapacity;
                //Seat = 2;
        }
	}
}
