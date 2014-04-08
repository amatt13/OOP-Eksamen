using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    abstract class Buyer
    {
        public decimal Balance {get; set;}

        public Buyer() : this(0) { }

        public Buyer(decimal balance)
        {
            this.Balance = balance;
        }
    }

    class PrivateBuyer : Buyer
    {
        public int CPR { get; set; }

        public PrivateBuyer() { this.CPR = 0; }

        public PrivateBuyer(int id, decimal balance)
        {
            this.CPR = id;
            this.Balance = balance;
        }
    }

    class CompanyBuyer : Buyer
    {
        public int CVR { get; set; }

        public CompanyBuyer() { this.CVR = 0; }

        public CompanyBuyer(int id, decimal balance)
        {
            this.CVR = id;
            this.Balance = balance;
        }
    }
}
