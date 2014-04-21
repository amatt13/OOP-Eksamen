using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    //struct to keep track of bids
    struct VehicleBids
    {
        public Buyer PlacedBy;
        public decimal Bid;
        public int AuctionNumber;
        public DateTime BidPlaced;
    }

    class AuctionHouse
    {
        //lists used to keep track of sellers, buyers, vehicles and bids.
        public List<Seller> Sellers = new List<Seller>();
        public List<Buyer> Buyers = new List<Buyer>();

        public List<Vehicle> VehiclesSold = new List<Vehicle>();
        public List<Vehicle> VehiclesForSale = new List<Vehicle>();
        public List<VehicleBids> Bids = new List<VehicleBids>();

        //Class used to calculate the transaction fee
        CalculateFees FeeCalculater = new CalculateFees();

        //int used to keep track of auction numbers
        private int i = 0;

        //a delegate method used to cantact the seller
        public delegate void NotificationMethod(Vehicle k);

        //method used to to set a vehicle for sale
        public int PutOpForSale(Vehicle v, Seller s, decimal MinPrice, NotificationMethod Method)
        {
            v.handler += Method;
            //adds the vehicle to the list of vehicles for sale
            VehiclesForSale.Add(v);
            //adds the vehicle to the seller it self
            s.Vehicles.Add(v);
            //Sets the minimum price on the vehicle
            v.MinPrice = MinPrice;
            //Sets the vehicles seller
            v.Seller = s;
            //Sets the vehicles auction number
            v.AuctionNumber = i;
            return i++;
        }

        //method used to recive the offer on a car from a buyer
        public bool ReciveOffer(Buyer Buyer, int AuctionNumber, decimal Offer)
        {
            //chesks to see if the vehicle has been given an auction number
            if (AuctionNumber == -1)
            {
                throw new ArgumentException("The vehicle has not been registered in the auction house", "NotRegisteredAuctionHouse");
            }

            //find the vehicle in the lists of vehicle for sale
            IEnumerable<Vehicle> Vehicle = VehiclesForSale.Where(v => v.AuctionNumber == AuctionNumber).Take(1);


            Vehicle.First().handler(Vehicle.First());

            //checks if the buyer has enouht balance and if the bid is larger then the required minimum price
            if (Buyer.Balance >= Offer && Vehicle.First().MinPrice <= Offer)
            {
                //create new bid
                VehicleBids Bid = new VehicleBids();
                //sets the bids offer
                Bid.Bid = Offer;
                //set who bids the price
                Bid.PlacedBy = Buyer;
                //sets the auction number
                Bid.AuctionNumber = AuctionNumber;
                //set when the bid is placed
                Bid.BidPlaced = DateTime.Now;

                //sets the new minimum price of the vehicle
                Vehicle.First().MinPrice = Offer;

                //add the bid to the bids list
                Bids.Add(Bid);

                return true;
            }
            else
            {
                return false;
            }
        }

        //method used to accept a bid a on a car
        public bool AcceptBid(Seller seller, int auctionNumber)
        {
            //select the vehicle with the selected auction number
            IEnumerable<Vehicle> vehicle = seller.Vehicles.Where(v => v.AuctionNumber == auctionNumber).Take(1);

            //check if any vehicle found
            if (vehicle == null || !vehicle.Any())
            {
                return false;
            }

            //make a tempoary price based in the vehicle minimum price
            decimal tmpPrice = vehicle.First().MinPrice;

            //find the latest bid on the vehicle
            IEnumerable<VehicleBids> vehicleBids = Bids.Where(b => b.AuctionNumber == auctionNumber).OrderByDescending(b => b.BidPlaced).Take(1);

            //remove the balance of the buyer
            foreach (VehicleBids b in vehicleBids)
            {
                b.PlacedBy.RemoveBalance(tmpPrice);
            }

            //remove the transauction fee of the price
            tmpPrice -= FeeCalculater.Fees(tmpPrice);

            //give the remaning money to the seller
            seller.AddBalance(tmpPrice);

            //add the vehicle to the sold list
            VehiclesSold.Add(vehicle.First());
            //remove the vehicle from the for sale list
            VehiclesForSale.Remove(vehicle.First());
            //remove the vehicle from the seller
            seller.Vehicles.Remove(vehicle.First());
            return true;

        }
    }
}
