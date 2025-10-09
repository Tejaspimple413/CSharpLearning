using System;
public abstract class Akansha
 {
   // Creating an abstract method
     public abstract void DailyTasks();
 	}
public class Work : Akansha
{
    public override void DailyTasks()
    {
        Console.WriteLine("Chik Chik" + " " + "and" + " " + "Chik Chik" + " " + "and" + " " + "Chik Chik");
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating object for Abstract class to acces its methods
            Akansha work = new Work();
            work.DailyTasks();
        }
    }
}
