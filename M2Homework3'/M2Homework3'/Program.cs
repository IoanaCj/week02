using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework3_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            int[] arrEven = new int[10];
            int[] arrOdd = new int[10];

            int count_even = 0;
            int count_odd = 0;

            Console.WriteLine("Input elements in the array: ");
            for(int i = 0; i <n; i++)
            {
                Console.WriteLine("Element " + i + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    arrEven[count_even] = arr[i];
                    count_even++;
                }
                else
                {
                    arrOdd[count_odd] = arr[i];
                    count_odd++;
                }
            }

            Console.Write("The even elements are: ");
            for (int i = 0; i < count_even; i++)
            {
                Console.Write(arrEven[i] + " ");
            }

            Console.Write("The odd elements are: ");  //cum imi pot aparea valorile odd pe o noua linie fata de cele even?//
            for (int i = 0; i < count_odd; i++)
            {
                Console.Write(arrOdd[i] + " ");
            }
            Console.ReadLine();

        }
    }
}
