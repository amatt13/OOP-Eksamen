using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Camper : Vehicle
    {
        enum Heatsource { Gas, Electricity, Oil }

		private uint _numberOfSeats;
		private uint _numberOfBeds;
		private uint _toilet;
        private Heatsource _usedheatsource;
        private double _energyClassModifier;
        private LicenseType _licence;

		public uint NumberOfSeats { 
			get {
                return _numberOfSeats; 
            }
			set { 
				if (value > 0)
					_numberOfSeats = value;
				else
					throw new ArgumentException ("Vehicle has to have 1 or  more seats");
			} 
		}

		public uint NumberOfBeds { 
			get { 
                return _numberOfSeats; 
            }
			set { 
				if (value > 999)
					_numberOfSeats = value;
				else
                    throw new ArgumentException("There have been placed 1.000 beds or more.\nWas this a mistake?", "BedTooHigh");
			}
		}
		public uint Toilet { 
			get { return _toilet; }
			set { _toilet = value;} 
		}

        public Heatsource UsedHeatsource {
            get {
                return _usedheatsource;
            }
            set {
                _usedheatsource = value;
            }
        }
        //Det her skal udregnes fr at energiklassen bliver beregent!
        private double EnergyClassModifier {
            get {
                return _energyClassModifier;
            }
            set {
                if (UsedHeatsource == Heatsource.Electricity) {
                    KmPerLiter = KmPerLiter * 0.8;
                    value = 0.8;
                }
                else if (UsedHeatsource == Heatsource.Gas) {
                    KmPerLiter = KmPerLiter * 0.9;
                    value = 0.9;
                }
                else if (UsedHeatsource == Heatsource.Oil) {
                    KmPerLiter = KmPerLiter * 0.7;
                    value = 0.7;
                }
            }
        }

        public LicenseType Licence {
            get {
                return _licence;
            }
            set {
                value = LicenseType.B;
                }
            }

		public override string ToString()
		{
            string Sseats = NumberOfSeats.ToString();
            string Sbeds = NumberOfBeds.ToString();
            string Stoilet = Toilet.ToString();
            string SusedHeat = UsedHeatsource.ToString();
            string SenergyClassModifier = EnergyClassModifier.ToString();
            string Slicence = Licence.ToString();

            string returnString = "This camper have " + Sseats + " seats, " + Sbeds + " beds and have " + Stoilet +" toilet(s). The primary heating source is powered by " + SusedHeat +", the energyclass modifier is " + SenergyClassModifier + " and the licencetype is " + Slicence + ".";
            return returnString;
        }
	}
}