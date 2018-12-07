using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Factorial(number);

            Console.WriteLine(" Factorial of " + " " + number + " " + "is: " + " " + result);

            Console.ReadLine();
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return n = 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
