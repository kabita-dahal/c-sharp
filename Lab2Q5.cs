using System;

namespace KabitaLabwork
{
    class Animal
    {
        // Virtual method in the base class
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Dog : Animal
    {
        // Overriding the virtual method in the derived class
        public override void Speak()
        {
            Console.WriteLine("The dog barks");
        }
    }

    class Cat : Animal
    {
        // Overriding the virtual method in the derived class
        public override void Speak()
        {
            Console.WriteLine("The cat meows");
        }
    }

    internal class Lab2Q5
    {
        /*static void Main()
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.Speak(); // Output: The animal makes a sound
            myDog.Speak();    // Output: The dog barks
            myCat.Speak();    // Output: The cat meows
        }*/
    }
}
