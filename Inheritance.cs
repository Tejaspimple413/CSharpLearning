using System;
public class AK
 {
    // Parent Class Method
     public void Info()
    {
        Console.WriteLine("I am a Girl");
    }
 }
public class Cr : AK
{
    // Child Class Method
    public void Work()
    {
        Console.WriteLine("I work in Capgemini, Pune");
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating object for Abstract class to acces its methods
            Cr c = new Cr();
            c.Info();
            c.Work();
        }
    }
}
