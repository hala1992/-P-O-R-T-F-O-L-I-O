using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FindSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number>> ");
            double num;
            string numS = ReadLine();

            if (double.TryParse(numS, out num))
            {
                try
                {
                    if (num >= 0)
                    {
                        num = Math.Sqrt(num);
                    }
                    else
                    {
                        throw new ApplicationException("Number can't be negative.");
                    }
                }
                 
                catch(ApplicationException x)
                {
                    WriteLine(x.Message);
                    num = 0;
                }
               
            }
            else
            {
                WriteLine("The entry can't be converted.");
                num = 0;
            }
            WriteLine("The square root is {0}",num);
        }
    }
   
}
