using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Buyer
    {
        //variable initialization
        protected decimal _balance;
        protected decimal _credits = 0;

        //The Balance has been made read-only
        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }

        //This method remove balance from the buyer, if he has the balance needed
        public bool RemoveBalance(decimal Price)
        {
            if (Price < (_balance + _credits))
            {
                if (_balance < Price)
                {
                    Price -= _balance;
                    _credits -= Price;
                    _balance = 0;
                }
                else
                {
                    _balance -= Price;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        //base constructer, that sets the balance of the buyer
        public Buyer(decimal balance)
        {
            _balance = balance;
        }
    }

    //class BusinessBuyer that inherit from Buyer
    class BusinessBuyer : Buyer
    {
        //variable initialization
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

        //returns the maximal amount of money the buyer have
        new public decimal Balance
        {
            get
            {
                return _credits + _balance;
            }
        }

        //ToString method
        public override string ToString()
        {
            return "BusinessBuyer with CVR: " + _cvr + "\n a balance of: " + _balance + "\n and credits: " + _credits + " availible";
        }

        //extendeding the constructor from the base
        public BusinessBuyer(decimal balance, decimal credit, int CVR)
            : base(balance)
        {
            _credits = credit;
            _cvr = CVR;
        }
    }

    //class PrivateBuyer that inherit from Buyer
    class PrivateBuyer : Buyer
    {
        //variable initialization
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

        //extendeding the constructor from the base
        public PrivateBuyer(decimal balance, int CPR)
            : base(balance)
        {
            _cpr = CPR;
        }

        //ToString method
        public override string ToString()
        {
            return "PrivateBuyer with CPR: " + _cpr + "\n and a balance of: " + _balance;
        }
    }
}
