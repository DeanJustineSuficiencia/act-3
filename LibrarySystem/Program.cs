
using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize variables
        string bookTitle = "To Kill a Mockingbird";
        string author = "Harper Lee";
        int yearOfPublication = 1960;
        int numberOfPages = 281;
        bool isAvailableForLoan = true;

        // Display book details
        Console.WriteLine("Library Book Information");
        Console.WriteLine("------------------------");
        Console.WriteLine($"Title: {bookTitle}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Year of Publication: {yearOfPublication}");
        Console.WriteLine($"Number of Pages: {numberOfPages}");
        Console.WriteLine($"Available for Loan: {(isAvailableForLoan ? "Yes" : "No")}");
    }
}
