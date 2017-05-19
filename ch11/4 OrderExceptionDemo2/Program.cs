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
            int num;
            int quantity;
            int dayOrdered;
            //--------------------------------------------------Array-------------------------------------------------
            Order[] arrayList = new Order[5];
            for (int i = 0; i < arrayList.Length; i++)
            {
                try
                {
                    Write("Enter a number(100-999)>> ");
                    num = Convert.ToInt32(ReadLine());
                    Write("Enter the quantity(1-12)>> ");
                    quantity = Convert.ToInt32(ReadLine());
                    Write("Enter day ordered(1-31)>> ");
                    dayOrdered = Convert.ToInt32(ReadLine());

                     arrayList[i] = new Order(num, quantity, dayOrdered);

                   
                }
                catch (ArgumentException x)
                {
                    WriteLine(x.Message);
                    --i;
                }
            }


            for (int i = 0; i < arrayList.Length; i++)
            {
                WriteLine("num {0}", arrayList[i].Number);
                WriteLine("quantity {0}", arrayList[i].Quantity);
                WriteLine("day ordered {0}", arrayList[i].DayOrdered);
            }
        }
    }

    class Order
    {
        //---------------------------------------------------Field-----------------------------------------------------
        private int number;
        private int quantity;
        private int dayOrdered;

        //--------------------------------------------------Property----------------------------------------------------
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public int DayOrdered
        {
            get { return this.dayOrdered; }
            set { this.dayOrdered = value; }
        }

        //---------------------------------------------------Costructor------------------------------------------------
        public Order(int num, int q, int dOrdered)
        {


            if ((num >= 100 && num <= 999) && (q >= 1 && q <= 12) && (dOrdered >= 1 && dOrdered <= 31))
            {
                Number = num;
                Quantity = q;
                DayOrdered = dOrdered;
            }

            else
            {
                num = 0;
                q = 0;
                dOrdered = 0;
                throw new ArgumentException("Error,Try again!");
            }

        }
    }
}
