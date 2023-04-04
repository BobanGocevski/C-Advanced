using HomeWork_1.Interfaces;
using HomeWork_1.Moduls;

class Animal
{
    static void Main(string[] args)
    {
        
        IDog dog = new Dog() { Name = "Koko", Age = 3 };
        dog.PrintAnimal();
        dog.Bark(); 
        
        ICat cat = new Cat() { Name = "Jack", Age = 2 };
        cat.PrintAnimal();
        cat.Eat("fish");
    }
}