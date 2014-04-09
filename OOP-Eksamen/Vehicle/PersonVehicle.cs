using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
	abstract class PersonVehicle : Vehicle
    {
		public int Seat{ 
			get{ return this.Seat;} 
			set{ this.Seat = value;} //Skal lige have clearet om vi bruger _seat eller this.seat
	}
		public struct Size
		{
			double Height;
			double Width;
			double Depth;
		}

		public PersonVehicle() {}

		public override string ToString()
		{
			throw new NotImplementedExceptionl ();
		}
	}
}