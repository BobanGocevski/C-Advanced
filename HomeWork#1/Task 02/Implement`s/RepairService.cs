using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_02.Interfaces;
using Task_02.Moduls;

namespace Task_02.Implement_s
{
    public class RepairService :IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Checking {vehicle.GetType().Name} for issues");
            vehicle.IsBroken = false;
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Fiing {vehicle.GetType().Name}");
            vehicle.IsBroken = false;
        }
    }
}
