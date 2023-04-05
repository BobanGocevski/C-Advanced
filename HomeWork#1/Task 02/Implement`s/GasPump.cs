using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_02.Interfaces;
using Task_02.Moduls;

namespace Task_02.Implement_s
{
    public class GasPump : IGasPump
    {
        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine($"Pumping gas into {vehicle.GetType().Name}");
            vehicle.IsGasFull = true;
        }
    }
}
