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
                return _credits + _balance;
            }
        }
    }

    class BusinessBuyer : Buyer
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

        public BusinessBuyer(decimal Balance, decimal Credit, int CVR)
        {
            _balance = Balance;
            _credits = Credit;
            _cvr = CVR;
        }
    }

    class PrivateBuyer : Buyer
    {
        private int _cpr;

        public int CPR
        {
            get
            {
                return _cpr;
            }

            set
            {
                _cpr = value;
            }
        }

        public bool RemoveBalance(decimal Price)
        {
            if (Price > _balance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public PrivateBuyer(decimal Balance, decimal Credit, int CPR)
        {
            _balance = Balance;
            _credits = 0;
            _cpr = CPR;
        }
    }
}
