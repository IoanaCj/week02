using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisibleby7and3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] divisibleNumbers = new[] { 3, 7, 12, 8, 10, 21, 4, 15, 28, 42 };

            int[] arrdivisible = new int[10];

            int count_divisible = 0;

            Console.WriteLine("All numbers that are divisible by 7 and 3: ");

            for (int i = 0; i < divisibleNumbers.Length; i++)
            {
                if (divisibleNumbers[i] % 7 == 0)
                {
                    if(divisibleNumbers[i] % 3 == 0)
                    {
                        arrdivisible[count_divisible] = divisibleNumbers[i];
                        count_divisible++;
                    }
                }
            }
            Console.Write("The Divisible numbers by 7 and 3 are: ");

            for (int i = 0; i < count_divisible; i++)
            {
                Console.Write(arrdivisible[i] + " ");
            }

            //LINQ
            Console.WriteLine("All numbers that are divisible by 7 and 3: ");

            var queryDivisible =
                from divNum in divisibleNumbers
                where (divNum % 7 == 0 && divNum % 3 == 0)
                select divNum;

            foreach(var num in queryDivisible)
            {
                Console.WriteLine(num + " ");
            }

            //Lambda expressions
            Console.WriteLine("All numbers that are divisible by 7 and 3: ");

            var divisibleLambda =
                     Array.FindAll(divisibleNumbers, d => d % 7 == 0 && d % 3 == 0);

            foreach (var num in divisibleLambda)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
