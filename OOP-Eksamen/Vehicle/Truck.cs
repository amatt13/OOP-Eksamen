using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Truck : Vehicle
    {
        private uint LoadCapacity { get; set; }
        private double _height;
        private double _lenght;
        private double _weight;
        private bool Hook { get; set; }
        private LicenseType _license;


        private double Weight {
            get {
                return _weight;
            }
            set {
                if (value > 0) {
                    _weight = value;
                }
                else {
                    throw new ArgumentException("The truck weights too little", "WeightTooLow");
                }
            }
        }

        private double Height {
            get {
                return _height;
            }
            set {
                if (value > 0) {
                    _height = value;
                }
                else {
                    throw new ArgumentException("The truck can not have a negative height value", "HeightTooLow");
                }
            }
        }

        private double Lenght {
            get {
                return _lenght;
            }
            set {
                if (value > 0) {
                    _lenght = value;
                }
                else {
                    throw new ArgumentException("The truck can not have a negative lenght value", "LenghtTooLow");
                }
            }
        }

        private LicenseType Licence {
            get {
                return _license;
            }
            set {
                if (Hook == true) {
                    value = LicenseType.CE;
                }
                else {
                    value = LicenseType.C;
                }

            }
        }

        public override string ToString() {
            string SloadCapacity = LoadCapacity.ToString();
            string Sheight = Height.ToString();
            string Slenght = Lenght.ToString();
            string Sweight = Weight.ToString();
            string Shook = Hook.ToString();
            string Slicence = Licence.ToString();

            return "This truck have " + SloadCapacity +"kg loadcapacity, is " + Sheight + "m high, " + Slenght + "m long and weights " + Sweight + "kg. Is is " + Shook + " that there is a hook attached and the licenstype needed is " + Slicence + ".";
            //This truck have Xkg loadcapacity, is Xm high, Xm long and weights Xkg. Is is XXX that there is a hook attached and the licenstype needed is X.
        }
    }
}
