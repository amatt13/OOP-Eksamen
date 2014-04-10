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
            List<Vehicle> VehicleSold = new List<Vehicle>();
            List<Vehicle> VehicleForSale = new List<Vehicle>();
            List<Seller> Sellers = new List<Seller>();
            List<Buyer> Buyers = new List<Buyer>();
    
            BusinessSeller TestSeller = new BusinessSeller(12345, false);
            Bus TestBus = new Bus();
            TestBus.Name = "WV Polo";
            TestBus.Km = 1500;
            TestBus.Registration = "AS12345";
            TestBus.Beds = 30;
            TestBus.Seat = 45;
            
            
            Sales TestSales = new Sales();

            if (TestSales.PutOpForSale(TestBus, TestSeller, 1500) != 0)
            {
                VehicleForSale.Add(TestBus);
            }
            else
            {
                Console.WriteLine("ERROR ADDING CAR TO CAR LIST!");
            }

            
            Console.ReadKey();
        }
        static List<Vehicle> SearchName(List<Vehicle> vehicleList, string searchString) {

            //bool foundResult = false;
            //ConsoleKeyInfo press;

            foreach (Vehicle n in vehicleList) {
                if (n.Name.Contains(searchString)) {
                    //Console.WriteLine(n.Name);
                    //foundResult = true;
                }
                else {
                    vehicleList.Remove(n);
                }
            }/*
            if (foundResult == false) {
                Console.WriteLine("No matching vehicles were found.\nTry agian? [y]");
                press = Console.ReadKey(true);
                if (press.KeyChar == 'y') {
                    Console.WriteLine("\nType in a new search word and prees Enter.");
                    searchString = (Console.ReadLine()).ToString();
                    SearchName(vehicleList, searchString);
                }
                else {
                    Console.WriteLine(press.Key.ToString());
                }
            }*/
            return vehicleList;
        }
        
    }
}
