using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulul2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array[i] = i + 10;
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();*/


            /*int[] numbers = new int[5] {10,35,44,12,9};
            
            for(int i = numbers.Length - 1; i >= 0; i--)
            {
                if(i == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
                else
                {
                    Console.WriteLine(numbers[i] + ",");
                }
            }
            Console.ReadLine();*/


            /*int[] numbers = new int[5] { 10, 35, 44, 12, 9 };
             int[] aux = new int[numbers.Length];
             int j = 0;
             for(int i = numbers.Length - 1; i>=0; i--)
             {
                 aux[j] = numbers[i];
                 j++;
                 Console.WriteLine(numbers[i]);
             }
             Console.ReadLine();*/

            /*int[] numbers = new int[5] { 10, 35, 44, 12, 9 };
            int[] aux = new int[numbers.Length];

            for (int i = numbers.Length - 1; i >=0; i--)
            {
                int index = numbers.Length - i - 1;
                aux[index] = numbers[i];
                Console.WriteLine(aux[index] + ",");
            }
            Console.ReadLine();*/

            /*int[] numbers = new int[5] { 10, 35, 44, 12, 9 };
            int[] aux = new int[numbers.Length];

            for (int i = numbers.Length - 1; i >=0; i--)
            {
                int index = numbers.Length - i - 1;
                aux[index] = numbers[i];
                WriteNumbers(numbers);

            }
            Console.ReadLine();*/

            /*for( int i = 15; i<=97; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ",");
                }
            }
            Console.ReadLine();*/

            /*for(int i = 20; i <= 65; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();*/

            /*for (int i = 1400; i <= 2300; i++)
            {
                if(i % 7 == 0)
                {
                    if(i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                
                }
            }
            Console.ReadLine();*/


            /*var numberToGuess = new Random().Next(1, 10);
            var ok = false;

            while(ok == false)
            {
                var x = Convert.ToInt32(Console.ReadLine());

                if (x == numberToGuess)
                {
                    Console.WriteLine("Felicitari!");
                }
                else
                {
                    if(x < numberToGuess)
                    {
                        Console.WriteLine("Numarul este mai mare");
                    }
                    else
                    {
                        Console.WriteLine("Numarul este mai mic");
                    }

                    Console.WriteLine("Mai incearca");
                }
            }
            Console.ReadLine();*/

            /*var s = Console.ReadLine();
            var arr = s.ToCharArray();
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.ReadLine();*/


            /*for (var i = 1; i <= 10; i++)
            {
 
                if (i == 4)
                {
                    continue;  
                }
                else
                {
                    if (i == 7)
                    {
                        continue;
                    }
                }
                    Console.WriteLine(i);
            }
            Console.ReadLine();*/

            var a = 1;
            var b = 2;
            int c = a + b;

            do
            {
                Console.WriteLine(c + ",");
                c = a + b;
                a = b;
                b = c;
            }
            while (c < 50);
            Console.ReadLine();

        }
        /*public static void WriteNumbers(int[] aux)
        { 
            for (int i = aux.Length - 1; i<=0; i++)
            {
                if(i == aux.Length)
                {
                    Console.WriteLine(aux[i]);
                }
                else
                {
                    Console.WriteLine(aux[i] + ",");
                }
            }
            
        }*/
    }
}
