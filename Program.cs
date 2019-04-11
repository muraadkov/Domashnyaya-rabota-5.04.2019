using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile automobile = new Automobile()
            {
                Name = "Nissan"
            };
            Bus bus = new Bus()
            {
                Name = "MAN Lion`s"
            };
            Lorry lorry = new Lorry()
            {
                Name = "Tonar"
            };
            SportCar sportCar = new SportCar()
            {
                Name = "Mitsubishi"
            };
            automobile.StartRide();
            bus.StartRide();
            lorry.StartRide();
            sportCar.StartRide();
            Console.ReadLine();
        }
    }
}
