using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Buyer
    {
        private decimal _balance;

        public decimal Balance
        {
            get
            {
                return this._balance;
            }

            set
            {
                this._balance = value;
            }
        }

        public Buyer(decimal Balance)
        {
            this._balance = Balance;
        }

        public bool RemoveBalance(decimal Amount)
        {
            this._balance -= Amount;
            return true;
        }


    }
}
