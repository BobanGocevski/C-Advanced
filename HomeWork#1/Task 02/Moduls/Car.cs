using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02.Moduls
{
    public class Car : Vehicle
    {
        public  object Make { get; internal set; }
        public object Model { get; internal set; }
        public bool IsClean { get; internal set; }

        public override void Drive()
        {
            Console.WriteLine("Driving a car...");
        }
    }
}
