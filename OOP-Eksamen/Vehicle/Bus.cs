﻿using System;
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
        private bool Toilet;//Get set er fjernet og bare blevet til dette lilel fine stykke kode -Anders
        private bool Hook;
        private Size _sizeOfBus;
        private double _weight;
        private LicenseType _license;

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

        private double Weight {
            get {
                return _weight;
            }
            set {
                if (value > 0) {
                    _weight = value;
                }
                else {
                    throw new ArgumentException("The bus weights too little", "WeightTooLow");
                }
            }
        }

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
        }
    }
}

