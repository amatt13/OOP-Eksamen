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
<<<<<<< HEAD
        private bool Toilet { get; set; }
        private bool Hook { get; set; }
        private Size _sizeOfBus;
        private double _weight;
        private LicenseType _license;
=======
        private bool _toilet;//Get set er fjernet og bare blevet til dette lilel fine stykke kode -Anders
        private Size _sizeOfBus;
        private uint _weight;
>>>>>>> origin/Heider

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

<<<<<<< HEAD
        public uint Beds
        {
=======
        public uint Beds {
>>>>>>> origin/Heider
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
<<<<<<< HEAD

=======
>>>>>>> origin/Heider
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
<<<<<<< HEAD
                    throw new ArgumentException("One or more of these following values were below zero: Depth, Height and/or Width","SizeToLow");
                }               
            }
        }

        public double Weight {
=======
                    throw new ArgumentException("One of these following values were below zero","");
                }
                
                
            }
        }

        public uint Weight {
>>>>>>> origin/Heider
            get {
                return _weight;
            }
            set {
<<<<<<< HEAD
                if (value > 0) {
=======
                if (value > 1000) {//Hvad ville en god max vægt være? -Anders
>>>>>>> origin/Heider
                    _weight = value;
                }
                else {
                    throw new ArgumentException("The bus weights too little", "WeightTooLow");
                }
            }
        }

<<<<<<< HEAD
        private LicenseType Licence {
            get {
                return _license;
            }
            set {
                if (Hook == true) {
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
            string Stoilet = Toilet.ToString();
            string Shook = Hook.ToString();
            string SsizeOfBusHeight = SizeOfBus.Height.ToString();
            string SsizeOfBusDepth = SizeOfBus.Depth.ToString();
            string SsizeOfBusWidth = SizeOfBus.Width.ToString();
            string Sweight = Weight.ToString();

            returnString = "This bus have " + Sseat + " seats, " + Sbeds + " beds, " + " and it is " + Stoilet + " that it contains a toilet, while it is " + Shook + " the bus have a hook. The dimentions is " + SsizeOfBusHeight + "m height, " + SsizeOfBusDepth + "m deep and " + SsizeOfBusWidth + "m width. The weight is " + Sweight + "kg.";
            
            return returnString;
=======
        public override string ToString()
        {
            throw new NotImplementedException();
>>>>>>> origin/Heider
        }
    }
}

