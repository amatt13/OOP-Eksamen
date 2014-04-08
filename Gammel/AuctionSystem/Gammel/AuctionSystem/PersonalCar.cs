using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    class PersonalCar : Car
    {
        bool IsoFixMount; //Isofix beslag giver en forbedret forankring af autostole ift. selemontering.

        public override string ToString()
        {
            return "PersonalCar - from: " + this.Year + " - AuctionNum " + this.AuctionNumber;
        }
    }
}
