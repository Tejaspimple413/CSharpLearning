using System;
public class Discount
{
    // Method to calculate the final price after a discount
    public static double ApplyDiscount(double price, double discountPercentage)
    {
        return price - discountPercentage;
    }

    public static void Main()
    {
        double finalPrice = ApplyDiscount(1000, 15);
        Console.WriteLine("The final price is: " + finalPrice);
    }
}

