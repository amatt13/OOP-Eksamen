using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions; //REGEX

namespace OOP_Eksamen
{
    class Program
    {
        public static bool getMatches(string strInput)
        {
            Regex regex = new Regex(@"([a-zA-Z]{2}\d{5})$"); // <- Det er regex og betyder [a-zA-Z]{2} <- 2 tegn der skal være mellem a-z og kan både være stor og lille bogstav, efterfulgt af 5 tal
            return (regex.Matches(strInput).Count != 0); // <- hvis der er 0 resultater er den false
        }

        static void Main(string[] args)
        {
            AuctionsHouse AuctionsHouse = new AuctionsHouse();

            PersonVehiclePrivate PrivatCar = new PersonVehiclePrivate();
            PersonVehicleWork WorkCar = new PersonVehicleWork();
            Truck Truck = new Truck();
            Bus Bus = new Bus();
            Camper Camper = new Camper();

            Buyer Buyer1 = new Buyer(15000);
            Buyer Buyer2 = new Buyer(30000);
            Salesman Salesman1 = new Salesman(false);
            Salesman Salesman2 = new Salesman(true);

            Salesman1.ReceiveBidNotification();
            Salesman2.ReceiveBidNotification();

            CalculateFees CalculateFees = new CalculateFees();

            Console.WriteLine("{0}", CalculateFees.Fees(599870));

            var Plate = "AB12345";
            var PlateCheck = getMatches(Plate);

            Console.WriteLine("Does it match?: {0}", PlateCheck.ToString());



            Console.ReadKey();
        }
    }
}
