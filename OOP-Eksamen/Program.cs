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

            Console.ReadKey();
        }
    }
}
