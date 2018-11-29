using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];
            for(int i= 0; i < 10; i++)
            {
                array[i] = i + 10;
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();

            /*for(int i = 16; i <=97; i += 2)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 20; i <= 65; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 1400; i <= 2300; i++)
            {
                if ((i % 7 == 0) && (i % 5 ==0))
                {
                    Console.WriteLine(i);
                }*/


        }






        /*public static void Swap(int[] arr, int i, int j)
        {
            var x = arr[i];
            arr[i] = arr[j];
            arr[j] = x;
        }


        public static void WriteNumbers(int[] aux)
        {
            for(int i = 0; i <= aux.Length - 1; i++)
            {
                if (i == aux.Length - 1)
                {
                    Console.Write(aux[i]);
                }
                else
                {
                    Console.Write(aux[i] + ",");
                }
            }
        }*/
    }
}
