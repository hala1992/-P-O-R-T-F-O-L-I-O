using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SubscribExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayList = new double[20] { 2.2, 6.4, 8.3, 10.5, 12.6, 14.1, 16.8, 20.3, 22.7, 24.5, 26.5, 28.9, 30.4, 32.3, 34.1, 36.3, 38.2, 40.6, 42.8, 44.5 };

            int userInput = 0;

            try
            {
                while (userInput >= 0 && userInput <= 19)
                {
                    Write("Enter a subscript number>> ");
                    userInput = Convert.ToInt32(ReadLine());
                    WriteLine("Subscript {0} has a value of {1}", userInput, arrayList[userInput]);
                }
            }
            catch(IndexOutOfRangeException x)
            {
                WriteLine("You enter a number out of range.");
            }
        }
    }
    
}
