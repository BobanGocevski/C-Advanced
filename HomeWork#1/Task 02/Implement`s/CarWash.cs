using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_02.Interfaces;
using Task_02.Moduls;

namespace Task_02.Implement_s
{
    public class CarWash : ICarWash
    {
        public void WashCar(Car car)
        {
            Console.WriteLine($"Washing car {car.Make} {car.Model}");
            car.IsClean = true;
        }
        public void WashTrailer(Truck truck)
        {
            Console.WriteLine($"Washing truck");
            truck.TrailerIsClean = true;
        }
    }
}
