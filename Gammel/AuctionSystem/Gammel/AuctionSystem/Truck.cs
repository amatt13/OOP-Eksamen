﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    class Truck : Vehicle
    {
        int LoadCapacity;
        Size SizeOfTruck;
        double Weight;
        //LicenseType to C or CE

        public override string ToString()
        {
            return "Truck - from: " + this.Year + " - AuctionNum " + this.AuctionNumber;
        }
    }
}
