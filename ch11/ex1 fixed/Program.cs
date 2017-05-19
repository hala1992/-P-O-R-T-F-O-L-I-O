using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int zero = 0;

            try
            {
                Write("Enter an intger: ");
                x = Convert.ToInt32(ReadLine());
                y = x / zero;
            }
            catch(DivideByZeroException e)
            {
                WriteLine(e.Message);
                x = 0;
            }
            catch(FormatException e)
            {
                WriteLine(e.Message);
                x = 0;
            }
            WriteLine("The answer is {0}", x);
        }


    }
}
