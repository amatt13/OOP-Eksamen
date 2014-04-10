using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Truck : Vehicle
    {
        int LoadCapacity { get; set; }
        double Height { get; set; }
        double Length { get; set; }
        int Weight { get; set; }
		//kørekort mangler stadig

        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}
