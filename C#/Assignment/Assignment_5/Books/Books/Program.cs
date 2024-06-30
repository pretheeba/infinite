using System;

public class Books
{
    public string BookName { get; set; }
    public string AuthorName { get; set; }

    public Books(string bookName, string authorName)
    {
        BookName = bookName;
        AuthorName = authorName;
    }

    public void Display()
    {
        Console.WriteLine($"Book: {BookName}, Author: {AuthorName}");
    }
}

public class BookShelf
{
    private Books[] _books = new Books[5];

    public Books this[int index]
    {
        get
        {
            if (index < 0 || index >= _books.Length)
                throw new IndexOutOfRangeException("Index out of range");

            return _books[index];
        }
        set
        {
            if (index < 0 || index >= _books.Length)
                throw new IndexOutOfRangeException("Index out of range");

            _books[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BookShelf shelf = new BookShelf();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Enter details for book {i + 1}:");
            Console.Write("Book Name: ");
            string bookName = Console.ReadLine();
            Console.Write("Author Name: ");
            string authorName = Console.ReadLine();

            shelf[i] = new Books(bookName, authorName);
        }

        Console.WriteLine("\nBooks on the shelf:");
        for (int i = 0; i < 5; i++)
        {
            shelf[i].Display();
        }

        Console.ReadLine();
    }
}
