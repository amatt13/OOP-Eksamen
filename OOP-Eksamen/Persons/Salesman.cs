using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Salesman
    {
        private decimal _balance;
        private int _zipCode;
        protected bool _notification;

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

        public int ZipCode {
            get
            {
                return this._zipCode;
            }

            set
            {
                this._zipCode = value;
            }
        }

        public Salesman(bool Notification) {
            this._notification = Notification;
        }

        public void ReceiveBidNotification(){
            if (this._notification)
            {
                Console.WriteLine();
            }
        }

        public bool AddBalance(decimal Amount)
        {
            this._balance += Amount;
            return true;
        }
    }
}
