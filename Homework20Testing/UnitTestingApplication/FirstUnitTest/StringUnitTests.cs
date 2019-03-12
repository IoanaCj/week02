using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingApplication;

namespace FirstUnitTest
{
   [TestFixture]//marcheaza clasa ca fiind o clasa ce va contine unit tests
    public class StringUnitTests
    {
        [Test]//marcheaza metoda ca fiind o metoda ce va contine unit tests
        public void HelloWorldTest()
        {
            Console.WriteLine("Hello from first unit test");
        }

        [Test]
        public void ReverseTest()
        {
            //arrange
            var input = "ab-cd";
            var expected = "dc-ba"; // Output1 poarta numele de expected in teste

            RevStr su = new RevStr();

            //act
            var actual = su.Reverse(input); // Output2 poarta numele de actual in teste

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseTestEmptyString()
        {
            //arrange
            var input = "";
            var expected = "dc-ba"; 

            RevStr su = new RevStr();

            //act
            var actual = su.Reverse(input);

            //assert
            Assert.Throws<InvalidOperationException>(() => su.Reverse(input));
        }

        [Test]
        public void ReverseTestOnlyLetters()
        {
            //arrange
            //var input = "a-bC-dEf-ghIj";
            //var expected = "j-Ih-gfE-dCba";

            var input = "Test1ng-Leet=code-Q!";
            var expected = "Qedo1ct-eeLg=ntse-T!";

            RevStr2 su = new RevStr2();

            //act
            var actual = su.ReverseOnlyLetters(input); 

            //assert
            Assert.AreEqual(expected, actual);
        }

        /*[Test]
        public void ReverseTestCases(string s)
        {
            
            var input = s;

            RevStr su = new RevStr();
            
            var actual = su.ReverseOnlyLetters(input);

        }*/

        //Calculator
        [Test]
        public void CalcAddTest()
        {
            //arrange
            var input1 = 52;
            var input2 = 35;
            var expected = 87; 

            Calculator suma = new Calculator();

            //act
            var actual = suma.Sum(input1, input2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalcSubtractTest()
        {
            //arrange
            var input1 = 52;
            var input2 = 35;
            var expected = 17;

            Calculator diferenta = new Calculator();

            //act
            var actual = diferenta.Subtract(input1, input2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalcMultiplyTest()
        {
            //arrange
            var input1 = 52;
            var input2 = 35;
            var expected = 1820;

            Calculator multiplu = new Calculator();

            //act
            var actual = multiplu.Multiply(input1, input2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalcDivideTest()
        {
            //arrange
            var input1 = 52;
            var input2 = 35;
            var expected = 1;

            Calculator impartit = new Calculator();

            //act
            var actual = impartit.Divide(input1, input2);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
