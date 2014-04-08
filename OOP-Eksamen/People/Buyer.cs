using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Buyer
    {
        protected decimal _balance;
        protected decimal _credits;

        //The Balance has been made read-only
        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }

        //The constructor is the place where the account balance is set.
        public Buyer(decimal Balance, decimal Credit)
        {
            _balance = Balance;
            _credits = Credit;
        }

        public abstract bool RemoveBalance();
    }

    class Business : Buyer
    {
        private int _cvr;

        public int CVR
        {
            get
            {
                return _cvr;
            }

            set
            {
                _cvr = value;
            }
        }

        public bool RemoveBalance(decimal Price)
        {
            if (Price > (_balance + _credits))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
