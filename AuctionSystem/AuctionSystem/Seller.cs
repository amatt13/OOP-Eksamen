using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    abstract class Seller
    {
        int PostalCode;

        public Seller() { }

        public void Notified(){
            Console.WriteLine("Notified");
        }
    }

    class PrivateSeller : PrivateBuyer, Seller
    {
        public PrivateSeller() { this.CPR = 0; }

        public PrivateSeller(int id, decimal balance)
        {
            this.CPR = id;
            this.Balance = balance;
        }
    }

    class CompanySeller : CompanyBuyer, Seller
    {
        public CompanySeller() { this.CVR = 0; }

        public CompanySeller(int id, decimal balance)
        {
            this.CVR = id;
            this.Balance = balance;
        }
    }


}
