using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
	class PersonVehicle : Vehicle
    {
		public int NumberOfSeats {get; set;}
		public struct Size{double Height; double Width; double Depth;}
		public PersonVehicle() {}

		public override string ToString()
		{
			throw new NotSupportedException ();
		}
    }

}
