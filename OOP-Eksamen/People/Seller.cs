using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Seller
    {
        protected decimal _balance;
        protected int _zipCode;

        public List<Vehicle> Vehicles = new List<Vehicle>();

        public decimal Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            }
        }

        public int ZipCode
        {
            get
            {
                return _zipCode;
            }

            set
            {
                _zipCode = value;
            }
        }

        public void AddBalance(decimal Price)
        {
            _balance += Price;
        }

        public static void SMS(Vehicle K)
        {
            Console.WriteLine("I received a notification SMS on vehicle" + K.ToString());
        }
    }

    class BusinessSeller : Seller
    {
        private long _cvr;

        public long CVR
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

        public BusinessSeller(long CVR, int ZipCode)
        {
            _balance = 0;
            _cvr = CVR;
            _zipCode = ZipCode;
        }
    }

    class PrivateSeller : Seller
    {
        private long _cpr;

        public long CPR
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

        public PrivateSeller(long CPR, int ZipCode)
        {
            _balance = 0;
            _cpr = CPR;
            _zipCode = ZipCode;
        }
    }

}
