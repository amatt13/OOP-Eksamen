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
            sizeBus2.Depth = 2;
            sizeBus2.Height = 5;
            sizeBus2.Width = 3;

            Bus Bus2 = new Bus("Scania Irizar",
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
            sizePv1.Depth = 2;
            sizePv1.Height = 5;
            sizePv1.Width = 3;

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

            AuctionHouse AH = new AuctionHouse();

            //Buyers
            Buyer BBuyer1 = new BusinessBuyer(150000000, 50000, 15411);
            Buyer PBuyer1 = new PrivateBuyer(150000000, 50000);

            AH.Buyers.Add(BBuyer1);
            AH.Buyers.Add(PBuyer1);



            Console.WriteLine("_______________Buyers_______________");
            foreach (Buyer b in AH.Buyers)
            {
                Console.WriteLine(b.ToString());
            }

            //Sellers
            Seller PSeller1 = new PrivateSeller(4477881144, 7800, 0);
            Seller PSeller2 = new PrivateSeller(4564894568, 9700, 0);
            Seller BSeller1 = new BusinessSeller(1234568789, 4800, 0);
            Seller BSeller2 = new BusinessSeller(1234568789, 4800, 0);

            AH.Sellers.Add(PSeller1);
            AH.Sellers.Add(PSeller2);
            AH.Sellers.Add(BSeller1);
            AH.Sellers.Add(BSeller2);

            Console.WriteLine("\n_______________Sellers_______________");
            foreach (Seller s in AH.Sellers)
            {
                Console.WriteLine(s.ToString());
            }

            AH.PutOpForSale(Van1, BSeller1, 1500, new AuctionHouse.NotificationMethod(PrivateSeller.SMS));
            AH.PutOpForSale(Van2, BSeller2, 1500, new AuctionHouse.NotificationMethod(PrivateSeller.Email));
            AH.PutOpForSale(Truck1, PSeller2, 1500, new AuctionHouse.NotificationMethod(PrivateSeller.SMS));
            AH.PutOpForSale(Truck2, BSeller1, 1500, new AuctionHouse.NotificationMethod(PrivateSeller.SMS));
            AH.PutOpForSale(Camper1, BSeller2, 1500, new AuctionHouse.NotificationMethod(PrivateSeller.SMS));
            AH.PutOpForSale(Camper2, PSeller2, 1500, new AuctionHouse.NotificationMethod(PrivateSeller.Email));
            AH.PutOpForSale(Car1, PSeller1, 1500, new AuctionHouse.NotificationMethod(PrivateSeller.Email));
            AH.PutOpForSale(Car2, PSeller1, 1500, new AuctionHouse.NotificationMethod(PrivateSeller.SMS));
            AH.PutOpForSale(Bus1, PSeller2, 1500, new AuctionHouse.NotificationMethod(PrivateSeller.Email));
            AH.PutOpForSale(Bus2, BSeller1, 1500, new AuctionHouse.NotificationMethod(PrivateSeller.SMS));

            Console.WriteLine("\n_______________Vehicles for sale_______________");

            foreach (Vehicle v in AH.VehiclesForSale)
            {
                Console.WriteLine(v.ToString());
            }

            Console.WriteLine("\n\n\n");

            AH.ReciveOffer(PBuyer1, Van1.AuctionNumber, 22000);
            AH.ReciveOffer(BBuyer1, Van1.AuctionNumber, 21000);

            Console.WriteLine("\n The bids:");
            IEnumerable<VehicleBids> bids = AH.Bids.Where(t => t.AuctionNumber == Van1.AuctionNumber);

            bids.OrderBy(t => t.Bid);

            foreach (VehicleBids bid in bids)
            {
                Console.WriteLine("Bid: " + bid.Bid + "Placed" + bid.BidPlaced);
            }

            Console.WriteLine("\n Sell: y/n? ");
            ConsoleKeyInfo choice = Console.ReadKey();

            if (choice.KeyChar.Equals('y'))
                AH.AcceptBid(AH.Sellers[0], Van1.AuctionNumber);

            foreach (Vehicle v in AH.VehiclesSold)
            {
                Console.WriteLine(v.ToString());
            }

            double i = 8000;
            SearchHeavierThan(AH.VehiclesForSale, i);

            Console.ReadKey();
        }

        static List<Vehicle> SearchName(List<Vehicle> vehicleList, string searchString)
        { //Opgave 1
            //Finder Vehicles i en liste med et specifikt søge ord/sætning. 
            //Spytter det ud igen i en ny liste som kan blive printet.
            IEnumerable<IGrouping<string, Vehicle>> VehicleSorted =
                from p in vehicleList
                where p.Name.Contains(searchString)
                orderby p.Name
                group p by p.Name;

            List<Vehicle> ReturnVehicles = new List<Vehicle>();

            foreach (IGrouping<string, Vehicle> testcars in VehicleSorted)
            {
                foreach (Vehicle cars in testcars)
                {
                    ReturnVehicles.Add(cars);
                }
            }

            return ReturnVehicles;
        }

        static List<Vehicle> SearchSeatsToilet(List<Vehicle> vehicleList, uint numberOfSeats, bool HaveToilet)
        { //Opgave2

            List<Vehicle> ReturnList = new List<Vehicle>();

            foreach (Vehicle n in vehicleList)
            {//Det er kun busser og campingvogne der har toiletter.
                if (n is Bus)
                {
                    if (((Bus)n).Seats >= numberOfSeats && ((Bus)n).Toilet == HaveToilet)
                    {
                        ReturnList.Add(n);
                    }
                }
                else if (n is Camper)
                {
                    if (((Camper)n).Seats >= numberOfSeats && ((Camper)n).Toilet == HaveToilet)
                    {
                        ReturnList.Add(n);
                    }
                }
            }

            return ReturnList;
        }

        static List<Vehicle> SearchHeavierThan(List<Vehicle> vehicleList, double maxWeigth)//Opgave 3
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


        static List<Vehicle> FindCars(List<Vehicle> Vehicles, int MaxKM, int MinPrice) //Opgave 4
        {
            IEnumerable<Vehicle> ReturnList = Vehicles.Where(v => v.GetType() == typeof(Car) && v.Km <= MaxKM && v.MinPrice <= MinPrice).OrderByDescending(v => v.Km);

            return ReturnList.ToList();
        }

        /*
        Find alle køretøjer hvor køretøjets sælger er bosiddende inden for en bestemt radius af et angivet postnummer. 
         * I denne forbindelse kan radius blot anskues som et tal der skal lægges til/trækkes fra postnummeret. F.eks. 
         * vil en søgning efter køretøjer indenfor en radius af 1500 fra postnummer 8000, inkludere alle køretøjer hvor 
         * sælgers postnummer ligger mellem 6500 og 9500.*/
        //PrivateSeller.Zipcode

        static List<Seller> SearchRadius(List<Seller> sellerlist, int zipCode, int radius)//Opgave 5
        {

            List<Seller> ReturnList = new List<Seller>();

            foreach (Seller s in sellerlist) //
            {
                if (s.ZipCode > zipCode - radius && s.ZipCode < zipCode + radius)
                {
                    ReturnList.Add(s);
                }
            }
            return ReturnList;
        }

        static double AVGEnergyClass(List<Vehicle> Vehicles) //Opgave 6
        {
            int avg = 0;

            foreach (Vehicle car in Vehicles)
            {
                avg += ((int)car._energyClass + 1);
            }

            return (avg / Vehicles.Count);
        }
    }
}
