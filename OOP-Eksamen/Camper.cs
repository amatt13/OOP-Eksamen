using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public class Camper : Vehicle
    {
        int Seat { get; set; }
        int Beds { get; set; }
        bool Toilet { get; set; }
        enum Heat { Gas, Electricity, Oil }
    }
}
