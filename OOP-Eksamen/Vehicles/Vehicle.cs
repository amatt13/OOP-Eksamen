﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
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
            get
            {
                return _name;
            }
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
            get
            {
                return _km;
            }
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
            get
            {
                return _newPrice;
            }

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

        public bool TowHook {
            get
            {
                return _towHook;
            }

            set
            {
                _towHook = value;
            }
        }

        public double KmL
        {
            get
            {
                return _kmL;
            }

            set
            {
                _kmL = value;
            }
        }

        public double EngineSize
        {
            get
            {
                return _energyClass;
            }

            set
            {
                _energyClass = value;
            }
        }


        public Vehicle(){}

        public override string ToString()
        {
            throw new NotImplementedException();
            //return ;
        }
    }
}
