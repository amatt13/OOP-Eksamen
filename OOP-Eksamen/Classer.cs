using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public enum LicenseType
    {
        A,
        B,
        C,
        D,
        BE,
        CE,
        DE
    }

    public enum Fuel
    {
        Diesel,
        Gasoline
    }

    public enum EnergyClass
    {
        A,
        B,
        C,
        D
    }

    public class Vehicle
    {
        private string _name;
        private uint _km;
        private string _registration;
        protected int _year;
        private double _newPrice;
        private bool _towHook;
        protected LicenseType _licenseType;
        protected double _engineSize;
        private double _kmL;
        private Fuel _fuel;
        private EnergyClass _energyClass;

        public string Name
        {
            get { return _name; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Vehicle name not set", "NoVehicleName");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public uint Km
        {
            get { return _km; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Kilometers is below 0", "KmTooLow");
                }
                else
                {
                    _km = value;
                }
            }
        }

        public string Registration
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int Year
        {
            get { return _year; }
        }

        public double NewPrice
        {
            get { return _newPrice; }

            set
            {
                if (value < 0)
                {
                    _newPrice = 0;
                }
                else
                {
                    _newPrice = value;
                }
            }
        }

        public bool TowHook
        {
            get { return _towHook; }
            set
            {
                _towHook = value;
            }
        }

        public double KmL
        {
            get { return _kmL; }
            set { _kmL = value; }
        }

        public Vehicle(){

        }

        public Vehicle(string Name, uint Km, int Year, double NewPrice, bool TowHook, double KmL)
        {
            this.Name = Name;
            this.Km = Km;
            //this.Registration
            _year = Year;
            this.NewPrice = NewPrice;
            this.TowHook = TowHook;
            this.KmL = KmL;
        }

        /*
        public override string ToString()
        {
            return String.Format("{0} - {1}", this.ID, this.Title);
        }
        */
    }

    public class PersonVehicle : Vehicle
    {
        private int _seat;
        private double[] _dimensions = new double[3]; // Højde, Lægnde, Bredde

        public int Seat { get; set; }

        public PersonVehicle(string Name, uint Km, int Year, double NewPrice, bool TowHook, double KmL)
        {
            this.Name = Name;
            this.Km = Km;
            _year = Year;
            this.NewPrice = NewPrice;
            this.TowHook = TowHook;
            this.KmL = KmL;
        }
}

    /*
    public class PersonVehiclePrivate : PersonVehicle
    {
        bool IsofixMount { get; set; }
    }

    public class PersonVehicleWork : PersonVehicle
    {
        bool SafetyBar { get; set; }
        int LoadCapacity { get; set; }
    }

    public class Truck : Vehicle
    {
        int LoadCapacity { get; set; }
        double Height { get; set; }
        double Length { get; set; }
        int Weight { get; set; }

    }

    public class Bus : Vehicle
    {
        int Seat { get; set; }
        int Beds { get; set; }
        bool Toilet { get; set; }
        double Height { get; set; }
        double Length { get; set; }
        int Weight { get; set; }
    }

    public class Camper : Vehicle
    {
        int Seat { get; set; }
        int Beds { get; set; }
        bool Toilet { get; set; }
        enum Heat { Gas, Electricity, Oil }
    }
    */
}
