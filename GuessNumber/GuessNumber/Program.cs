using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            var numberToGuess = new Random().Next(1, 10);

            var ok = false;

            while (ok == false)
            {

                var x = Convert.ToInt32(Console.ReadLine());

                if (x == numberToGuess)
                {
                    Console.WriteLine("Felicitari");
                    ok = true;
                }
                else
                {
                    if (x < numberToGuess)
                    {
                        Console.WriteLine("Numarul ales este prea mic");
                    }
                    else
                    {
                        Console.WriteLine("Numarul ales este prea mare");
                    }
                    Console.WriteLine("Mai incearca!");
                }

            }

            Console.ReadLine();
        }
    }
}
