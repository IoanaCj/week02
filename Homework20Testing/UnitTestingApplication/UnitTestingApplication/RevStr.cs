using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingApplication
{
    public class RevStr
    {
        public string Reverse(string text)
        {
            if (text == "" || text == null)
            {
                throw new InvalidOperationException();
            }

            /*var reversedArray = text.Reverse().ToArray();
            return new string(reversedArray);*/

            char[] array = text.ToCharArray();
            string reverse = String.Empty;

            for (int i = array.Length - 1; i > -1; i--)
            {                      
                reverse += array[i];
            }
            return reverse;
        }
    }
}
