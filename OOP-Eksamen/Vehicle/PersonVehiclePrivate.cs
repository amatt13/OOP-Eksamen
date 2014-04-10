using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class PersonVehiclePrivate : Vehicle
    {
		bool IsoFixMount{ get; set; }

		public LicenseType LicenseType
		{
			get { return LicenseType.B;}
		}

		public override string ToString()
		{
			throw new NotSupportedException ();
		}
    }
}
