using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingApplication
{
    public class RevStr2
    {
        public string ReverseOnlyLetters(string text)
        {
            if (text == "" || text == null)
            {
                throw new InvalidOperationException();
            }

            char[] array = text.ToArray();

                int i = array.Length - 1;
                int j = 0;

                while (j < i)
                {
                    if (!char.IsLetter(array[j]))
                    {
                        j++;
                    }
                    else
                    {
                        if (!char.IsLetter(array[i]))
                        {
                            i--;
                        }
                        else
                        {
                            char swap = array[j];
                            array[j] = array[i];
                            array[i] = swap;
                            j++;
                            i--;
                        }
                    }
                }
                return new String(array);
        }
    }
}
