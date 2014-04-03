using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Dimensions = { 1,2,3,4 };
            PersonVehiclePrivate bla = new PersonVehiclePrivate("Test Bil", 0, 2004, 1500, true, 2, 5, Dimensions, true);

            Console.WriteLine("Name: {0}, Year: {1}, Kilometer: {2}, Price: {3}, Tow Hook: {4}, km/l: {5}, TEST: {6}", bla.Name, bla.Year, bla.Km, bla.NewPrice, bla.TowHook.ToString(), bla.KmL, bla.LicenseType.ToString());

            Console.ReadLine();
        }
    }
}
