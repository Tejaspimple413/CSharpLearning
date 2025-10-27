using System;
using System.Collections.Generic;

public class Book
{
    public int Book_ID { get; set; }
    public string Book_Name { get; set; }
    public string Author_Name { get; set; }
    public bool Is_Borrowed { get; set; } = false;
    public bool Is_Purchased { get; set; } = false;
    public string Book_Type { get; set; }
}

public class BookLibrary
{
    private List<Book> Books = new List<Book>();
    private int nextId = 1;

    public void AddBook(string name, string author, string type)
    {
        Book b = new Book
        {
            Book_ID = nextId++,
            Book_Name = name,
            Author_Name = author,
            Book_Type = type
        };

        Books.Add(b);
        Console.WriteLine("Book Added Successfully");
    }

    public void ViewBook()
    {
        Console.WriteLine("Available Book details are:");
        foreach (var b in Books)
        {
            Console.WriteLine($"ID: {b.Book_ID} | Name: {b.Book_Name} | Type: {b.Book_Type} | Status: {(b.Is_Borrowed ? "Borrowed" : "Available")} | SoldStatus: {(b.Is_Purchased ? "Sold" : "Available")}");
        }
    }

    public void BookIsBorrowed(int id)
    {
        if (id == 0)
        {
            Console.WriteLine("Invalid ID! Please enter ID again.");
            return;
        }

        Book b = Books.Find(book => book.Book_ID == id);

        if (b == null)
        {
            Console.WriteLine("Book not found in the Library.");
        }
        else if (b.Is_Borrowed)
        {
            Console.WriteLine("Book already borrowed.");
        }
        else
        {
            b.Is_Borrowed = true;
            Console.WriteLine("Book borrowed successfully.");
        }
    }

    public void BookIsPurchased(int id)
    {
        if (id == 0)
        {
            Console.WriteLine("Invalid ID! Please enter ID again.");
            return;
        }

        Book b = Books.Find(book => book.Book_ID == id);

        if (b == null)
        {
            Console.WriteLine("Book not found in the Library.");
        }
        else if (b.Is_Purchased)
        {
            Console.WriteLine("Book already purchased.");
        }
        else
        {
            b.Is_Purchased = true;
            Console.WriteLine("Book purchased successfully.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BookLibrary bl = new BookLibrary();
        bool exit = false;
        int Id;

        while (!exit)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Book");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Purchase Book");
            Console.WriteLine("5. Exit");

            Console.Write("Select your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Book Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Author Name: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Book Type: ");
                    string type = Console.ReadLine();
                    bl.AddBook(name, author, type);
                    break;

                case 2:
                    bl.ViewBook();
                    break;

                case 3:
                    Console.Write("Enter Book ID to borrow: ");
                    Id = Convert.ToInt32(Console.ReadLine());
                    bl.BookIsBorrowed(Id);
                    break;

                case 4:
                    Console.Write("Enter Book ID to purchase: ");
                    Id = Convert.ToInt32(Console.ReadLine());
                    bl.BookIsPurchased(Id);
                    break;

                case 5:
                    Console.WriteLine("Exiting the system...");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid input! Try again.");
                    break;
            }
        }
    }
}