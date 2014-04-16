using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class AuctionHouseStruct
    {
        public struct VehicleBids
        {
            public Buyer Buyer;
            public decimal Bid;
            public int AuctionNumber;
            public DateTime BidPlaced;
        }
    }
}
