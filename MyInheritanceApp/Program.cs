using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Dog";   
            dog.Eat();    
            dog.Sleep();  
            dog.Bark();   

            Cat cat = new Cat();
            cat.Name = "Cat";
            cat.Eat();    
            cat.Sleep();  
            cat.Meow();   
        }
    }
}
