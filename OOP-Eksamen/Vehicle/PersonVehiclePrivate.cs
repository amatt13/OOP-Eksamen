using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class PersonVehiclePrivate : PersonVehicle
    {
		public bool IsoFixMount{ get; set; }

		public LicenseType License
		{
			get { return LicenseType.B;}
		}

		public override string ToString()
		{
            string returnString;
            string SisoFixMount = IsoFixMount.ToString();
            string SlicenseType = License.ToString();

            returnString = "This private car needs the licensetype " + SlicenseType + " and it is " + SisoFixMount + " that it has ISOFIX mountings.";
            
            return returnString;
		}
    }
}
