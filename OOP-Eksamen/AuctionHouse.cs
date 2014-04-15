﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen {
    class Sales {
        //Liste hvor alle køretøjer er tilsalg
        public List<Vehicle> VehicleSold = new List<Vehicle>();
        public List<Vehicle> VehicleForSale = new List<Vehicle>();
        public List<AuctionHouseStruct.VehicleBids> Bids = new List<AuctionHouseStruct.VehicleBids>();

        //public int SætTilSalg(Køretøj k, Sælger s, decimal minPris)
        //public int SætTilSalg(Køretøj k, Sælger s, decimal minPris, notifikationsMetode)

        private int i = 0;

        public delegate void NotificationMethod(Vehicle k);

        public int PutOpForSale(Vehicle K, Seller S, decimal MinPrice, NotificationMethod Method) {
            Method(K);
            K.AuctionNumber = i++;
            K.NewPrice = MinPrice;
            K.Seller = S;
            return i;
        }

        //public bool ModtagBud(Køber køber, int auktionsNummer, decimal bud)
        public bool ReciveOffer(Buyer Buyer, int AuctionNumber, decimal Offer) {
            if (AuctionNumber == -1) {
                throw new ArgumentException("The vehicle has not been registered in the auction house", "NotRegisteredAuctionHouse");
            }

            IEnumerable<Vehicle> Vehicle = VehicleForSale.Where(v => v.AuctionNumber == AuctionNumber).Take(1);

            if (Buyer.Balance >= Offer && Vehicle.First().NewPrice <= Offer) {
                AuctionHouseStruct.VehicleBids Bid = new AuctionHouseStruct.VehicleBids();
                Bid.Bid = Offer;
                Bid.Buyer = Buyer;
                Bid.AuctionNumber = AuctionNumber;

                Vehicle.First().MinPrice = Offer;

                Bids.Add(Bid);

                return true;
            }
            else {
                return false;
            }
        }

        //public bool AccepterBud(Sælger sælger, int auktionsNummer)

        public bool AcceptBid(Seller Seller, int AuctionNumber) {
            return false;
        }
    }
}
