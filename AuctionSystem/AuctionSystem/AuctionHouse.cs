using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    class AuctionHouse
    {
        public List<Vehicle> ForSale = new List<Vehicle>();
        public List<Vehicle> Sold = new List<Vehicle>();
        public List<Buyer> Buyers = new List<Buyer>();
        public List<Seller> Sellers = new List<Seller>();

        public delegate void Notify();
        
        public int Sell(Vehicle k, Seller s, decimal minPrice){
            return Sell(k, s, minPrice, null);
        }

        public int Sell(Vehicle k, Seller s, decimal minPrice, Delegate Notify){
            return 0;
        }

        public bool RecieveOffer(Buyer b, int aucNum, decimal offer){
            return true;
        }
        public bool AcceptOffer(Seller s, int aucNum){
            return true;
        }
    }
}
