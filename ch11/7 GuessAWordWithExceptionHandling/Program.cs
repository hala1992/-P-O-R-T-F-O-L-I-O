using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------- Add TRY & CATCH-----------------------------------------
            string[] words = {"apricot", "elephant", "tigress",
                                "fortunate", "impossible", "historical", "colorful", "science"};
            Random RandomClass = new Random();
            int randomNumber;
            randomNumber = RandomClass.Next(0, words.Length);
            string selectedWord = words[randomNumber];
            string guessedWord = "";
            string originalWord = selectedWord;
            string guess;
            char letter;
            int pos;
            char tempChar;
            int foundCount = 0;
            bool letterInWord;
            for (int a = 0; a < selectedWord.Length; ++a)
                guessedWord = guessedWord + "*";
            while (foundCount < selectedWord.Length)
            {
                try {
                    WriteLine("Word: {0}", guessedWord);
                    Write("Guess a letter >> ");

                    //----------------------------------------------------------------------------------------
                    letter = NonLetterException.checkingNonLetterExcaption(out guess);

                    //--------------------------------------------take it off-----------------------------
                    //guess = ReadLine();
                    //letter = Convert.ToChar(guess.Substring(0, 1));
                    letterInWord = false;
                    for (pos = 0; pos < selectedWord.Length; ++pos)
                    {
                        tempChar = Convert.ToChar(selectedWord.Substring(pos, 1));
                        if (tempChar == letter)
                        {
                            guessedWord = guessedWord.Substring(0, pos) + letter + guessedWord.Substring(pos + 1, (guessedWord.Length - 1 - pos));
                            selectedWord = selectedWord.Substring(0, pos) + '?' + selectedWord.Substring(pos + 1, (guessedWord.Length - 1 - pos));
                            ++foundCount;
                            letterInWord = true;
                        }
                    }
                    if (letterInWord)
                        WriteLine("Yes! {0} is in the word", letter);
                    else
                        WriteLine("Sorry. {0} is not in the word", letter);
                }
                catch(NonLetterException x)
                {
                    WriteLine(x.Message);
                }
            }
            WriteLine("Good job! Word was {0}", originalWord);
        }

        //----------------------------------------------------------ADD CLASS------------------------------------------
        class NonLetterException : Exception
        {
            // -----------------------------------------------------CONSTRUCTOR-----------------------------------------
            public NonLetterException(string message):base(message)
            {

            }
            //--------------------------------------------------------METHOD--------------------------------------------
            public static char checkingNonLetterExcaption(out string guess)
            {
                guess = ReadLine();
                char letter = Convert.ToChar(guess.Substring(0, 1));
                letter = char.ToLower(letter);
                if(letter <'a' || letter >'z' || letter==' ')
                {
                    throw new NonLetterException("a non letter char was entered.");
                }
                return letter;
            }
        }
    }
}
