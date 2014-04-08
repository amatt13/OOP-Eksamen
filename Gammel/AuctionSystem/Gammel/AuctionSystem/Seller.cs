using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    abstract class Seller : Buyer
    {
        int PostalCode;

        public List<Vehicle> Vehicles = new List<Vehicle>();

        public Seller() { }

        public void Notified(){
            Console.WriteLine("Notified");
        }
    }

    class PrivateSeller : Seller // BUG No multiple base classes
    {
        public int CPR { get; set; }

        public PrivateSeller() { this.CPR = 0; }

        public PrivateSeller(int id, decimal balance)
        {
            this.CPR = id;
            this.Balance = balance;
        }
    }

    class CompanySeller : Seller // BUG No multiple base classes
    {
        public int CVR { get; set; }

        public CompanySeller() { this.CVR = 0; }

        public CompanySeller(int id, decimal balance)
        {
            this.CVR = id;
            this.Balance = balance;
        }
    }


}
