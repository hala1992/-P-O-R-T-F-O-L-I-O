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
            string t;
            double p;
            int numP;
            Book[] arrayList = new Book[4];
            for (int i = 0; i < arrayList.Length; i++)
            {


                try
                {
                    Write("Enter author name>> ");
                    string a = ReadLine();
                    Write("Enter title>> ");
                    t = ReadLine();
                    Write("Enter price>> ");
                    p = Convert.ToDouble(ReadLine());
                    Write("Enter number of pages>> ");
                    numP = Convert.ToInt32(ReadLine());


                    //-------------------------------------------------Object------------------------------------------------
                    arrayList[i] = new Book(t, a, p, numP);

                    WriteLine("For {0}, and his book {1} ratio is valid Price is {2} for {3} pages.", arrayList[i].Author, arrayList[i].Title, arrayList[i].Price, arrayList[i].NumOfPage);
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
        public Book(string t, string a, double p, int numP)
        {

          

            if (p / numP > 0.10)
            {
                this.price = 0.10 / this.numOfPage;
                string errorMessage = string.Format("For {0}, and his book {1} ratio is invalid.\n ... Price is {2} for {3} pages.", Author, t, p.ToString("c"), numP);

                throw new ArgumentException(errorMessage);
            }
            else
            {
                this.Author = a;
                this.Title = t;
                this.Price = p;
                this.NumOfPage = numP;

            }

        }
    }
}
