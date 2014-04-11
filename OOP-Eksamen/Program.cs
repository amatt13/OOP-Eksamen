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

            Bus Bus1 = new Bus();
            Bus Bus2 = new Bus();
            Truck Truck1 = new Truck();
            Truck Truck2 = new Truck();
            Camper Camper1 = new Camper();
            Camper Camper2 = new Camper();
            PersonVehiclePrivate PersonVehiclePrivate1 = new PersonVehiclePrivate();
            PersonVehiclePrivate PersonVehiclePrivate2 = new PersonVehiclePrivate();
            PersonVehicleWork PersonVehicleWork1 = new PersonVehicleWork();
            PersonVehicleWork PersonVehicleWork2 = new PersonVehicleWork();
            

            VehicleForSale.Add(Bus1);
            VehicleForSale.Add(Bus2);
            VehicleForSale.Add(Truck1);
            VehicleForSale.Add(Truck2);
            VehicleForSale.Add(Camper1);
            VehicleForSale.Add(Camper2);
            VehicleForSale.Add(PersonVehiclePrivate1);
            VehicleForSale.Add(PersonVehiclePrivate2);
            VehicleForSale.Add(PersonVehicleWork1);
            VehicleForSale.Add(PersonVehicleWork2);
            
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
        static List<Vehicle> SearchSeatToilet(List<Vehicle> vehicleList, uint numberOfSeats, uint numberOfToilets) {
            List<Bus> BusList = new List<Bus>();
            List<Camper> CamperList = new List<Camper>();

            foreach (Bus n in vehicleList) {//Det er kun busser og campingvogne der har toiletter.
                    BusList.Add(n);
            }
            foreach (Camper n in CamperList) {
                CamperList.Add(n);
            }

            for (int i = 0; i < BusList.Count; i++) {
                if (BusList[i].Seat < numberOfSeats && BusList[i].Toilet < numberOfToilets) {
                    BusList.RemoveAt(i);
                }
            }
            for (int j = 0; j < CamperList.Count; j++) {
                if (CamperList[j].NumberOfSeats < numberOfSeats && CamperList[j].Toilet < numberOfToilets) {
                    CamperList.RemoveAt(j);
                }
            }

            List<Vehicle> SearchList = new List<Vehicle>();
            SearchList.AddRange(BusList);
            SearchList.AddRange(CamperList);

            return SearchList;
        }
    }
}
