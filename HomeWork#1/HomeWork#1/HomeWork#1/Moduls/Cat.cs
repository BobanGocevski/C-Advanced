using HomeWork_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1.Moduls
{
    public class Cat : Animal, ICat
    {
        public void PrintAnimal()
        {
            Console.WriteLine($"Name {Name}, Age: {Age}, Type: Cat");
        }
        public void Eat (string food)
        {
            Console.WriteLine($"The cat {Name} is eating {food}");
        }
    }
}
