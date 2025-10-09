using System;
public class Printer
 {
    // Variable for holding the object of the Printer class
     private static Printer instance;

    // Private constructor: no one can create object from outside
    private Printer() { }

    // Public method to get the single instance
    public static Printer GetInstance()
    {
        if (instance == null)
        {
            instance = new Printer(); // create object only once
 			Console.WriteLine("Object Created First Time Successfully!!");
        }
      return instance;
    }
public void Print(string text)
   {
       Console.WriteLine("Printing: " + text);
    }
 }
public class Singleton
 {
    static void Main()
    {
        Printer p1 = Printer.GetInstance();
        Printer p2 = Printer.GetInstance();

        p1.Print("Hello");
        p2.Print("World");

        Console.WriteLine(p1 == p2);  // Output: True (same object)
    }
 }
