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

        public int PutOpForSale(Vehicle K, Seller S, decimal MinPrice)
        {
            K.NewPrice = MinPrice;
            K.Seller = S;
            Console.WriteLine(i++);
            return i;
        }

        public int PutOpForSale(Vehicle K, Seller S, decimal MinPrice, bool WantNotification)
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
    }
}
