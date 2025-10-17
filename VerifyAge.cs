using System;
using System.Collections.Generic;

public class Person{
    public void VerifyAge(int age) {
        // Check if the Age of a person is valid
        if (age<=0){
            Console.WriteLine("Age cannot be negative or 0!!");
        } else if (age > 100){
            Console.WriteLine("Your Age is Invalid!!!");;
        } else{
            Console.WriteLine("Your Age is valid");
        }
    }
}

public class AgeVerification {
    public static void Main(string [] args){
        // Variable for storing age
        int age;
        
        // Ask the user to enter his age
        Console.WriteLine("Please enter your age (In Years):");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");
        
        // Creating an object of the Person class to access its methods
        Person p = new Person();
        p.VerifyAge(age);
    }
}