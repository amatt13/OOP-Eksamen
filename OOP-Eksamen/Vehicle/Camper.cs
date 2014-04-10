using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Camper
    {
		private int _numberOfSeats;
		private int _numberOfBeds;
		private bool _toilet;
		//private enum _heatsource;

		public int NumberOfSeats { 
			get {return _numberOfSeats; }
			set { 
				if (value > 0)
					_numberOfSeats = value;
				else
					throw new ArgumentException ("Vehicle has to have 1 or  more seats");
			} 
		}


		int NumberOfBeds { 
			get { return _numberOfSeats; }
			set { 
				if (value >= 0)
					_numberOfSeats = value;
				else
					throw new ArgumentException ("Vehicle can not have a negative number of beds");
			}
		}
		/*bool Toilet { 
			get { return _toilet; } //Skal der stå noget her?
			set { _toilet = value;} 
		}*/
		enum Heatsource { Gas, Electricity, Oil }

		public override string ToString()
		{
			throw new NotImplementedException(); //Kan ikke helt se hvad der menes her...
		}
	}
}