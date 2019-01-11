using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbertoguess = 0;
            int numberofguesses = 0;
            int guess = 0;
            Console.WriteLine("Player one enter your chosen number: ");
            numbertoguess = Convert.ToInt32(Console.ReadLine());

            while (numbertoguess < 1 || numbertoguess > 10) ;
            {
                Console.WriteLine("Not a valid choice, please enter another guess");
                numbertoguess = Convert.ToInt32(Console.ReadLine());
            }

            guess = 0;
            numberofguesses = 0;

            while (guess != numberofguesses && numberofguesses < 5) do;
                {
                    Console.WriteLine("Player two have a guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    numberofguesses = numberofguesses + 1;
                }

            if (guess = numberofguesses)
            {

            }
        }
    }
}
