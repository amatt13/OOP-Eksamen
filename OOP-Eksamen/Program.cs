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

            Vehicle.Size sizePv1 = new Vehicle.Size();
                sizePv1.Depth=2;
                sizePv1.Height=5;
                sizePv1.Width=3;

            PersonVehiclePrivate PersonVehiclePrivate1 = new PersonVehiclePrivate("Audi A6A vant",
                309000,
                "PH48689",
                2008,
                420000,
                true,
                0,
                Vehicle.FuelType.Gasoline,
                360000,
                5,
                sizePv1,
                true);

            Vehicle.Size sizePv2 = new Vehicle.Size();
            sizePv2.Depth = 2;
            sizePv2.Height = 5;
            sizePv2.Width = 3;

            PersonVehiclePrivate PersonVehiclePrivate2 = new PersonVehiclePrivate("Ford Scorpio",
            902120,
            "EF46898",
            1999,
            180000,
            true,
            0,
            Vehicle.FuelType.Gasoline,
            70000,
            5,
            sizePv2,
            false);
            
            Vehicle.Size sizeWv1 = new Vehicle.Size(); //Wv1 = Work vehicle 1
            sizeWv1.Depth = 2;
            sizeWv1.Height = 5;
            sizeWv1.Width = 3;    

            PersonVehicleWork PersonVehicleWork1 = new PersonVehicleWork("Peugeot Boxer",
            310000,
            "JK45963",
            2003,
            70000,
            false,
            0,
            Vehicle.FuelType.Diesel,
            50000,
            2,
            sizeWv1,
            true,
            350);

            Vehicle.Size sizeWv2 = new Vehicle.Size();
            sizeWv2.Depth = 2;
            sizeWv2.Height = 5;
            sizeWv2.Width = 3;    

            PersonVehicleWork PersonVehicleWork2 = new PersonVehicleWork("Doblò Cargo",             
            20000,
            "IY49635",
            2008,
            98000,
            true,
            0,
            Vehicle.FuelType.Gasoline,
            68000,
            2,
            sizeWv2,
            false,
            400);
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
            PrivateSeller PrivateSeller = new PrivateSeller(114477881144);

            if (SalesBot.ReciveOffer(BusinessBuyer, Bus2, 22000))
            {
                SalesBot.AcceptBid(PrivateSeller, Bus2);
            }

            if (SalesBot.ReciveOffer(BusinessBuyer, Truck1, 22000))
            {
                SalesBot.AcceptBid(PrivateSeller, Truck1);
            }


            Console.WriteLine("ANDERS TEST VVV\n");
            SearchName(VehicleForSale, "Boxer");
            Console.ReadKey();
        }

        static List<Vehicle> SearchName(List<Vehicle> vehicleList, string searchString) {
            //Finder Vehicles i en liste med et specifikt søge ord/sætning. 
            //Spytter det ud igen i en ny liste som kan blive printet.
            IEnumerable<IGrouping<string, Vehicle>> VehicleSorted =
                from p in vehicleList
                where p.Name.Contains(searchString)
                orderby p.Name
                group p by p.Name;

            List<Vehicle> ReturnVehicles = new List<Vehicle>();

            foreach (IGrouping<string, Vehicle> testcars in VehicleSorted) {
                foreach (Vehicle cars in testcars) {
                    ReturnVehicles.Add(cars);
                }
            }

            return ReturnVehicles;
        }



     //   static List<Vehicle> SearchSeatBeds(List<Vehicle> vehicleList, uint numberOfSeats, uint numberOfBeds) {


            /*
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
             */
 //       }
    }
}
