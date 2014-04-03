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
            PersonVehiclePrivate bla = new PersonVehiclePrivate();

            Console.WriteLine("Name: {0}, Kilometer: {2}, Price: {3}, Tow Hook: {4}, km/l: {5}, TEST: {6}", bla.Name, bla.Km, bla.NewPrice, bla.TowHook.ToString(), bla.KmL, bla.LicenseType.ToString());

            Console.ReadLine();
        }
    }
}
