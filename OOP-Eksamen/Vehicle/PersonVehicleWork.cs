using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
	class PersonVehicleWork : PersonVehicle 
	{

		bool Safetybrace{ get; set; }

		public int Freightcapacity{
			get{ return this.Freightcapacity;}
            set
            {
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
            int Isafetybrace = Safetybrace.ToString();
            int IlicenseType = LicenseType.ToString();

            return "This vehicle has a safety brace" + Isafetybrace + ", and its licencetype is" + IlicenseType 0 ".";
		}

        public PersonVehicleWork() { }
	}
}
