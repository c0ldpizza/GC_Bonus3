using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3
{
    class Program
    {
        public static int number = 50;

        static void Main(string[] args)
        {
            //randomly generate an integer from 1 to 100

            int numberTries = 1;
            string response;
            
            do
            {
                if (numberTries > 1)
                {
                    response = "again";
                }
                else
                {
                    response = "the number";
                }

                numberTries++;

                Console.WriteLine("Guess {0}", response);


            } while (CheckGuess(GetNumberInRange(1, 100)));
            

        }

        public static bool CheckGuess(int guess)
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
                return false;
            }
        }

        public static void HowClose(int guess)
        {
            if (Math.Abs(guess - number) < 10)
            {

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
