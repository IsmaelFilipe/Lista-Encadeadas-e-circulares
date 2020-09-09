using System;
using System.Collections.Generic;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int cjtA = 0, cjtB = 0;
            LinkedList<int> A = new LinkedList<int>();
            LinkedList<int> B = new LinkedList<int>();
            Console.Write("Informe a quatidade de numero do conjunto A: ");
            cjtA = int.Parse(Console.ReadLine());

            for(int x = 0;x < cjtA; x++)
            {
                Console.Write($"Digite o numero {x + 1}: ");
                int i = int.Parse(Console.ReadLine());
                A.AddLast(i);
            }
            Console.Write("\nInforme a quatidade de numero do conjunto B: ");
            cjtB = int.Parse(Console.ReadLine());

            for (int x = 0; x < cjtB; x++)
            {
                Console.Write($"Digite o numero {x + 1}: ");
                int i = int.Parse(Console.ReadLine());
                B.AddLast(i);
            }
            Conjunto conjunto = new Conjunto();
            Console.WriteLine("\n\tConjunto União");

            foreach(var itemA in conjunto.Uniao(A, B))
            {
                Console.Write($"{itemA} ");
            }

            if (A.Count == 0 || B.Count == 0)
                Console.WriteLine("\n\n\nNao a Intersecção");
            else
            {
                Console.WriteLine("\n\n\n\tConjunto Intersecção");
                foreach (var itemA in conjunto.Interseccao(A, B))
                {
                    Console.Write($"{itemA} ");
                }
            }
            Console.WriteLine("\n\n\n\tConjunto Diferença");
            foreach (var itemA in conjunto.Diferenca(A, B))
            {
                Console.Write($"{itemA} ");
            }
            Console.ReadLine();
        }
    }
}
