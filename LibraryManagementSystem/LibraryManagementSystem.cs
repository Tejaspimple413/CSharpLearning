using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsBorrowed { get; set; } = false;
}

class Library
{
    private List<Book> books = new List<Book>();
    private int nextId = 1;

    public void AddBook(string title, string author)
    {
        books.Add(new Book { Id = nextId++, Title = title, Author = author });
        Console.WriteLine("Book added successfully.");
    }

    public void ViewBooks()
    {
        Console.WriteLine("\nAvailable Books:");
        foreach (var book in books)
        {
            Console.WriteLine($"ID: {book.Id} | Title: {book.Title} | Author: {book.Author} | Status: {(book.IsBorrowed ? "Borrowed" : "Available")}");
        }
    }

    public void BorrowBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            Console.WriteLine("Book not found.");
        }
        else if (book.IsBorrowed)
        {
            Console.WriteLine("Book is already borrowed.");
        }
        else
        {
            book.IsBorrowed = true;
            Console.WriteLine("Book borrowed successfully.");
        }
    }

    public void ReturnBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            Console.WriteLine("Book not found.");
        }
        else if (!book.IsBorrowed)
        {
            Console.WriteLine("Book was not borrowed.");
        }
        else
        {
            book.IsBorrowed = false;
            Console.WriteLine("Book returned successfully.");
        }
    }

    public void SearchBook(string keyword)
    {
        var results = books.Where(b => b.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) || b.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
        if (results.Count == 0)
        {
            Console.WriteLine("No books found.");
        }
        else
        {
            Console.WriteLine("\nSearch Results:");
            foreach (var book in results)
            {
                Console.WriteLine($"ID: {book.Id} | Title: {book.Title} | Author: {book.Author} | Status: {(book.IsBorrowed ? "Borrowed" : "Available")}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Search Book");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author name: ");
                    string author = Console.ReadLine();
                    library.AddBook(title, author);
                    break;
                case "2":
                    library.ViewBooks();
                    break;
                case "3":
                    Console.Write("Enter book ID to borrow: ");
                    int borrowId = int.Parse(Console.ReadLine());
                    library.BorrowBook(borrowId);
                    break;
                case "4":
                    Console.Write("Enter book ID to return: ");
                    int returnId = int.Parse(Console.ReadLine());
                    library.ReturnBook(returnId);
                    break;
                case "5":
                    Console.Write("Enter keyword to search: ");
                    string keyword = Console.ReadLine();
                    library.SearchBook(keyword);
                    break;
                case "6":
                    exit = true;
                    Console.WriteLine("Exiting system...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}