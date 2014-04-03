using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public class Bus : Vehicle
    {
        int Seat { get; set; }
        int Beds { get; set; }
        bool Toilet { get; set; }
        double Height { get; set; }
        double Length { get; set; }
        int Weight { get; set; }
    }
}
