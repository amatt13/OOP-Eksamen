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
        private bool _toilet;//Get set er fjernet og bare blevet til dette lilel fine stykke kode -Anders
        private bool _hook;
        private Size _sizeOfBus;
        private uint _weight;
        private LicenseType _licence;

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

       /* private bool Toilet {
            get {
                return _toilet;
            }
            set {
                _toilet = value;
            }
        }*/

        private Size SizeOfBus {
            get {
                return _sizeOfBus;
            }
            set {
                if(_sizeOfBus.Depth > 0 || _sizeOfBus.Height > 0 || _sizeOfBus.Width > 0){
                    _sizeOfBus = value;
                }
                else {
                    throw new ArgumentException("One or more of these following values were below zero: Depth, Height and/or Width","SizeToLow");
                }
                
                
            }
        }

        private uint Weight {
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

        private LicenseType Licence {
            get {
                return _licence;
            }
            set {
                //Er som udgangspunkt D. Hvis bussen har trækkrog kræver det imidlertid et DE kørekort
                if (_hook == true) {
                    value = LicenseType.DE;
                }
                else {
                    value = LicenseType.D;
                }

            }
        }

        public override string ToString() {
            
            string returnString;
            string Sseat = Seat.ToString();
            string Sbeds = Beds.ToString();
            string Stoilet = _toilet.ToString();
            string SsizeOfBusHeight = SizeOfBus.Height.ToString();
            string SsizeOfBusDepth = SizeOfBus.Depth.ToString();
            string SsizeOfBusWidth = SizeOfBus.Width.ToString();
            string Sweight = Weight.ToString();

            returnString = "This bus have " + Sseat + " seats, " + Sbeds + " beds, " + " and it is " + Stoilet + " that it contains a toilet. The dimentions is " + SsizeOfBusHeight + " height, " + SsizeOfBusDepth + " depth and " + SsizeOfBusWidth + " width. The weight is " + Sweight;
            
            return returnString;
        }
    }
}

