using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen {
    class Buyer {
        protected decimal _balance;

        //The Balance has been made read-only
        public decimal Balance {
            get {
                return _balance;
            }
        }

		public bool RemoveBalance(decimal Price) {
            if (Price < _balance) {
                if (_balance < Price) {
                    Price -= _balance;
                    _balance = 0;
                } else {
                    _balance -= Price;
                }

                return true;
            } else {
                return false;
            }
        }

		public Buyer(decimal balance) {
            _balance = balance;
        }
    }

    class BusinessBuyer : Buyer {
        private int _cvr;
        private decimal _credits;

        public int CVR {
            get {
                return _cvr;
            }

            set {
                _cvr = value;
            }
        }

		new public decimal Balance {
            get {
                return _credits + _balance;
            }
        }

		new public bool RemoveBalance(decimal Price) {
            if (Price < (_balance + _credits)) {
                if (_balance < Price) {
                    Price -= _balance;
                    _credits -= Price;
                    _balance = 0;
                } else {
                    _balance -= Price;
                }

                return true;
            } else {
                return false;
            }
        }

        public override string ToString(){
            return "BusinessBuyer with CVR: " + _cvr + "\n a balance of:´" + _balance + "\n and credits: " + _credits + "availible";
        }

        public BusinessBuyer(decimal balance, decimal credit, int CVR)
            : base(balance) {
            _credits = credit;
            _cvr = CVR;
        }
    }

    class PrivateBuyer : Buyer {
        private int _cpr;

        public int CPR {
            get {
                return _cpr;
            }

            set {
                _cpr = value;
            }
        }

        public PrivateBuyer(decimal balance, int CPR)
            : base(balance) {
            _cpr = CPR;
        }

        public override string ToString() {
            return "PrivateBuyer with CPR: " + _cpr + "\n and a balance of: " + _balance;
        }
    }
}
