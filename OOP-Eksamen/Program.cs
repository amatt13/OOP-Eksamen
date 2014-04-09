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
            List<Vehicle> VehicleForSale = new List<Vehicle>();
            List<Seller> Sellers = new List<Seller>();
            List<Buyer> Buyers = new List<Buyer>();
    
            BusinessSeller TestSeller = new BusinessSeller(12345, false);
            Bus TestBus = new Bus();

            Sales TestSales = new Sales();
            TestSales.PutOpForSale(TestBus, TestSeller, 1500);

            Console.ReadKey();
        }
    }
}
