using System;
using System.Threading.Tasks;
 public class Asynchronous
 {
    // Define SimpleExample first
    public static async Task SimpleExample()
    {
        Console.WriteLine("Starting...");

        await Task.Delay(1000);
        Console.WriteLine("Waited 1 second");

        Task task1 = Task.Run(() => Console.WriteLine("Doing work 1"));
        Task task2 = Task.Run(() => Console.WriteLine("Doing work 2"));

        await Task.WhenAll(task1, task2);

        Console.WriteLine("Both tasks finished");
    } 

    // Then define Main
    public static async Task Main(string[] args)
    {
       Console.WriteLine("Program started");

       await SimpleExample();

       Console.WriteLine("Program ended");
    }
 }
