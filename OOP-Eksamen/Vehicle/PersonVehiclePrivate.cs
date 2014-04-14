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
        private string p1;
        private int p2;
        private string p3;
        private int p4;
        private int p5;
        private bool p6;
        private int p7;
        private FuelType fuelType;
        private int p8;
        private int p9;
        private Size sizePv1;

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
