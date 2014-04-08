using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Seller
    {
        private decimal _balance;
        private int _zipCode;
        private bool _notification;

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
}
