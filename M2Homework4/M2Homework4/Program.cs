using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find common elements between two arrays of integers//
            /*int[] array1 = new int[] { 2, 31, 6, 8, 10 };
            int[] array2 = new int[] { 4, 5, 13, 9, 6 };
            int counter = 0;

            for(int i = 0; i <= array1.Length - 1; i++)
            {
                for(int j = 0; j <= array2.Length - 1; j++)
                {
                    if(array1[i] == array2[j])
                    {
                        Console.WriteLine("The common element is: " + array1[i]);
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
            Console.ReadLine();*/


            //Determine if a string has all unique characters//
            /*Console.WriteLine("Enter the string: ");
            string unique = Console.ReadLine();
            var arr = unique.ToCharArray();

            for(int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 1; j <= arr.Length - 1; j++)
                {
                    if (arr[i] != arr[j])
                    {
                        Console.WriteLine("The string has unique characters");//imi afiseaza mesajul pt fiecare unique value exista in string??//
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.ReadLine();*/


            //Function check if a number is prime or not//
            /*Console.WriteLine("Enter a number: ");
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
            Console.ReadLine();*/
        }
    }
}
