using System;
public class Person
{
    // Name of the Person
    string person_Name;

    // Age of the Person
    int person_Age;

    // Creating a Constructor of the Class
    public Person(string Name, int Age) {
        person_Name = Name;
        person_Age = Age;
    }

    // Creating a Greet Method
    public void Greet() {
        Console.WriteLine("Hello!!! My Name is :" + " " + person_Name + " " + "respectively" + "\n");
        Console.WriteLine("Hello!!! My Age is :" + " " + person_Age + " " + "respectively");
    }
}
public class Greet
{
    public static void Main(string[] args)
    {
        // Creating an Object of the Person Class to access its methods
        Person p = new Person("Tejas", 27);
        p.Greet();

        Console.WriteLine("\n");

        Person pe = new Person("Pimple", 27);
        pe.Greet();
    }
}
