using System;
	public static class calculator
	{
    		public static double calculate(double a, double b, string opr)
    		{
        		if (a != 0 && b != 0)
        		{
            			switch (opr.ToLower())
            			{
                			case "addition":
                    				return a + b;
                			case "subtraction":
                    				return a - b;
                			case "multiplication":
                    				return a * b;
                			case "division":
                    				return a / b;
                			case "modulus":
                    				return a % b;
                			default:
                    				Console.WriteLine("Invalid Operation!!! Cannot perform");
                    				return double.NaN;
            			}
        		}
        		else
        		{
            			Console.WriteLine("Invalid data entered. Inputs must be non-zero.");
            			return double.NaN;
        		}
    		}
	}
	public class RunCalculator
	{
    		public static void Main(string[] args)
    		{
        		// Please enter two numbers
        		Console.WriteLine("Enter the first number: ");
        		double a = Convert.ToDouble(Console.ReadLine());
        
        		Console.WriteLine("Enter the second number: ");
        		double b = Convert.ToDouble(Console.ReadLine());
        
        		// Enter the operation you wish to perform
        		Console.WriteLine("Enter the Operation you wish to perform: ");
        		string opr = Console.ReadLine();
        
        		// Using the calculate method from calculator class to perform the operation
        		double result = calculator.calculate(a, b, opr);
        
        		// Finally printing the result
        		Console.WriteLine(result);
    		}
	}
