using System;
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
        private int _year;
        private int _newPrice;
        private bool _towHook;
        private enum _licenseType { A, B, C, D, BE, CE, DE }
        private double _engineSize;
        private double _kmL;
        private enum _fuel { Diesel, Gasoline }
        private enum _energyClass { A, B, C, D }

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
            set { throw new NotImplementedException(); }
        }

        public int NewPrice
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



    }

    /*
    private class PersonVehicle : Vehicle
    {
        int Seat { get; set; }
        double[] Dimensions = new double[3]; // Højde, Lægnde, Bredde
    }

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
