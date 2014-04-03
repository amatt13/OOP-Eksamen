using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Just a test of Vehicles classes, should be a seller offering Vehicles
            PersonalCar pCar = new PersonalCar();
            Van van = new Van();
            Autocamper aCam = new Autocamper();
            Bus bus = new Bus();
            Truck truck = new Truck();

            AuctionHouse ah = new AuctionHouse();

            Console.ReadKey();
        }
    }
}
