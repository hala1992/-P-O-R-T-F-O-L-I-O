using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Book b1 = new Book("Love Story", 10, 100, "Mohamed");
                WriteLine("For {0},and his book is {1} ratio is valid.\n...Price is {2} for {3} pages.",b1.Author, b1.Title, b1.PriceOfBook.ToString("c"), b1.NumOfPages);
                Book b2 = new Book("Lovely Dog", 100, 10, "Omar");
                WriteLine("For {0},and his book is {1} ratio is valid.\n...Price is {2} for {3} pages.",b2.Author, b2.Title, b2.PriceOfBook.ToString("c"), b2.NumOfPages);
            }
            catch (Exception x)
            {
                WriteLine(x.Message);
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public double PriceOfBook { get; set; }
        public int NumOfPages { get; set; }
        public string Author { get; set; }

        public Book(string title, double priceOfBook, int numberOfPages, string author)
        {
            Title = title;
            PriceOfBook = priceOfBook;
            NumOfPages = numberOfPages;
            Author = author;

            double pricePerPage = priceOfBook / numberOfPages;
            if (pricePerPage > 0.10)
            {
                string errorMessage = string.Format("For {0}, and his book is {1} ratio is invalid.\n...Price is {2} for {3} pages.",author, title, priceOfBook.ToString("c"), numberOfPages);
                throw new Exception(errorMessage);
            }

        }
    }
}
