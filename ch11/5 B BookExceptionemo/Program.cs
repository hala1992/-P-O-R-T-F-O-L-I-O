using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace BookExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Book b1 = new Book("Hala", "the book", 10, 100);
                WriteLine("For {0}, and his book {1} ratio is valid. \n...Price is {2} for {3} pages.", b1.Author, b1.Title, b1.Price.ToString("c"), b1.NumOfPage);
                Book b2 = new Book("Mila", "the book", 100, 1000);
                WriteLine("For {0}, and his book {1} ratio is valid. \n...Price is {2} for {3} pages.", b2.Author, b2.Title, b2.Price.ToString("c"), b2.NumOfPage);
                Book b3 = new Book("Yazen", "the book", 100, 10);
                WriteLine("For {0}, and his book {1} ratio is valid. \n...Price is {2} for {3} pages.", b3.Author, b3.Title, b3.Price.ToString("c"), b3.NumOfPage);
                
            }

            catch (ArgumentException x)
            {
                WriteLine(x.Message);
            }
            try
            {
                Book b4 = new Book("Mohamed", "the book", 10, 10);
                WriteLine("For {0}, and his book {1} ratio is valid. \n...Price is {2} for {3} pages.", b4.Author, b4.Title, b4.Price.ToString("c"), b4.NumOfPage);
            }
            catch (ArgumentException x)
            {
                WriteLine(x.Message);
            }

        }

    }
        class Book
        {
            //----------------------------------------------------Field--------------------------------------------------
            private string author;
            private string title;
            private double price;
            private int numOfPage;


            //---------------------------------------------------Properties----------------------------------------------
            public string Author
            {
                get { return this.author; }
                set { this.author = value; }
            }
            public string Title
            {
                get { return this.title; }
                set { this.title = value; }
            }
            public double Price
            {
                get { return this.price; }
                set { this.price = value; }
            }
            public int NumOfPage
            {
                get { return this.numOfPage; }
                set { this.numOfPage = value; }
            }

            // --------------------------------------------------Constructor-----------------------------------------------
            public Book(string t,string a, double p, int numP)
            {

                this.Author = a;
                this.Title = t;
                this.Price = p;
                this.NumOfPage = numP;

                string errorMessage = string.Format("For {0}, and his book {1} ratio is invalid.\n ... Price is {2} for {3} pages.",Author, t, p.ToString("c"), numP);


                if (p / numP > 0.10)
                {
                    throw new ArgumentException(errorMessage);
                }

            }
        }
    }

