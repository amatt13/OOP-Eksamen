using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public class PersonVehicle : Vehicle
    {
        private int _seat;
        protected double[] _dimensions = new double[2]; // Højde, Lægnde, Bredde

        public int Seat
        {
            get { return _seat; }
            set { _seat = value; }
        }

        public double[] Dimensions
        {
            get { return _dimensions; }
        }

        public PersonVehicle() { }

        public PersonVehicle(string Name, uint Km, int Year, double NewPrice, bool TowHook, double KmL, int Seat, double[] Dimensions)
        {
            this.Name = Name;
            this.Km = Km;
            _year = Year;
            this.NewPrice = NewPrice;
            this.TowHook = TowHook;
            this.KmL = KmL;
            this.Seat = Seat;
            this._dimensions = Dimensions;
        }
    }
}
