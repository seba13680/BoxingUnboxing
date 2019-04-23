using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 1000000;
            
            // 1:53 min
            // 2:30 min
            // 2:43 min
            // 1:40 min
            // 1:38 min
            // 1:36 min
            // 2:02 min
            // 2:09 min

            Stack<int> pilaEnteros = new Stack<int>();

            for (int i = 0; i <= cantidad; i++)
            {
            pilaEnteros.Push(i);
            }

            foreach (Object item in pilaEnteros)
            {
                Console.WriteLine(item);
            }


            // 1:44 min
            // 2:02 min
            // 1:35 min
            // 1:43 min
            // 1:49 min

            
            Queue<int> colaEnteros = new Queue<int>();

            for (int i = 0; i <= cantidad; i++)
            {
            colaEnteros.Enqueue(i);
            }
            
            foreach (Object items in colaEnteros)
            {
                Console.WriteLine(items);
            }
            
            

        }
    }
}
