using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
	class PersonVehiclePrivate : PersonVehicle //Der er noget galt med nedarvning her 
    {
		bool IsoFixMount{ get; set; }

		public LicenceType LicenseType
		{
			get { return LicenseType.B;}
		}

		public override string ToString()
		{
			throw new NotSupportedException ();
		}

		public PersonVehiclePrivate(){}
    }
}
