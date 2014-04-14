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

            Vehicle.Size sizeBus1 = new Vehicle.Size();       //Values to calculate the size of the bus
            sizeBus1.Depth = 2;
            sizeBus1.Height = 5;
            sizeBus1.Width = 3;

                Bus Bus1 = new Bus("Volvo B10M Carrus 302",
                    2967165,
                    "QE25987",
                    1998,
                    10000,
                    false,
                    0,
                    Vehicle.FuelType.Diesel,
                    12000,
                    47,
                    47,
                    false,
                    sizeBus1,
                    7);

            Vehicle.Size sizeBus2 = new Vehicle.Size();
                sizeBus2.Depth=2;
                sizeBus2.Height=5;
                sizeBus2.Width=3;

                Bus Bus2 = new Bus( "Scania Irizar",
                    982505,
                    "KS12387",
                    1997,
                    21000,
                    true,
                    0,
                    Vehicle.FuelType.Diesel,
                    12000,
                    49,
                    49,
                    true,
                    sizeBus2,
                    9.2);


                Truck Truck1 = new Truck("Scania 114 380 stetter",  //Name of vehicle
                    417000,                                         //Km driven
                    "QW89746",                                      //License number
                    2005,                                           //Year the car was build
                    108000,                                         //Price of the car
                    true,                                           //Has the truck got a tow hook
                    0,                                              //KM per liter
                    Vehicle.FuelType.Diesel,                        //The fuel the truck uses
                    0,                                              //minimum price
                    6000,                                           //load capacity
                    3.5,                                            //height in metres
                    15000,                                          //Weight of vehicle
                    9);                                             //Length in metres

                Truck Truck2 = new Truck("Volvo FM9 260", //Name of vehicle
                    213000,                               //Km driven
                    "GH65986",                            //License number
                    2006,                                 //Year the car was build
                    102000,                               //Price of the car
                    false,                                //Has the truck got a tow hook
                    0,                                    //KM per liter
                    Vehicle.FuelType.Gasoline,            //The fuel the truck uses
                    0,                                    //minimum price
                    8000,                                 //load capacity
                    4,                                    //height in metres
                    18000,                                //Weight of vehicle
                    12);                                  //Length in metres

                Camper Camper1 = new Camper("Fiat CI Fiat Ducato Riviera 55 Special P",
                    417000,
                    "QW89746",
                    2005,
                    108000,
                    true,
                    0,
                    Vehicle.FuelType.Diesel,
                    0,
                    2,                                  //seats
                    4,                                  //beds
                    false,                              //toilet
                    0.7);                               //EnergyclassModifier 
                
            Camper Camper2 = new Camper("Hymer 544 classic",
                                            213000,
                                            "GH65986",
                                            2006,
                                            102000,
                                            false,
                                            0,
                                            Vehicle.FuelType.Diesel,
                                            18000,
                                            4,
                                            8,
                                            true,
                                            0.8);

            PersonVehiclePrivate PersonVehiclePrivate1 = new PersonVehiclePrivate();
                PersonVehiclePrivate1.Name = "Audi A6 Avant";
                PersonVehiclePrivate1.Km = 309000;
                PersonVehiclePrivate1.Registration = "PH48689";
                //PersonVehiclePrivate1.Year = 2008;
                PersonVehiclePrivate1.NewPrice = 420000;
                //PersonVehiclePrivate1.TowHook = true;
                //PersonVehiclePrivate1.Enginesize = ;
                //PersonVehiclePrivate1.Kmpl = ;
                //PersonVehiclePrivate1.FuelType = Diesel
                PersonVehiclePrivate1.Seat = 5;
                //PersonVehiclePrivate1.Trunk = {2,2,2} SÆT DET HER RIGTIGT OP
                PersonVehiclePrivate1._licenseType = Vehicle.LicenseType.B;
                //PersonVehiclePrivate1.Isofix = true;

            PersonVehiclePrivate PersonVehiclePrivate2 = new PersonVehiclePrivate();
                PersonVehiclePrivate2.Name = "Ford Scorpio";
                PersonVehiclePrivate2.Km = 902120;
                PersonVehiclePrivate2.Registration = "EF46898";
                //PersonVehiclePrivate2.Year = 1999;
                PersonVehiclePrivate2.NewPrice = 180000;
                //PersonVehiclePrivate2.TowHook = true;
                //PersonVehiclePrivate2.Enginesize = ;
                //PersonVehiclePrivate2.Kmpl = ;
                //PersonVehiclePrivate2.FuelType = Diesel
                PersonVehiclePrivate2.Seat = 5;
                //PersonVehiclePrivate2.Trunk = {2,2,2} SÆT DET HER RIGTIGT OP
                PersonVehiclePrivate2._licenseType = Vehicle.LicenseType.B;
                //PersonVehiclePrivate2.Isofix = false;

            PersonVehicleWork PersonVehicleWork1 = new PersonVehicleWork();
                PersonVehicleWork1.Name = "Peugeot Boxer";
                PersonVehicleWork1.Km = 310000;
                PersonVehicleWork1.Registration = "JK45963";
                //PersonVehicleWork1.Year = 203;
                PersonVehicleWork1.NewPrice = 70000;
                //PersonVehicleWork1.TowHook = true;
                //PersonVehicleWork1.Enginesize = ;
                //PersonVehicleWork1.Kmpl = ;
                //PersonVehicleWork1.FuelType = Diesel;
                PersonVehicleWork1.Seat = 2;
                //PersonVehicleWork1.Trunk = {2,2,2} SÆT DET HER RIGTIGT OP
                PersonVehicleWork1._licenseType = Vehicle.LicenseType.BE;
                PersonVehicleWork1.Safetybrace = true;
                //PersonVehicleWork1.LoadCapacity = 0;
            
            PersonVehicleWork PersonVehicleWork2 = new PersonVehicleWork();
                PersonVehicleWork2.Name = "Doblò Cargo";
                PersonVehicleWork2.Km = 20000;
                PersonVehicleWork2.Registration = "IY49635";
                //PersonVehicleWork2.Year = 2008;
                PersonVehicleWork2.NewPrice = 98000;
                //PersonVehicleWork2.TowHook = false;
                //PersonVehicleWork2.Enginesize = ;
                //PersonVehicleWork2.Kmpl = ;
                //PersonVehicleWork2.FuelType = Diesel;
                PersonVehicleWork2.Seat = 2;
                //PersonVehicleWork2.Trunk = {2,2,2} SÆT DET HER RIGTIGT OP
                PersonVehicleWork2._licenseType = Vehicle.LicenseType.BE;
                PersonVehicleWork2.Safetybrace = true;
                //PersonVehicleWork2.LoadCapacity = 0;                



            //VehicleForSale.Add(Bus1);
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

            BusinessBuyer BusinessBuyer = new BusinessBuyer(1500, 50000, 15411);

            Console.WriteLine(BusinessBuyer.GetBalance());

            Console.WriteLine(SalesBot.ReciveOffer(BusinessBuyer, 1, 5000).ToString());

            Console.ReadKey();
        }

        static void SearchName(List<Vehicle> vehicleList, string searchString) {

            IEnumerable<IGrouping<string, Vehicle>> Vehicle2 =
                from p in vehicleList
                where p.Name.Contains(searchString)
                orderby p.Name
                group p by p.Name;


            foreach (Vehicle n in Vehicle2) {
                Console.WriteLine(n.Name);
            }

                    /*
        IEnumerable<IGrouping<string, Person>> persons2 = 
            from p in persons 
            where p.Age >= 18 
            orderby p.LastName, p.FirstName descending //komma-separeret 
            group p by p.LastName;*/


         /*   foreach (Vehicle n in vehicleList) {
                if (n.Name.Contains(searchString)) {
                }
                else {
                    vehicleList.Remove(n);
                }
            }
            return vehicleList;*/
        }



        static List<Vehicle> SearchSeatBeds(List<Vehicle> vehicleList, uint numberOfSeats, uint numberOfBeds) {
            List<Bus> BusList = new List<Bus>();
            List<Camper> CamperList = new List<Camper>();

            foreach (Bus n in vehicleList) {//Det er kun busser og campingvogne der har toiletter.
                    BusList.Add(n);
            }
            foreach (Camper n in CamperList) {
                CamperList.Add(n);
            }

            for (int i = 0; i < BusList.Count; i++) {
                if (BusList[i].Seats < numberOfSeats && BusList[i].Beds < numberOfBeds) {
                    BusList.RemoveAt(i);
                }
            }
            for (int j = 0; j < CamperList.Count; j++) {
                if (CamperList[j].Seat < numberOfSeats && CamperList[j].Beds < numberOfBeds) {
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
