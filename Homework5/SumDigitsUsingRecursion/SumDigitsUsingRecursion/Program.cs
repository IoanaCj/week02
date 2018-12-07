using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsUsingRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 234;
            int result = SumDigits(number);

            Console.WriteLine(" Sum of digits in" + " " + number + " " + "is: " + " " + result);

            Console.ReadLine();
        }

        public static int SumDigits(int n)
        {
            if( n == 0)
            {
                return 0;
            }
            else
            {
                return (n % 10 + SumDigits(n / 10));
            }
        }
    }
}
