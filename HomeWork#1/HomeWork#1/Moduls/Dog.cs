using HomeWork_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1.Moduls
{
    public class Dog : Animal , IDog
    {
        public  void PrintAnimal()
        {
            Console.WriteLine($"Name {Name}, Age: {Age}, Type: Dog");
        }
        public void Bark()
        {
            Console.WriteLine("drsh gi sharo utekoa");
        }
    }
}
