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
            Vehicle bla = new Vehicle();
            bla.Name = "Test Bil";
            bla.Km = 0;
            //bla.Registration = "AS1234";
            bla.NewPrice = -1;

            Console.WriteLine("Name: {0}, Kilometer: {1}, Price: {2}", bla.Name, bla.Km, bla.NewPrice);

            Console.ReadLine();
        }
    }
}
