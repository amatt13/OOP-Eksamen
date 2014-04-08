using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Bus : Vehicle
    {
        private uint _seat;
        private uint _beds;
        private bool _toilet;
        private Size _sizeOfBus;
        private uint _weight;

        private uint Seat {
            get{
                return _seat;
            }
            set {
                if (value > 0) {
                    _seat = value;
                }
                else {
                    throw new ArgumentException("There have to be atleast 1 seat in a bus", "SeatTooLow");
                }
            }
        }

        private uint Beds {
            get {
                return _beds;
            }
            set {
                if (value < 999) {
                    _beds = value;
                }
                else {
                    throw new ArgumentException("The number of beds can't be a negative number", "BedTooLow");
                }
            }
        }
        private bool Toilet {
            get {
                return _toilet;
            }//Er det her nødvendigt? -Anders
            set {
                _toilet = value;
            }
        }
        private Size SizeOfBus { get; set; }
        private uint Weight { get; set; }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}

