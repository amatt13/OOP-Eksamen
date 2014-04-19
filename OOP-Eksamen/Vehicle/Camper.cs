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
            return
                string.Format("\n---Name: {0} \n---Type: Camper \n---Kilometers: {1} \n---Registration: {2} \n---Year: {3} \n---New Price: {4:#,0} DKK \n---Tow Hook: {5} \n---Engine Size: {6:0.0}L \n---Kilometers Per Liter: {7:0.0} Km/L \n---Fuel Type: {8} \n---Energyclass: {9} \n---Required Drivers License: {10} \n---Minimum Price: {11:#,0} DKK \n---Toilet: {12}\n---Heatsource: {13}\n---Seats: {14}\n---Beds: {15}",
                    Name,
                    Km,
                    Registration,
                    _year,
                    NewPrice,
                    _towHook,
                    _engineSize,
                    KmPerLiter,
                    Fuel,
                    _energyClass,
                    _licenseType,
                    MinPrice,
                    Toilet,
                    UsedHeatsource,
                    Seats,
                    Beds);
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