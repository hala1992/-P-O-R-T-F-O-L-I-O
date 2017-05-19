using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int milesDriven;
            int gallonsOfGas;
            int mpg;
            try
            {
                Write("Enter miles driven: ");
                milesDriven = Convert.ToInt32(ReadLine());

                Write("Enter gallons of gas: ");
                gallonsOfGas = Convert.ToInt32(ReadLine());

                mpg = milesDriven / gallonsOfGas;
            }
            catch (Exception e)
            {
                mpg = 0;
                WriteLine(e.Message);
            }
                WriteLine("You got {0} miles per gallon", mpg);

            
        }
    }
}
