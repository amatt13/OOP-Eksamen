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

		private bool _toilet;
        private Heatsource _usedheatsource;
        private double _energyClassModifier;
		private uint _seat;
		private uint _beds;

		public uint Seats { 
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

		public uint Beds { 
			get { 
                return _beds; 
            }
			set { 
				if (value < 99)
					_beds = value;
				else
                    throw new ArgumentException("There have been placed 100 beds or more.\nWas this a mistake?", "BedTooHigh");
			}
		}
		public bool Toilet { 
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

		public override string ToString()
		{
            string Sseats = Seats.ToString();
            string Sbeds = Beds.ToString();
            string SToilet;

            if (Toilet) {
                SToilet = "a";
            }
            else{ 
                SToilet = "not got a"; 
            }
            string SusedHeat = UsedHeatsource.ToString();
            string SenergyClassModifier = EnergyClassModifier.ToString();
            string Slicence = _licenseType.ToString();

            string returnString = "This camper have " + Sseats + " seats, " + Sbeds + " beds and have " + SToilet +" toilet. The primary heating source is powered by " + SusedHeat +", the energyclass modifier is " + SenergyClassModifier + " and the licencetype is " + Slicence + ".";
            return returnString;
        }

        public Camper(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint seat, uint beds, bool toilet, double energyClassModifier) 
            : base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice) 
            {
            Seats = seat; 
            Beds = beds;
            Toilet = toilet;
            EnergyClassModifier = energyClassModifier;
            _licenseType = LicenseType.B;
            }

	}
}