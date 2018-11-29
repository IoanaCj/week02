using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Ex1_8
{
    class Program
    {
            public static int FindIndex(int[] array, int value)
            {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
                return -1;
            }

            public static int FindOccurencies(int[] array, int value)
        {
            int counter = 0;
            foreach (var element in array)
            {
                if(element == value)
                {
                    counter++;
                }
            }
            return counter;
        }



        static void Main(string[] args)
        {
            /*int[] numbers = new int[] { 32, 11, 44, 25, 33 };
            int suma = 0;

            for(int i = 0; i <=numbers.Length - 1; i++)
            {
                suma = suma + numbers[i];
            }

            Console.WriteLine("The sum of the array values is: " + suma);

            Console.ReadLine();*/



            /*int[] numbers = new int[] { 32, 11, 44, 25, 33 };
            int average = 0;
            int suma = 0;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                suma = suma + numbers[i];
                average = suma / 5;
            }

            Console.WriteLine("The average value of the array elements is: " + average);

            Console.ReadLine();*/



            // Varianta care afiseaza cu , //
            /*int[] numbers = new int[] { 32, 11, 44, 25, 33 };
            
            double suma = 0;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                suma = suma + numbers[i];
                
            }

            double media = suma / numbers.Length;
            Console.WriteLine(media);

            Console.ReadLine();*/



            /*int[] numbers = new int[] { 32, 11, 44, 25, 33 };
            int numar = Convert.ToInt32(Console.ReadLine());
            int index = 0;
  
            for(int i = 0; i <= numbers.Length - 1; i++)
            {
                index = numbers[i];

                if(numar == index)
                {
                    Console.WriteLine("The element has index: " + i);
                }

            }
            Console.ReadLine();*/




            /*int[] arr = new[] { 1, 17, 2, 7, 2, 8};
            int value = 2;

            var index = FindIndex(arr, value);

            var occurencies = FindOccurencies(arr, value);

            int[] newArray = new int[arr.Length - occurencies];

            int counter = -1;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if(arr[i] == value)
                {
                    continue;
                }

                counter++;

                newArray[counter] = arr[i];
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i] + " ");
            }
            Console.ReadLine();*/


            // Insert an element to a specified position into array//
            /*int[] arr = new[] { 1, 17, 2, 7, 2, 8 };

            int value = 2;
            int index = 3;

            int[] newArray = new int[arr.Length + 1];

            int counter = 0;

            for (int i = 0; i <= arr.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = value;
                    counter++;
                }
                else
                {
                    newArray[i] = arr[i - counter];

                }
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i] + " ");
            }

                Console.ReadLine();*/

        }
    }
}
