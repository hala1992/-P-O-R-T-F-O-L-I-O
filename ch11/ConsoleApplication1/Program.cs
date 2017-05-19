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
                BookException b1 = new BookException("Love", 10, 100);             
                WriteLine("For {0}, ratio is valid.\n...Price is {1} for {2} pages.", b1.Title, b1.PriceOfBook, b1.NumOfPages);
                BookException b2 = new BookException("meme", 100, 10);
                WriteLine("For {0}, ratio is valid.\n...Price is {1} for {2} pages.", b2.Title, b2.PriceOfBook, b2.NumOfPages);
            }
            catch(Exception x)
            {
                WriteLine(x.Message);
            }
        }
    }
    class BookException
    {
        public string Title { get; set; }
        public double PriceOfBook { get; set; }
        public int NumOfPages { get; set; }

        public BookException(string title, double priceOfBook, int numberOfPages)
        {
            Title = title;
            PriceOfBook = priceOfBook;
            NumOfPages = numberOfPages;

            double pricePerPage = priceOfBook / numberOfPages;
            if (pricePerPage > 0.10)
            {
                string errorMessage = string.Format("For {0}, ratio is invalid.\n...Price is {1} for {2} pages.", title,priceOfBook,numberOfPages);
                throw new Exception(errorMessage);             
            }

        }
    }
}
