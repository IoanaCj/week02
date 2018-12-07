using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalEvenValues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the even elements in array//
            int[] array = new int[] { 2, 5, 1, 8, 10 };
            int[] arrEven = new int[10];

            int count_even = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    arrEven[count_even] = array[i];
                    count_even++;
                }
            }
            Console.Write("The even elements are: ");

            for (int i = 0; i < count_even; i++)
            {
                Console.Write(arrEven[i] + " ");
            }
            //Sum of the even elements from the array//
            int sum = 0;

            for(int i = 0; i < arrEven.Length; i++)
            {
                sum = sum + arrEven[i];
            }
            Console.WriteLine("The sum of even elements is : " + sum);

            Console.ReadLine();
        }
    }
}

