using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lista = InitList();

            LinkedList<int> newLista = ReverseList(lista);

            foreach (var nod in newLista)
            {
                Console.Write(nod + " ");
            }
            Console.ReadLine();
        }

        public static LinkedList<int> InitList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(2);
            lista.AddAfter(lista.First, 4);
            lista.AddLast(6);
            lista.AddLast(8);
            lista.AddLast(10);
            lista.AddLast(12);
            return lista;
        }

        public static LinkedList<int> ReverseList(LinkedList<int> lista)
        {
            LinkedList<int> reversedLista = new LinkedList<int>();

            for (int i = lista.Count - 1; i >= 0; i--)
            {
                reversedLista.AddLast(lista.ElementAt(i));
            }
            lista = reversedLista;
            return lista;
        }
    }
}
