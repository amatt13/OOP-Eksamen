using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen {
class Seller {
    protected decimal _balance;
    protected int _zipCode;

    public List<Vehicle> Vehicles = new List<Vehicle>();

    public decimal Balance {
        get {
            return _balance;
        }

        set {
            _balance = value;
        }
    }

    public int ZipCode {
        get {
            return _zipCode;
        }

        set {
            _zipCode = value;
        }
    }

    public void AddBalance(decimal Price) {
        _balance += Price;
    }

    public static void SMS(Vehicle v) {
        Console.WriteLine("I received a notification SMS");
    }

    public static void Email(Vehicle v) {
        Console.WriteLine("I received a notification Email");
    }

    public static void SMSDetailed(Vehicle v) {
        Console.WriteLine("I received a notification SMS on vehicle" + v.ToString());
    }

    public static void EmailDetailed(Vehicle v) {
        Console.WriteLine("I received a notification Email" + v.ToString());
    }

    public Seller(int ZipCode, decimal balance) {
        _balance = balance;
        _zipCode = ZipCode;
    }

}

class BusinessSeller : Seller {
    private long _cvr;

    public long CVR {
        get {
            return _cvr;
        }

        set {
            _cvr = value;
        }
    }

    public BusinessSeller(long CVR, int ZipCode, decimal balance): base(ZipCode, balance) {
        _cvr = CVR;
    }

    public override string ToString() {
        return "BusinessSeller with CVR: " + _cvr + "\n a balance of:´" + _balance + "\n and ZipCode: " + _zipCode;
    }

}

class PrivateSeller : Seller {
    private long _cpr;

    public long CPR {
        get {
            return _cpr;
        }

        set {
            _cpr = value;
        }
    }

    public PrivateSeller(long CPR, int ZipCode, decimal balance) : base(ZipCode, balance) {
        _cpr = CPR;
    }

    public override string ToString() {
        return "PrivateSeller with CPR: " + _cpr + "\n a balance of:´" + _balance + "\n and ZipCode: " + _zipCode;
    }
}

}
