using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesSortedLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lista = InitList();

            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    var firstEl = lista.ElementAt(i);
                    var secondEl = lista.ElementAt(j);

                    if (firstEl == secondEl)
                    {
                        lista.Remove(firstEl);
                    }
                }
            }

            foreach(var nod in lista)
            {
                Console.Write(nod + " ");
            }
            Console.ReadLine();
        }

        private static LinkedList<int> InitList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(10);
            lista.AddAfter(lista.First, 20);
            lista.AddLast(30);
            lista.AddLast(30);
            lista.AddLast(50);
            lista.AddLast(60);
            return lista;
        }
    }
}
