using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02
{
    public class Circular
    {

        public int soldado;
        public LinkedList<string> soldados;
        public int x, numero, count,i;

        public void Circ()
        {
            soldados = new LinkedList<string>();
            soldados.AddLast("A");
            soldados.AddLast("B");
            soldados.AddLast("C");
            soldados.AddLast("D");
            soldados.AddLast("E");
            soldados.AddLast("F");
            Random numAleatorio = new Random();
            numero = numAleatorio.Next(1, 11);
            int aux = soldados.Count;
            soldado = numAleatorio.Next(0, aux);

            Console.WriteLine($"Numero sorteado: {numero}");

            foreach (var item in soldados)
            {
                if (x == soldado)
                {
                    Console.WriteLine($"Soldado {item}");
                }
                x++;
            }        
            while (soldados.Count > 1)
            {
                soldados.Remove(remove());
                count = 0;
            }
            foreach(var item in soldados)
                Console.WriteLine($"\nSoldado remanecente: {item}");
            Console.ReadLine();
        }

        public string remove()
        {           
            string aux = "";
            while (count < numero+1)
            {
                foreach (var item in soldados)
                {
                    if (i == soldado)
                    {
                        if (count == numero)
                        {
                            aux = item;
                        }
                        count++;
                      
                    }
                    else
                        i++;
                }
            }
            return aux;
        }
    }
}
