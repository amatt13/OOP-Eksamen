using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class PersonVehiclePrivate : PersonVehicle
    {
        public bool IsofixMount
        {
            get
            {
                return this.IsofixMount;
            }

            set
            {
                this.IsofixMount = value;
            }
        }
        public LicenseType LicenseType
        {
            get { return LicenseType.B; }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public PersonVehiclePrivate(){}
    }
}
