using System;
public interface IAnimal
 {
    void Speak(); // Interface method
 }

 // Class Dog implementing Interface IAnimal
public class Dog : IAnimal
 {
    public void Speak()
    {
        Console.WriteLine("Dog says: Woof!!");
    }
 }

 // Class Cat implementing Interface IAnimal
 public class Cat : IAnimal
 {
    public void Speak()
    {
        Console.WriteLine("Cat says: Meow!!");
    }
 }

 // Factory class for creating IAnimal objects
 public class AnimalFactory
 {
    public static IAnimal CallAnimal(string type)
    {
        if (type.ToLower() == "dog")
        {
            return new Dog();
        }
        else if (type.ToLower() == "cat")
        {
            return new Cat();
        }
        else
        {
            throw new ArgumentException("Unknown animal type");
        }
    }
 }
public class Factory
 {
    public static void Main(string[] args)
    {
        IAnimal animal = AnimalFactory.CallAnimal("cat");
        animal.Speak(); // Correct method name is Speak, not speak
    }
 }
