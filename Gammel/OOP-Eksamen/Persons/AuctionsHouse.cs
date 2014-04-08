using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class AuctionsHouse
    {
        private decimal _balance;

        public decimal Balance
        {
            get
            {
                return this._balance;
            }
        }

        public AuctionsHouse() {
            this._balance = 0;
        }

        public bool AddBalance ( decimal Amount ){
            this._balance += Amount;
            return true;
        }
    }
}
