using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
	abstract class Vehicle
    {
		private string _name;
		private uint _km;
		private string _registration;
		protected int _year;
		private double _newPrice;
		private bool _towHook;
		protected LicenseType _licenseType;
		protected double _engineSize;
		private double _kmL;
		private Fuel _fuel;
		private EnergyClass _energyClass;

		public string Name{
			get{return _name;}
			set{
				if (String.IsNullOrEmpty (value)) 
				{
					throw new ArgumentException ("Vehicle name not set", "NoVheicleName");
				}
				else{
					_name = value;
				}
			}
		}

		public uint Km{
			get { return this.Km; }
			set{
				if (value >= 0)
					this.Km = value;
				else
					throw new ArgumentException("Km cannot be negative", "kmTooLow");
			}
		}

		public static bool getMatches(string strInput)
		{
			Regex regex = new Regex(@"([a-zA-Z]{2}\d{5})$"); // <- Det er regex og betyder [a-zA-Z]{2} <- 2 tegn der skal være mellem a-z og kan både være stor og lille bogstav, efterfulgt af 5 tal
			return (regex.Matches(strInput).Count == 1); // <- hvis der er 0 resultater er den false
		}

		public string Registration
		{
			get { throw new NotImplementedException(); }
			set 
			{
				if(getMatches(value) == true) 
					this.Registration = value;
				else
					throw new ArgumentException("RegNum must be 7 char and the 2 first letters");
			}
		}

		public readonly int Year;

		decimal NewPrice{
			get { return this.NewPrice; }
			set
			{
				if (value >= 0)
					this.NewPrice = value;
				else
					throw new ArgumentException ("Price must be above 0");
					//this.NewPrice = 0;
			}
		}

		bool Hook { get; set; } // I denne opgave skal personbiler til erhverv være udstyret med en trækkrog. For alle andre køretøjer er det frivilligt at have trækkrog.
		public enum LicenseType {A,B,BE,C,CE,D,DE}
		public LicenseType License;
		double MotorSize; // Different types of vehicles must implement getter and setter for specific allowed ranges
		double KmPerLiter { get; set; }
		enum FuelType { Diesel, Gasoline }
		enum EnergyClass { A, B, C, D }
		public int AuctionNumber { get; set; }
		decimal MinPrice { get; set; }

		public struct Size //To describe Size of Trunk and Truck
		{
			double Height;
			double Width;
			double Depth;
		}

		public Vehicle() : this(0){} // if not year supplied set to 0

		public Vehicle(int year) //Needs better constructor with more vars
		{
			this.Year = year;
		}

		public override abstract string ToString(); // Subject to override
	}
}	