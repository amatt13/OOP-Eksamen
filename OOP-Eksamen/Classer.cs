using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Classer
    {
        private class Vehicle 
        {
            string Name { get; set; }
            int Km { get; set; }
            string Registration { get; set; }
            int Year { get; }
            int NewPrice { get; set; }
            bool TowHook { get; set; }
            enum LicenseType { A, B, C, D, BE, CE, DE };
            double EngineSize { get; set; }
            double KmL { get; set; }
            enum Fuel { Diesel, Gasoline }
            enum EnergyClass { A, B, C, D }
        }

        private class PersonVehicle : Vehicle {
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

        public class Camper : Vehicle {
            int Seat { get; set; }
            int Beds { get; set; }
            bool Toilet { get; set; }
            enum Heat { Gas, Electricity, Oil }
        }
    }
}
