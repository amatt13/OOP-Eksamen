using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    class Bus : Vehicle
    {
        int NumOfSeats;
        int NumOfBeds;
        bool Toilet;
        Size SizeOfBus;
        int Weight;
        //LicenseType to D or DE

        public override string ToString()
        {
            return "Bus - from: " + this.Year + " - AuctionNum " + this.AuctionNumber;
        }
    }
}
