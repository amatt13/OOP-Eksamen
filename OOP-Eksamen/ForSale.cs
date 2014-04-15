using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Sales
    {
        //Liste hvor alle køretøjer er tilsalg
        public List<Vehicle> VehicleSold = new List<Vehicle>();
        public List<Vehicle> VehicleForSale = new List<Vehicle>();

        //public int SætTilSalg(Køretøj k, Sælger s, decimal minPris)
        //public int SætTilSalg(Køretøj k, Sælger s, decimal minPris, notifikationsMetode)

        private int i = 0;

        public int PutOpForSale(Vehicle K, Seller S, decimal MinPrice, bool WantNotification = false)
        {
            if (WantNotification)
            {
                K.SellerNotif = true;
            }
            else
            {
                K.SellerNotif = false;
            }
            K.NewPrice = MinPrice;
            K.Seller = S;
            Console.WriteLine(i++);
            return i;
        }

        //public bool ModtagBud(Køber køber, int auktionsNummer, decimal bud)

        public bool ReciveOffer(Buyer Buyer, int AuctionNumber, decimal Offer)
        {
            if (Buyer.Balance >= Offer && VehicleForSale[AuctionNumber].NewPrice <= Offer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public bool AccepterBud(Sælger sælger, int auktionsNummer)

        public bool AcceptBid(Seller Seller, int AuctionNumber)
        {
            Seller.ReceiveNotificationAboutBid();
            return false;
        }
    }
}
