using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Sales
    {
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
            if (Buyer.GetBalance() >= Offer)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("The buyer cannot affort the car", "NotEnoughMoney");
            }
        }

        //public bool AccepterBud(Sælger sælger, int auktionsNummer)
    }
}
