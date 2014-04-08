using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
	abstract class Vehicle
    {
		private string _name;
		private uint _km;
		private string _registration;
		protected readonly int _year;
		private decimal _newPrice;
		private bool _towHook;
		protected double _engineSize;
		private double _kmPerLiter;
        enum FuelType { Diesel, Gasoline }
		private FuelType _fuelType;
        enum EnergyClass { A, B, C, D }
        private EnergyClass _energyClass; // Calculated from fuelType, kmPerLiter and year
        public enum LicenseType { A, B, BE, C, CE, D, DE }
        public LicenseType _licenseType; // Defined by vehicle subclass
        public struct Size {//To describe Size of Trunk and Truck
            double Height;
            double Width;
            double Depth;
        }

        public int AuctionNumber { get; set; }
        decimal MinPrice { get; set; }

		public string Name{
			get { return _name; }
			set {
				if (String.IsNullOrEmpty (value))
					throw new ArgumentException ("Vehicle name not set", "NoVehicleName");
                else 
					_name = value;
			}
		}

		public uint Km{
			get { return _km; }
			set {
				if (value >= 0)
					_km = value;
				else
					throw new ArgumentException("Km cannot be negative", "kmTooLow");
			}
		}

		public static bool GetMatches(string strInput)
		{
			Regex regex = new Regex(@"([a-zA-Z]{2}\d{5})$"); // <- Det er regex og betyder [a-zA-Z]{2} <- 2 tegn der skal være mellem a-z og kan både være stor og lille bogstav, efterfulgt af 5 tal
			return (regex.Matches(strInput).Count == 1); // <- hvis der er 0 resultater er den false
		}

		public string Registration
		{
            get { return _registration; }
			set {
				if(GetMatches(value) == true) 
					_registration = value;
				else
					throw new ArgumentException("RegNum must be 7 char and the 2 first letters");
			}
		}

		decimal NewPrice{
			get { return _newPrice; }
			set {
				if (value >= 0)
					_newPrice = value;
				else
					//throw new ArgumentException ("Price must be above 0"); //Skal sættes til 0 i følge opgaven hvis negativ værdi givet
					_newPrice = 0;
			}
		}

		bool TowHook {
            get { return _towHook; }
            set { _towHook = value; }
        } // I denne opgave skal personbiler til erhverv være udstyret med en trækkrog. For alle andre køretøjer er det frivilligt at have trækkrog.
		
        double MotorSize; // Different types of vehicles must implement getter and setter for specific allowed ranges

		double KmPerLiter {
            get { return _kmPerLiter; }
            set { _kmPerLiter = value; }
        }

        LicenseType License {
            get { return _licenseType; }
            set { _licenseType = value; }
        }

        FuelType Fuel {
            get { return _fuelType; }
            set { _fuelType = value; }
        }

        private static EnergyClass CalcEnergyClass(FuelType fuelType, double kmPerLiter, int year) {
            EnergyClass energyClass;
            if(year < 2010){
                if (fuelType == FuelType.Diesel) {
                    if (kmPerLiter >= 23)
                        energyClass = EnergyClass.A;
                    else if (18 <= kmPerLiter && kmPerLiter < 23)
                        energyClass = EnergyClass.B;
                    else if (13 <= kmPerLiter && kmPerLiter < 18)
                        energyClass = EnergyClass.C;
                    else
                        energyClass = EnergyClass.D;
                } else {
                    if (kmPerLiter >= 18)
                        energyClass = EnergyClass.A;
                    else if (14 <= kmPerLiter && kmPerLiter < 18)
                        energyClass = EnergyClass.B;
                    else if (10 <= kmPerLiter && kmPerLiter < 14)
                        energyClass = EnergyClass.C;
                    else
                        energyClass = EnergyClass.D;
                }
            } else {
                if (fuelType == FuelType.Diesel) {
                    if (kmPerLiter >= 25)
                        energyClass = EnergyClass.A;
                    else if (20 <= kmPerLiter && kmPerLiter < 25)
                        energyClass = EnergyClass.B;
                    else if (15 <= kmPerLiter && kmPerLiter < 20)
                        energyClass = EnergyClass.C;
                    else
                        energyClass = EnergyClass.D;
                } else {
                    if (kmPerLiter >= 20)
                        energyClass = EnergyClass.A;
                    else if (16 <= kmPerLiter && kmPerLiter < 20)
                        energyClass = EnergyClass.B;
                    else if (12 <= kmPerLiter && kmPerLiter < 16)
                        energyClass = EnergyClass.C;
                    else
                        energyClass = EnergyClass.D;
                }
            }
            return energyClass;
        }

		public Vehicle() : this(0){} // if not year supplied set to 0

		public Vehicle(int year) //Needs better constructor with more vars
		{
			_year = year;
		}

		public override abstract string ToString(); // Subject to override
	}
}	