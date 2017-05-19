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
            Book[] arrayList = new Book[1];
            for (int i = 0; i < arrayList.Length; i++)
            {
                string bookName;
                double price;
                int pageNum;
                string author;

                try
                {

                    Write("Enter book name>> ");
                    bookName = ReadLine();
                    Write("Enter Price of the book>> ");
                    price = Convert.ToDouble(ReadLine());
                    Write("Enter number of pages>> ");
                    pageNum = Convert.ToInt32(ReadLine());
                    Write("Enter Author name>> ");
                    author = ReadLine();



                    arrayList[i] = new Book("Love Story", 10, 100, "Mohamed");
                    WriteLine("For {0},and his book is {1} ratio is valid.\n...Price is {2} for {3} pages.", arrayList[i].Author, arrayList[i].Title, arrayList[i].PriceOfBook.ToString("c"), arrayList[i].NumOfPages);

                }
                catch (FormatException x)
                {
                    WriteLine(x.Message);
                }
                catch (ArgumentException x)
                {
                    WriteLine(x.Message);
                }
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
            //Title = title;
            //PriceOfBook = priceOfBook;
            //NumOfPages = numberOfPages;
            //Author = author;

            //double pricePerPage = priceOfBook / numberOfPages;
            //if (pricePerPage > 0.10)
            //{
            //    string errorMessage = string.Format("For {0}, and his book is {1} ratio is invalid.\n...Price is {2} for {3} pages.", author, title, priceOfBook.ToString("c"), numberOfPages);
            //    throw new Exception(errorMessage);
            //}

            if (priceOfBook / numberOfPages > 0.10)
            {
                this.PriceOfBook = 0.10 / this.NumOfPages;
                string errorMessage = string.Format("For {0}, and his book {1} ratio is invalid.\n ... Price is {2} for {3} pages.", Author, title, priceOfBook.ToString("c"), numberOfPages);

                throw new ArgumentException(errorMessage);
            }
            else
            {
                this.Author = author;
                this.Title = title;
                this.PriceOfBook = priceOfBook;
                this.NumOfPages = numberOfPages;

            }
        }
    }
}
