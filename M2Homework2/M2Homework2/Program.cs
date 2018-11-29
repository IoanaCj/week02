using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] frequency = new int[9] { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i= 0;i <= frequency.Length - 1; i++)
            {
                int count = 0;

                for (int j = 0; j <= frequency.Length - 1; j++)
                {
                    if (frequency[i] == frequency[j])
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine(frequency[i] + " - " + count + " times");
            }
            Console.ReadLine();

        }
    }
}
