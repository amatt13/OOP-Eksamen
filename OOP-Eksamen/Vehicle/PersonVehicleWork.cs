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
                    return (int)LicenseType.BE;
                }
                else
                {
                    return (int)LicenseType.B;
                }
				}
		}

		public override string ToString()
		{
			throw new NotSupportedException ();
		}

        public PersonVehicleWork() { }
	}
}
