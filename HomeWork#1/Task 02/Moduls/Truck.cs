using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02.Moduls
{
    public class Truck : Vehicle
    {
        public bool TrailerIsClean { get; internal set; }

        public override void Drive()
        {
            Console.WriteLine("Driving a Truck...");
        }
    }
}
