using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    class AuctionHouse
    {
        List<Vehicle> ForSale = new List<Vehicle>();
        List<Vehicle> Sold = new List<Vehicle>();
        
        
        
        public int Sell(Vehicle k, Seller s, decimal minPrice);
        public int Sell(Vehicle k, Seller s, decimal minPrice, NotificationMethod); //Delegate        public bool RecieveOffer(Buyer b, int auktionsNummer, decimal offer);        public bool AcceptOffer(Seller s, int auktionsNummer);
    }
}
