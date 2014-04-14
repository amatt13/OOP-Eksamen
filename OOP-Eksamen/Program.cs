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

            /*Bus Bus1 = new Bus();
                Bus1.Name = "Volvo B10M Carrus 302";
                Bus1.Km = 296716;
                Bus1.Registration = "QE25987";
                //Bus1.Year = 1998;
                Bus1.NewPrice = 10000;
                //Bus1.TowHook = false;
                Bus1._licenseType = Vehicle.LicenseType.D;
                //Bus1.Enginesize = ;
                //Bus1.Kmpl = ;
                //Bus1.FuelType = ;
                //Bus1.EnergyClass = ;
                Bus1.Seats = 47;
                Bus1.Beds = 47; //Antager at alle stole kan lægges ned
                //Bus1.Toilet = false;
                //Bus1.Height = ;
                //Bus1.Length = ;
                //Bus1.Weight = ;*/

            Vehicle.Size size = new Vehicle.Size();
                size.Depth=2;
                size.Height=5;
                size.Width=3;

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
                                    size,
                                    324);


            Truck Truck1 = new Truck();
                Truck1.Name = "Scania 114 380 stetter";
                Truck1.Km = 417000;
                Truck1.Registration = "QW89746";
                //Truck1.Year = 2005;
                Truck1.NewPrice = 108000;
                //Truck1.TowHook = true;
                Truck1._licenseType = Vehicle.LicenseType.CE;
                //Truck1.Enginesize = ;
                //Truck1.Kmpl = ;
                //Truck1.FuelType = Diesel;
                //Truck1.EnergyClass = ;
                //Truck1.LoadCapacity = ;
                Truck1.Height = 50;
                Truck1.Weight = 32000;
                Truck1.Length = 1000;

            Truck Truck2 = new Truck();
                Truck2.Name = "Volvo FM9 260";
                Truck2.Km = 213000;
                Truck2.Registration = "GH65986";
                //Truck2.Year = 2006;
                Truck2.NewPrice = 102000;
                //Truck2.TowHook = false;
                Truck2._licenseType = Vehicle.LicenseType.C;
                //Truck2.Enginesize = ;
                //Truck2.Kmpl = ;
                //Truck2.FuelType = Diesel;
                //Truck2.EnergyClass = ;
                //Truck2.LoadCapacity = 8000;
                //Truck2.Height = ;
                //Truck2.Weight = 18000;
                //Truck2.Length = ;

            Camper Camper1 = new Camper();
                Camper1.Name = "Fiat CI Fiat Ducato Riviera 55 Special P";
                Camper1.Km = 417000;
                Camper1.Registration = "QW89746";
                //Camper1.Year = 2005;
                Camper1.NewPrice = 108000;
                //Camper1.TowHook = true;
                Camper1._licenseType = Vehicle.LicenseType.CE;
                //Camper1.Enginesize = ;
                //Camper1.Kmpl = ;
                //Camper1.FuelType = Diesel;
                Camper1.Seat = 2;
                Camper1.Beds = 4;
                //Camper1.Toilet  = true;
                //Camper1.HeatSource = Gas;
                //Camper1.EnergyClass = ;
                Camper1._licenseType = Vehicle.LicenseType.B;
                
            Camper Camper2 = new Camper();
                Camper2.Name = "Hymer 544 classic";
                Camper2.Km = 213000;
                Camper2.Registration = "GH65986";
                //Camper2.Year = 2006;
                Camper2.NewPrice = 102000;
                //Camper2.TowHook = false;
                Camper2._licenseType = Vehicle.LicenseType.C;
                //Camper2.Enginesize = ;
                //Camper2.Kmpl = ;
                //Camper2.FuelType = Diesel;
                Camper1.Seat = 2;
                Camper1.Beds = 6;
                //Camper1.Toilet  = true;
                //Camper1.HeatSource = Electricty;
                //Camper1.EnergyClass = ;
                Camper1._licenseType = Vehicle.LicenseType.B;

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
