using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter a text from console//
            Console.WriteLine("Enter text: ");

            string palindrome = Console.ReadLine();
            char[] arr = palindrome.ToCharArray();

            //Reverse the entered text//
            Array.Reverse(arr);

            //Create New string with the reversed text//
            string reversedArray = new string(arr);

            if(reversedArray == palindrome)
            {
                Console.WriteLine("The word is a palindrome");
            }
            else
            {
                Console.WriteLine("The word is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
