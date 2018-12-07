using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfNumberIsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                    break;
                }
            }

            if ((counter == 0) && (number != 1))
            {
                Console.WriteLine(number + " " + " is a prime number");
            }
            else
            {
                Console.WriteLine(number + " " + "is not a prime number");
            }
            Console.ReadLine();
        }
    }
}
