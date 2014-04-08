using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Camper : Vehicle
    {
        int Seat { get; set; }
        int Beds { get; set; }
        bool Toilet { get; set; }
        enum Heat { Gas, Electricity, Oil }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
