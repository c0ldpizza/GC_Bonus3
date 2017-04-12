using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3
{
    class Program
    {
        public static int number;

        static void Main(string[] args)
        {

        }

        public static void CheckGuess(int guess)
        {
            if (guess > number)
            {
                if (Math.Abs(guess - number) < 10)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Way too high!");
                }
            }
            else if (guess < number)
            {
                if (Math.Abs(guess - number) < 10)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Way too low!");
                }
            }
            else
            {
                //Success!!
            }
        }

        public static void HowClose(int guess)
        {
            if (Math.Abs(guess - number) < 10)
            {

            }
        }
    }
}
