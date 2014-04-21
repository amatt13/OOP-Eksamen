using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    abstract class PersonVehicle : Vehicle
    {
        private uint _seat;
        private Size _trunk;
        //Licencetype will be handled in car and van.

        public uint Seat
        {
            get
            {
                return _seat;
            }
            set
            {
                if (value > 0)
                {//An exception will be trown if the seats is set to 0, negative number or a NAN
                    _seat = value;
                }
                else
                {
                    throw new ArgumentException("There have to be atleast 1 seat in a vehicle", "SeatTooLow");
                }
            }
        }

        public Size Trunk
        {
            get
            {
                return _trunk;
            }
            set
            {
                if (value.Depth > 0 && value.Height > 0 && value.Width > 0)
                {
                    _trunk = value;
                }
                else
                {
                    throw new ArgumentException("One or more of these following values were below zero: Depth, Height and/or Width", "SizeToLow");
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
                if (value >= 0.7 && value <= 10)
                {
                    _engineSize = value;
                }
                else
                {
                    throw new ArgumentException("Engine size not within engine size range", "NotInEngineSizeRange");
                }
            }
        }

        public PersonVehicle(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint seats, Size size, double engineSize)
            : base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice)
        {
            Seat = seats;
            Trunk = size;
            EngineSize = engineSize;
        }
    }
}
