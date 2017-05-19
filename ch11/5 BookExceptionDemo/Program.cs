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
            try
            {
                Write("Enter title>> ");
                t = ReadLine();
                Write("Enter price>> ");
                p = Convert.ToDouble(ReadLine());
                Write("Enter number of pages>> ");
                numP = Convert.ToInt32(ReadLine());


                //-------------------------------------------------Object------------------------------------------------
                BookException x = new BookException(t, p, numP);

                WriteLine("For {0}, ratio is valid Price is {1} for {2} pages.", t, p, numP);
            }
            catch(Exception x)
            {
                WriteLine(x.Message);
            }
        }
    }
    class BookException
    {
       //------------------------------------------------------Field--------------------------------------------------
        private string title;
        private double price;
        private int numOfPage;

        //---------------------------------------------------Properties-----------------------------------------------
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
        public BookException(string t, double p, int numP)
        {
            title = t;
            price = p;
            numOfPage = numP;

            string errorMessage = string.Format("For {0}, ratio is invalid.\n ... Price is {1} for {2} pages.", t,p.ToString("c"),numP);


            if (price / numOfPage > 0.10)
            {
                throw new Exception(errorMessage);
            }
        }

    }
}
