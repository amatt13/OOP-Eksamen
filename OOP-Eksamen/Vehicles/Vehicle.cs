using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public class Vehicle
    {
        public string Name
        {
            get;
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
            get;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Kilometers is below 0", "KmTooLow");
                }
                else
                {
                    this.Km = value;
                }
            }
        }
        public string Registration
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        protected int Year { get; }
        private double NewPrice
        {
            get;

            set
            {
                if (value < 0)
                {
                    this.NewPrice = 0;
                }
                else
                {
                    this.NewPrice = value;
                }
            }
        }
        private bool

        private bool _towHook;
        protected LicenseType _licenseType;
        protected double _engineSize;
        private double _kmL;
        private Fuel _fuel;
        private EnergyClass _energyClass;


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

        public Vehicle()
        {

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
}
