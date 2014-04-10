using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Bus
    {
        private uint _seat;
        private uint _beds;
        private bool _toilet;//Get set er fjernet og bare blevet til dette lilel fine stykke kode -Anders
        private Size _sizeOfBus;
        private uint _weight;

        public uint Seat {
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

        public uint Beds {
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
       /* private bool Toilet {
            get {
                return _toilet;
            }
            set {
                _toilet = value;
            }
        }*/
        public Size SizeOfBus {
            get {
                return _sizeOfBus;
            }
            set {
                if(_sizeOfBus.Depth > 0 || _sizeOfBus.Height > 0 || _sizeOfBus.Width > 0){
                    _sizeOfBus = value;
                }
                else {
                    throw new ArgumentException("One of these following values were below zero","");
                }
                
                
            }
        }

        public uint Weight {
            get {
                return _weight;
            }
            set {
                if (value > 1000) {//Hvad ville en god max vægt være? -Anders
                    _weight = value;
                }
                else {
                    throw new ArgumentException("The bus weights too little", "WeightTooLow");
                }
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
