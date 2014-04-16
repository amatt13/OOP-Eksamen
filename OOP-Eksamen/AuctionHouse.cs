using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen {
    class AuctionHouse {
        //Liste hvor alle køretøjer er tilsalg

        public List<Seller> Sellers = new List<Seller>();
        public List<Buyer> Buyers = new List<Buyer>();

        public List<Vehicle> VehiclesSold = new List<Vehicle>();
        public List<Vehicle> VehiclesForSale = new List<Vehicle>();
        public List<AuctionHouseStruct.VehicleBids> Bids = new List<AuctionHouseStruct.VehicleBids>();

        CalculateFees FeeCalculater = new CalculateFees();

        //public int SætTilSalg(Køretøj k, Sælger s, decimal minPris)
        //public int SætTilSalg(Køretøj k, Sælger s, decimal minPris, notifikationsMetode)

        private int i = 0;

        public delegate void NotificationMethod(Vehicle k);

        public int PutOpForSale(Vehicle v, Seller s, decimal MinPrice, NotificationMethod Method) {
            //Method(v);
            VehiclesForSale.Add(v);
            s.Vehicles.Add(v);
            v.MinPrice = MinPrice;
            v.Seller = s;
            v.AuctionNumber = i;
            return i++;
        }

        //public bool ModtagBud(Køber køber, int auktionsNummer, decimal bud)
        public bool ReciveOffer(Buyer Buyer, int AuctionNumber, decimal Offer) {
            if (AuctionNumber == -1) {
                throw new ArgumentException("The vehicle has not been registered in the auction house", "NotRegisteredAuctionHouse");
            }

            IEnumerable<Vehicle> Vehicle = VehiclesForSale.Where(v => v.AuctionNumber == AuctionNumber).Take(1);

            if (Buyer.Balance >= Offer && Vehicle.First().MinPrice <= Offer) {
                AuctionHouseStruct.VehicleBids Bid = new AuctionHouseStruct.VehicleBids();
                Bid.Bid = Offer;
                Bid.Buyer = Buyer;
                Bid.AuctionNumber = AuctionNumber;
                Bid.BidPlaced = DateTime.Now;

                Vehicle.First().MinPrice = Offer;

                Bids.Add(Bid);

                return true;
            }
            else {
                return false;
            }
        }


        public bool AcceptBid(Seller seller, int auctionNumber) {
            IEnumerable<Vehicle> vehicle = seller.Vehicles.Where(v => v.AuctionNumber == auctionNumber).Take(1);
            decimal tmpPrice = vehicle.First().MinPrice;

            if (vehicle == null || !vehicle.Any()) {
                return false;
            }

            IEnumerable<AuctionHouseStruct.VehicleBids> vehicleBids = Bids.Where(b => b.AuctionNumber == auctionNumber).OrderByDescending( b => b.BidPlaced ).Take(1);

            foreach (AuctionHouseStruct.VehicleBids b in vehicleBids)
            {
                b.Buyer.RemoveBalance(tmpPrice);
            }

            tmpPrice -= FeeCalculater.Fees(tmpPrice);

            seller.AddBalance(tmpPrice);

            VehiclesSold.Add(vehicle.First());
            VehiclesForSale.Remove(vehicle.First());
            return true;

        }
    }
}
