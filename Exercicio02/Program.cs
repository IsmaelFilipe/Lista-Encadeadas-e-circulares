using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> soldados = new LinkedList<string>();
            soldados.AddLast("A");
            soldados.AddLast("B");
            soldados.AddLast("C");
            soldados.AddLast("D");
            soldados.AddLast("E");
            soldados.AddLast("F");

            Random numAleatorio = new Random();
            int numero = numAleatorio.Next(1, 16);
            int aux = soldados.Count;
            int soldado = numAleatorio.Next(0, aux);

            Console.WriteLine($"Numero sorteado: {numero}");
            int x = 0;
            foreach(var item in soldados)
            {
                if(x == soldado)
                {
                    Console.WriteLine($"Soldado {item}");
                }
                x++;
            }
            int count = 0;
            bool pos = true;

            while (soldados.Count > 1)
            {
                x = 0;
                foreach (var item in soldados)
                {
                    if(pos == true)
                    {
                        if (x == soldado)
                        {
                            Console.WriteLine($"Soldado {item}");
                            pos = false;
                        }
                        x++;
                    }
                    else
                    {
                        if(count == numero)
                        {
                            soldados.Remove(item);
                        }
                        count++;
                    }                    
                    
                }
            }
        }
    }
}
