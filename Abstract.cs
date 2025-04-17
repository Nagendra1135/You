using System;

// Abstract Class
abstract class Animal
{
    // ✅ Abstract Method (Must be implemented in derived class)
    public abstract void MakeSound();  

    // ✅ Instance Method (Can be called using an object of derived class)
    public void Sleep()
    {
        Console.WriteLine("The animal is sleeping.");
    }

    // ✅ Static Method (Belongs to the class, can be called without an object)
    public static void AnimalInfo()
    {
        Console.WriteLine("Animals are living beings.");
    }
}

// Derived Class (Must implement abstract methods)
class Dog : Animal
{
    // Implementing the abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Dog Barks: Woof! Woof!");
    }
}

class Program
{
    static void Main()
    {
        // Calling the static method using the class name
        Animal.AnimalInfo(); 

        // Creating an instance of Dog (a derived class)
        Dog myDog = new Dog();

        // Calling instance and abstract methods
        myDog.MakeSound(); // Calling the overridden method
        myDog.Sleep();     // Calling the instance method
    }
}