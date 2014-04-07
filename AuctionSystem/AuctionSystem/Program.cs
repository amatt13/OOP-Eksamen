using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            PrivateSeller privateSeller1 = new PrivateSeller();
            PersonalCar pCar = new PersonalCar();
            Van van = new Van();
            Autocamper aCam = new Autocamper();
            privateSeller1.Vehicles.Add(pCar);
            privateSeller1.Vehicles.Add(van);
            privateSeller1.Vehicles.Add(aCam);

            CompanySeller companySeller1 = new CompanySeller();
            Bus bus = new Bus();
            Truck truck = new Truck();
            companySeller1.Vehicles.Add(bus);
            companySeller1.Vehicles.Add(truck);

            PrivateBuyer privateBuyer1 = new PrivateBuyer();
            CompanyBuyer companyBuyer1 = new CompanyBuyer();

            AuctionHouse ah = new AuctionHouse();

            ah.ForSale.AddRange(privateSeller1.Vehicles);
            ah.ForSale.AddRange(companySeller1.Vehicles);

            ah.Sellers.Add(privateSeller1);
            ah.Sellers.Add(companySeller1);

            ah.Buyers.Add(privateBuyer1);
            ah.Buyers.Add(companyBuyer1);

            Console.WriteLine("For sale:");

            foreach (Vehicle vh in ah.ForSale) {
                Console.WriteLine(vh.ToString());
            }

            Console.WriteLine("\nBuyers:");

            foreach(Buyer by in ah.Buyers){
                Console.WriteLine(by.Balance);
            }

            Console.WriteLine("\nSellers:");

            foreach (Seller sl in ah.Sellers){
                Console.WriteLine(sl.Balance);
                sl.Notified();
            }

            Console.ReadKey();
        }
    }
}
