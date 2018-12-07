using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfArrayContainsDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Init an array//
            int[] duplicates = new int[] { 51, 5, 33, 4, 2, 55 };
            int[] faraDuplicate = new int[] { 1, 2, 3, 5, 3, 7 };

            if (AreDuplicates(duplicates))
            {
                Console.WriteLine("Am duplicate in primul sir!");
            }
            else
            {
                Console.WriteLine("Nu am duplicate in primul sir!");
            }


            if (AreDuplicates(faraDuplicate))
            {
                Console.WriteLine("Am duplicate in sirul doi!");
            }
            else
            {
                Console.WriteLine("Nu am duplicate in sirul doi!");
            }
            Console.ReadKey();
        }

        private static bool AreDuplicates(int[] vector)
        {
            for (int i = 0; i <= vector.Length - 1; i++)
            {
                for (int j = i + 1; j <= vector.Length - 1; j++)
                {
                    if (vector[i] == vector[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
