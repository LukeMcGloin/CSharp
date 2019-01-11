using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
         int answer = 0;
         int column = 8;
         int bit = 0;


            Console.WriteLine("Enter bit value: ");
            bit = Convert.ToInt32(Console.ReadLine());
            answer = answer + (column / bit);
            column = (column / 2);
        }
    }
}
