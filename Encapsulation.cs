using System;

public class BankAccount
{
    // Cannot be directly accessed from outside class\\
    private double balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            // Update the balance
            balance += amount;
        }

    }

    public double GetBalance()
    {
        return balance;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Asking user to enter amount he want to deposit in bank
            Console.WriteLine("Please enter the amount you want to deposit: \n");
            double amt = Convert.ToDouble(Console.ReadLine());

            // Using the BankAccount class to display balance to user
            BankAccount account = new BankAccount();
            account.Deposit(amt);

            double balance = account.GetBalance();

            // Printing the balance to the user
            Console.WriteLine("You have currently: " + " " + balance + "Rs." + " " + "left in your account");

            Console.WriteLine("ThankYou!!");
        }
    }
}
