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
            Sales SalesBot = new Sales();

            Bus TestBus = new Bus();
            TestBus.Seat = 2;
            TestBus.Weight = 500.52;

            VehicleForSale.Add(TestBus);

            foreach( Vehicle testv in VehicleForSale ){
                Console.WriteLine(testv.ToString());
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
