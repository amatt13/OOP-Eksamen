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
        //Licenceype bliver håndteret i Work og Private.

        public uint Seat
        {
            get {
                return _seat;
            }
            set {
                if (value > 0) {
                    _seat = value;
                }
                else {
                    throw new ArgumentException("There have to be atleast 1 seat in a vehicle", "SeatTooLow");
                }
            }
        }

        public Size Trunk{
           get{
               return _trunk;
           }
           set{
               if (_trunk.Depth > 0 || _trunk.Height > 0 || _trunk.Width > 0) {
                   _trunk = value;
               }
               else {
                   throw new ArgumentException("One or more of these following values were below zero: Depth, Height and/or Width", "SizeToLow");
               } 
           }
       }

        public PersonVehicle(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint seats, Size size)
            :base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice){
            Seat = seats;
            Trunk = size;
        }
    }
}
