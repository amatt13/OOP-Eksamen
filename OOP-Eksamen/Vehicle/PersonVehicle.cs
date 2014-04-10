using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
	abstract class PersonVehicle : Vehicle
    {
        private uint Seat
        {
            get
            {
                return _seat;
            }
            set
            {
                if (value > 0)
                {
                    _seat = value;
                }
                else
                {
                    throw new ArgumentException("There have to be atleast 1 seat in a vehicle", "SeatTooLow");
                }
            }
        }

        public struct Size
		{
			double Height;
			double Width;
			double Depth;
		}

		public PersonVehicle(int Seat, stuct Size) {}

		public override string ToString()
		{
			throw new NotImplementedExceptionl ();
		}
	}
}