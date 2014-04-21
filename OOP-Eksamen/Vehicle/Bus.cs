using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Bus : Vehicle
    {
        private uint _seats;
        private uint _beds;
        public bool _toilet;
        private Size _sizeOfBus;
        private double _weight;

        public uint Seats
        {
            get
            {
                return _seats;
            }
            set
            {
                if (value > 0)
                {
                    _seats = value;
                }
                else
                {
                    throw new ArgumentException("There have to be atleast 1 seat in a bus", "SeatTooLow");
                }
            }
        }

        public uint Beds
        {
            get
            {
                return _beds;
            }
            set
            {
                if (value < 999)
                {
                    _beds = value;
                }
                else
                {
                    throw new ArgumentException("The number of beds can't be a negative number", "BedTooLow");
                }
            }
        }

        public bool Toilet
        {
            get
            {
                return _toilet;
            }
            set
            {
                _toilet = value;
            }
        }
        public Size SizeOfBus
        {
            get
            {
                return _sizeOfBus;
            }
            set
            {
                if (value.Depth > 0 && value.Height > 0 && value.Width > 0)
                {
                    _sizeOfBus = value;
                }
                else
                {
                    throw new ArgumentException("One of these following values were below zero", "");
                }
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value < 1000)
                {//Hvad ville en god max vægt være? -Anders
                    _weight = value;
                }
                else
                {
                    throw new ArgumentException("The bus weights too little", "WeightTooLow");
                }
            }
        }

        public LicenseType Licence
        {
            get
            {
                return _licenseType;
            }
            set
            {
                if (_towHook == true)
                {
					_licenseType = LicenseType.DE;
                }
                else
                {
					_licenseType = LicenseType.D;
                }
            }
        }

        public override double EngineSize
        {
            get
            {
                return _engineSize;
            }

            set
            {
                if (value >= 4.2 && value <= 15)
                {
                    _engineSize = value;
                }
                else
                {
                    throw new ArgumentException("Engine size not within engine size range", "NotInEngineSizeRange");
                }
            }
        }

		public Bus(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint seats, uint beds, bool toilet, Size sizeOfBus, double weight, double engineSize)
            : base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice)
        {
            Seats = seats;
            Beds = beds;
            Toilet = toilet;
            SizeOfBus = sizeOfBus;
            Weight = weight;
			EngineSize = engineSize;
        }


        public override string ToString()
        {
            return
				string.Format("\n---Name: {0} \n---Type: Bus \n---Kilometers: {1} \n---Registration: {2} \n---Year: {3} \n---New Price: {4:#,0} DKK \n---Tow Hook: {5} \n---Engine Size: {6:0.0}L \n---Kilometers Per Liter: {7:0.0} Km/L \n---Fuel Type: {8} \n---Energyclass: {9} \n---Required Drivers License: {10} \n---Minimum Price: {11:#,0} DKK \n---Seats: {12}\n---Beds: {13}\n---Toilet: {14}\n---Weight: {15}\n",
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
                    Seats,
                    Beds,
                    Toilet,
                    Weight);
        }

    }
}
