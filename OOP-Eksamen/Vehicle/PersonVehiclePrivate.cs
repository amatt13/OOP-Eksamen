using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class PersonVehiclePrivate : PersonVehicle
    {
        private bool _isofix;

        public bool Isofix
        {
            get { return _isofix; }
            set { _isofix = value; }
        }

        public PersonVehiclePrivate(string name, double km, string reg, int year, decimal newPrice, bool towHook, double kmPerLiter, FuelType fuelType, decimal minPrice, uint seats, Size sizeOfPv, bool isofix)
            : base(name, km, reg, year, newPrice, towHook, kmPerLiter, fuelType, minPrice, seats, sizeOfPv)
        {
            Isofix = isofix;
        }
    }
}
