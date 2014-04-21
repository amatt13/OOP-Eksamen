using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Seller
    {
        //variable initialization
        protected decimal _balance;
        protected int _zipCode;

        //List of all the vehicle the seller has
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

        //method to add balance to the buyers account
        public void AddBalance(decimal Price)
        {
            _balance += Price;
        }

        //Contact method to send SMS
        public static void SMS(Vehicle v)
        {
            Console.WriteLine("I received a notification SMS");
        }
        //Contact method to send mail
        public static void Email(Vehicle v)
        {
            Console.WriteLine("I received a notification Email");
        }

        //Contact method to send detailed sms
        public static void SMSDetailed(Vehicle v)
        {
            Console.WriteLine("I received a notification SMS on vehicle" + v.ToString());
        }

        //Contact method to send detailed mail
        public static void EmailDetailed(Vehicle v)
        {
            Console.WriteLine("I received a notification Email" + v.ToString());
        }

        //base constructor
        public Seller(int ZipCode, decimal balance)
        {
            _balance = balance;
            _zipCode = ZipCode;
        }

    }

    //class BusinessSeller that inherit from Seller
    class BusinessSeller : Seller
    {
        //variable initialization
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

        //extendeding the constructor from the base
        public BusinessSeller(long CVR, int ZipCode, decimal balance)
            : base(ZipCode, balance)
        {
            _cvr = CVR;
        }

        //ToString method
        public override string ToString()
        {
            return "BusinessSeller with CVR: " + _cvr + "\n a balance of: " + _balance + "\n and ZipCode: " + _zipCode;
        }

    }

    //class PrivateSeller that inherit from Seller
    class PrivateSeller : Seller
    {
        //variable initialization
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

        //extendeding the constructor from the base
        public PrivateSeller(long CPR, int ZipCode, decimal balance)
            : base(ZipCode, balance)
        {
            _cpr = CPR;
        }

        //ToString method
        public override string ToString()
        {
            return "PrivateSeller with CPR: " + _cpr + "\n a balance of: " + _balance + "\n and ZipCode: " + _zipCode;
        }
    }

}
