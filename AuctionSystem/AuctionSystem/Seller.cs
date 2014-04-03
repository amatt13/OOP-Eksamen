using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    class Seller : Buyer
    {
        int PostalCode;

        public Seller() { this.Id = 1; }

        public Seller(int id, decimal balance)
        {
            this.Id = id;
            this.Balance = balance;
        }

        public void Notified(){
            Console.WriteLine("Notified");
        }
    }
}
