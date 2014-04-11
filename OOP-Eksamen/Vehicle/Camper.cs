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

		private uint _toilet;
        private Heatsource _usedheatsource;
        private double _energyClassModifier;
        private LicenseType _licence;
		private uint _seat;
		private uint _beds;

		public uint Seat { 
			get {
                return _seat; 
            }
			set { 
				if (value > 0)
					_seat = value;
				else
					throw new ArgumentException ("Vehicle has to have 1 or  more seats", "SeatTooLow");
			} 
		}

		public int Beds { 
			get { 
                return Beds; 
            }
			set { 
				if (value > 999)
					Beds = value;
				else
                    throw new ArgumentException("There have been placed 1.000 beds or more.\nWas this a mistake?", "BedTooHigh");
			}
		}
		public uint Toilet { 
			get { return _toilet; }
			set { _toilet = value;} 
		}

        private Heatsource UsedHeatsource {
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
            string Sseats = Seat.ToString();
            string Sbeds = Beds.ToString();
            string Stoilet = Toilet.ToString();
            string SusedHeat = UsedHeatsource.ToString();
            string SenergyClassModifier = EnergyClassModifier.ToString();
            string Slicence = Licence.ToString();

            string returnString = "This camper have " + Sseats + " seats, " + Sbeds + " beds and have " + Stoilet +" toilet(s). The primary heating source is powered by " + SusedHeat +", the energyclass modifier is " + SenergyClassModifier + " and the licencetype is " + Slicence + ".";
            return returnString;
        }
	}
}