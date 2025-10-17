using System;
using System.Collections.Generic;

public class Amount
{
    public double CalculateDiscount(double amount, double percentage)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid Input. Cannot calculate discount on 0 or a negative amount!!");
            return -1;
        }
        else if (percentage >= 100)
        {
            Console.WriteLine("Invalid Input. Discount cannot be 100% or greater...");
            return -1;
        }
        else
        {
            Console.WriteLine("Calculating discount....");

            double discount = amount * (percentage / 100);
            double discounted_Amount = amount - discount;

            Console.WriteLine("Discount calculated successfully.");
            Console.WriteLine("Discounted amount calculated successfully.\n");

            return discounted_Amount;
        }
    }

    public double CalculateBonus(double amount, double percentage)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid Input. Cannot calculate bonus on 0 or a negative amount!!");
            return -1;
        }
        else if (percentage >= 100)
        {
            Console.WriteLine("Invalid Input. Bonus cannot be 100% or greater...");
            return -1;
        }
        else
        {
            Console.WriteLine("Calculating bonus....");

            double bonus = amount * (percentage / 100);
            double bonus_Amount = amount + bonus;

            Console.WriteLine("Bonus calculated successfully.");
            Console.WriteLine("Bonus amount calculated successfully.\n");

            return bonus_Amount;
        }
    }
}

public class Calculation
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the amount on which you wish to calculate (Discount/Bonus): ");
        double amt = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n");

        Console.WriteLine("Please enter the (Discount/Bonus) percent you wish to calculate on the amount: ");
        double percent = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n");

        Console.WriteLine("Please specify which value you want to calculate on the Amount (discount/bonus): ");
        string opr = Console.ReadLine();
        
        Console.WriteLine("\n");

        // Creating an object of the Amount class to access its methods
        Amount a = new Amount();

        // Using switch case to calculate both (Discount/Bonus) as per user
        switch (opr.ToLower())
        {
            case "discount":
                double discountResult = a.CalculateDiscount(amt, percent);
                Console.WriteLine("The final Discounted amount is: " + discountResult + " respectively.");
                break;

            case "bonus":
                double bonusResult = a.CalculateBonus(amt, percent);
                Console.WriteLine("The final Bonus amount is: " + bonusResult + " respectively.");
                break;

            default:
                Console.WriteLine("Invalid operation specified!!");
                break;
        }
    }
}