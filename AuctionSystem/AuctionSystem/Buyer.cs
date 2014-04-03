using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    class Buyer
    {
        public int Id { get; set; }
        public decimal Balance {get; set;}

        public Buyer() { this.Id = 1; }

        public Buyer(int id, decimal balance)
        {
            this.Id = id;
            this.Balance = balance;
        }
    }
}
