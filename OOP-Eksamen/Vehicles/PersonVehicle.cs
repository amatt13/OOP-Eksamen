using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public class PersonVehicle : Vehicle
    {
        public int Seat
        {
            get
            {
                return this.Seat;
            }

            set
            {
                this.Seat = value;
            }
        }
        public double[] Dimensions = new double[2]; // Højde, Lægnde, Bredde

        public PersonVehicle() { }
    }
}
