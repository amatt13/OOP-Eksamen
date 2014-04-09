using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
	class PersonVehiclePrivate : PersonVehicle 
	{

		bool Safetybrace{ get; set; }

		public LicenseType Freightcapacity{
			get{ return this.Freightcapacity;}
			set{ if (value > 750)
					return Freightcapacity.BE;
				else
				return Freightcapacity.B;
				}
		}

		public override string ToString()
		{
			throw new NotSupportedException ();
		}

		public PersonVehiclePrivate(){}
	}
}
