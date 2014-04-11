using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Camper : Vehicle
    {
		private int _seat;
		private int _beds;
		private bool _toilet;
		//private enum _heatsource;

		public int Seat { 
			get {return _seat; }
			set { 
				if (value > 0)
					_seat = value;
				else
					throw new ArgumentException ("Vehicle has to have 1 or  more seats");
			} 
		}


		public int Beds { 
			get { return Beds; }
			set { 
				if (value >= 0)
					Beds= value;
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
            return "Camper mangler.";
			//throw new NotImplementedException(); //Kan ikke helt se hvad der menes her...
		}
	}
}