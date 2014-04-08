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
        protected bool _notification;

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

        public bool ReceiveNotificationAboutBid()
        {
            Console.WriteLine("OMG I GOT BID, SUCH PRICE!!!");
            return true;
        }
    }

    class BusinessSeller : Seller
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

        public void AddBalance(decimal Price)
        {
            _balance += Price;
        }

        public BusinessSeller(int CVR, bool Notification)
        {
            _balance = 0;
            _cvr = CVR;
            _notification = Notification;
        }
    }

    class PrivateSeller : Seller
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

        public void AddBalance(decimal Price)
        {
            _balance += Price;
        }

        public PrivateSeller(int CPR, bool Notification)
        {
            _balance = 0;
            _cpr = CPR;
            _notification = Notification;
        }
    }

}
