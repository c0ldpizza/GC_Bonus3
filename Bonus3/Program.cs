using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3
{
    class Program
    {
        //variables
        public static int numberTries = 0;
        public static string response;

        static void Main(string[] args)
        {
            do
            {

                //randomly generate an integer from 1 to 100
                Random rnd = new Random();
                int number = rnd.Next(1, 100);

                do
                {
                    GetTries();

                } while (CheckGuess(GetNumberInRange(1, 100), number));
  
            } while (PlayAgain());

        }

        //compares user's guess to number
        public static bool CheckGuess(int guess, int number)
        {
            if (guess > number)
            {
                if (Math.Abs(guess - number) < 10)
                {
                    Console.WriteLine("Too high!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Way too high!");
                    return true;
                }
            }
            else if (guess < number)
            {
                if (Math.Abs(guess - number) < 10)
                {
                    Console.WriteLine("Too low!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Way too low!");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Great job!");
                Console.WriteLine("It took you {0} tries.", numberTries);
                return false;
            }
        }

        public static void GetTries()
        {
            numberTries++;

            if (numberTries > 1)
            {
                response = "again";
            }
            else
            {
                response = "the number";
            }

            Console.WriteLine("Guess {0}", response);
        }

        public static bool PlayAgain()
        {
            Console.WriteLine("Do you want to play again? (y/n)");

            string input = Console.ReadLine();

            if (input.ToLower() == "n")
                return false;
            else
            {
                return true;
            }
        }

        public static int GetValidInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid input.");
            }

            return input;
        }

        //Validates that integer is within a given range
        public static int GetNumberInRange(int min, int max)
        {
            int input = GetValidInput();
            while (input < min || input > max)
            {
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                input = GetValidInput();
            }
            return input;
        }

    }
}
