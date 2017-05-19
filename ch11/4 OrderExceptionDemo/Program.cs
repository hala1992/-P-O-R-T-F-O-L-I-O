using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OrderExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Write("Enter a number(100-999)>> ");
                int num = Convert.ToInt32(ReadLine());
                Write("Enter the quantity(1-12)>> ");
                int quantity = Convert.ToInt32(ReadLine());
                Write("Enter day ordered(1-31)>> ");
                int dayOrdered = Convert.ToInt32(ReadLine());

                Order order1 = new Order(num, quantity, dayOrdered);

                WriteLine("The number you entered is {0}", num);
                WriteLine("The quantity is {0}", quantity);
                WriteLine("The ordered number is {0}", dayOrdered);
            }
            catch(ArgumentException x)
            {
                WriteLine(x.Message);
            }
        }
    }

    class Order
    {
        //Field
        private int number;
        private int quantity;
        private int dayOrdered;

        ////Property
        //public int Number
        //{
        //    get { return this.number; }
        //    set { this.number = value; }
        //}
        //public int Quantity
        //{
        //    get { return this.quantity; }
        //    set { this.quantity = value; }
        //}
        //public int DayOrdered
        //{
        //    get { return this.dayOrdered; }
        //    set { this.dayOrdered = value; }
        //}

        //Costructor
        public Order(int num, int q, int dOrdered)
        {


           if ((num >= 100 && num <= 999) && (q >= 1 && q <= 12) && (dOrdered >= 1 && dOrdered <= 31))
            {
                number = num;
                quantity = q;
                dayOrdered = dOrdered;
            }

            else
            {
                throw new ArgumentException("Error,Try again!");
            }

        }
    }
}
