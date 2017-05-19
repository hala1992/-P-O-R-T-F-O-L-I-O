using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace MortgageApplication
{
    class Program: ArgumentException
    {
        static void Main(string[] args)
        {
            Write("Enter your name>> ");
            string appName = ReadLine();

            Write("Enter your credit score>> ");
            int creditScore = Convert.ToInt32(ReadLine());

            // ----------------------------------------------------------call Method 1
            while(creditScore != -666)
            {
                try
                {
                    while (PlayMethod(creditScore) == true)
                    {
                        if (PlayMethod(creditScore) == true && creditScore >= 650)
                        {
                            WriteLine("Accepted");
                        }
                        else if (PlayMethod(creditScore) == true && creditScore < 650)
                        {
                            WriteLine("Rejected");
                        }

                        //---------------------------------------------------------------------------
                        Write("Enter your name>> ");
                        appName = ReadLine();

                        Write("Enter your credit score>> ");
                        creditScore = Convert.ToInt32(ReadLine());
                    }
                }
                catch (ArgumentException x)
                {
                    WriteLine("You entered invalid credit score.");
                }
            WriteLine("Please re-enter your credit score>> ");
            creditScore = Convert.ToInt32(ReadLine());
            }
        }
        //------------------------------------------------------------------Method 1
        private static bool PlayMethod(int cScore)
        {
            bool isItTrue;
            if (!(cScore >= 300 && cScore <= 850))
            {
                throw new ArgumentException();
            }
            else if (cScore >= 300 && cScore <= 850)
            {
                isItTrue=  true;
            }
            else
            {
                isItTrue= false;
            }
            return isItTrue;
        }
    }
   
}
