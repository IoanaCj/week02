using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //RevStr str = new RevStr();
            //RevStr2 str = new RevStr2();

            //var reversedString = str.Reverse("ab-cd");
            //var reversedStringOnlyLetters = str.ReverseOnlyLetters("a-bC-dEf-ghIj");
            //var reversedStringOnlyLetters = str.ReverseOnlyLetters("Test1ng-Leet=code-Q!");

            //Console.WriteLine("The reversed text is :");
            //Console.WriteLine(reversedString);
            //Console.WriteLine(reversedStringOnlyLetters);


            Calculator op = new Calculator();

            var x = 52;
            var y = 35;

            var sum = op.Sum(x,y);
            var subtract = op.Subtract(x,y);
            var multiply = op.Multiply(x,y);
            decimal divide= op.Divide(x,y);

            Console.WriteLine("The math operations for the two numbers are : ");
            Console.WriteLine(sum);
            Console.WriteLine(subtract);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);

            Console.ReadKey();
        }

    }
}
