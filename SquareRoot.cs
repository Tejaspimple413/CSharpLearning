using System;
using System.Collections.Generic;

public class SquareRoot
{
    public double CalculateRoot(double num)
    {
        // Check if the number is not negative
        if (num <= 0)
        {
            Console.WriteLine("Invalid Input. Cannot calculate square root of 0 or a negative number!!");
            return -1; // Return error value
        }
        else
        {
            Console.WriteLine("Starting calculation....");

            // Calculating the square root using Math.Sqrt
            double sqr_Root = Math.Sqrt(num);

            Console.WriteLine("Calculation finished successfully.\n");

            // Returning the square root
            return sqr_Root;
        }
    }
}

public class SquareRootCalculation
{
    public static void Main(string[] args)
    {
        // Ask the user to enter a number
        Console.WriteLine("Please enter a number whose square root you wish to calculate: ");
        double num = Convert.ToDouble(Console.ReadLine());

        // Creating an object of the SquareRoot class to access its methods
        SquareRoot r = new SquareRoot();
        double result = r.CalculateRoot(num);

        // Finally printing the result
        if (result != -1)
        {
            Console.WriteLine("The square root of the number is: " + result);
        }
    }
}