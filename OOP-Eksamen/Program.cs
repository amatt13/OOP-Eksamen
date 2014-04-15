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
                    900);


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
                    7000,                                           //Weight of vehicle
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

            Car Car1 = new Car("Audi A6A vant",
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

            Car Car2 = new Car("Ford Scorpio",
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

            Van Van1 = new Van("Peugeot Boxer",
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

            Van Van2 = new Van("Doblò Cargo",             
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



            //VehicleForSale.Add(Bus1);
            SalesBot.VehicleForSale.Add(Bus2);
            SalesBot.VehicleForSale.Add(Truck1);
            SalesBot.VehicleForSale.Add(Truck2);
            SalesBot.VehicleForSale.Add(Camper1);
            SalesBot.VehicleForSale.Add(Camper2);
            SalesBot.VehicleForSale.Add(Car1);
            SalesBot.VehicleForSale.Add(Car2);
            SalesBot.VehicleForSale.Add(Van1);
            SalesBot.VehicleForSale.Add(Van2);

            foreach (Vehicle testv in SalesBot.VehicleForSale)
            {
                //Console.WriteLine(testv.ToString());
            }

            BusinessBuyer BusinessBuyer  = new BusinessBuyer(1500, 50000, 15411);

            PrivateSeller PrivateSeller1 = new PrivateSeller(4477881144, 7800);
            PrivateSeller PrivateSeller2 = new PrivateSeller(4564894568, 9700);
            PrivateSeller PrivateSeller3 = new PrivateSeller(1234567895, 9210);
            PrivateSeller PrivateSeller4 = new PrivateSeller(1234568789, 4800);
            PrivateSeller PrivateSeller5 = new PrivateSeller(9865123584, 2700);
            PrivateSeller PrivateSeller6 = new PrivateSeller(6585348963, 3500);

            SalesBot.PutOpForSale(Truck1, PrivateSeller1, 1500, true);
            SalesBot.PutOpForSale(Truck2, PrivateSeller1, 1500, true);
            SalesBot.PutOpForSale(Van1, PrivateSeller2, 2000, true);
            SalesBot.PutOpForSale(Van2, PrivateSeller2, 8000, true);
            SalesBot.PutOpForSale(Car1, PrivateSeller3, 16000, true);
            SalesBot.PutOpForSale(Car2, PrivateSeller4, 4500, true);
            SalesBot.PutOpForSale(Bus1, PrivateSeller5, 68000, true);
            SalesBot.PutOpForSale(Bus2, PrivateSeller2, 480000, true);
            SalesBot.PutOpForSale(Camper1, PrivateSeller6, 1200, true);
            SalesBot.PutOpForSale(Camper2, PrivateSeller6, 2400000, true);

            if (SalesBot.ReciveOffer(BusinessBuyer, Truck1.AuctionNumber, 22000))
            {
                SalesBot.AcceptBid(PrivateSeller1, Truck1.AuctionNumber);
            }
            double i = 8000;
            SearchBigWeight(SalesBot.VehicleForSale, i);


            Console.ReadKey();
        }

        static List<Vehicle> SearchName(List<Vehicle> vehicleList, string searchString) { //Opgave 1
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

        static List<Vehicle> SearchSeatsToilet(List<Vehicle> vehicleList, uint numberOfSeats, bool HaveToilet) { //Opgave2

            List<Vehicle> ReturnList = new List<Vehicle>();

            foreach (Vehicle n in vehicleList) {//Det er kun busser og campingvogne der har toiletter.
                if (n is Bus){
                    if (((Bus)n).Seats >= numberOfSeats && ((Bus)n).Toilet == HaveToilet) {
                        ReturnList.Add(n);
                    }
                }
                else if (n is Camper) {
                    if (((Camper)n).Seats >= numberOfSeats && ((Camper)n).Toilet == HaveToilet) {
                        ReturnList.Add(n);
                    }
                }
            }
           
            return ReturnList;
       }

        static List<Vehicle> SearchBigWeight(List<Vehicle> vehicleList, double maxWeigth)//Opgave 3
        {

            List<Vehicle> ReturnList = new List<Vehicle>();

            foreach (Vehicle n in vehicleList) //Der er ingen grund til at søge efter licensetype, da det kun er bus og truck der er indbefattet i C,CE,D & DE
            {
                if (n is Bus)
                {
                    if (((Bus)n).Weight <= maxWeigth)
                    {
                        ReturnList.Add(n);

                    }
                }
                else if (n is Truck)
                {
                    if (((Truck)n).Weight <= maxWeigth)
                    {
                        ReturnList.Add(n);                    
                    }
                }
            }
            return ReturnList;
        }

/*
Find alle køretøjer hvor køretøjets sælger er bosiddende inden for en bestemt radius af et angivet postnummer. 
 * I denne forbindelse kan radius blot anskues som et tal der skal lægges til/trækkes fra postnummeret. F.eks. 
 * vil en søgning efter køretøjer indenfor en radius af 1500 fra postnummer 8000, inkludere alle køretøjer hvor 
 * sælgers postnummer ligger mellem 6500 og 9500.*/
        //PrivateSeller.Zipcode

        static List<Vehicle> SearchRadius(List<Seller> sellerlist, int Radius)//Opgave 3
        {

            List<Vehicle> ReturnList = new List<Vehicle>();

            foreach (Seller n in sellerlist) //
            {
                
                
               
            }
            return ReturnList;
        }

    }
}
