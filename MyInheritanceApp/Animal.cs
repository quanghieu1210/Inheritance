using System;

namespace InheritanceExample
{
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing.");
        }
    }
}
