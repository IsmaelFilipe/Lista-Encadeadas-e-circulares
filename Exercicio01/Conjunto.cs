using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio01
{
    public class Conjunto
    {
        public LinkedList<int> Conjuntos { get; set; }

        public LinkedList<int> Uniao(LinkedList<int> CjtA, LinkedList<int> CjtB)
        {
            Conjuntos = new LinkedList<int>();
            foreach (var itemA in CjtA)
            {
                Conjuntos.AddLast(itemA);
            }
            foreach (var itemB in CjtB)
            {
                bool aux = true;
                foreach(var cjt in Conjuntos)
                {
                    if (itemB == cjt)
                        aux = false;
                }
                if (aux == true)
                    Conjuntos.AddLast(itemB);
            }
            return Conjuntos;
        }
        public LinkedList<int> Interseccao(LinkedList<int> CjtA, LinkedList<int> CjtB)
        {
            Conjuntos = new LinkedList<int>();
            
            foreach(var itemA in CjtA)
            {
                foreach(var itemB in CjtB)
                {
                    if (itemA == itemB)
                        Conjuntos.AddLast(itemA);
                }
            }
            return Conjuntos;             
        }
        public LinkedList<int> Diferenca(LinkedList<int> CjtA, LinkedList<int> CjtB)
        {
            Conjuntos = new LinkedList<int>();
            bool igual = true;

            foreach(var itemA in CjtA)
            {
                foreach (var itemB in CjtB)
                {
                    if (itemA == itemB)
                    {
                        igual = false;
                    }
                }
                if(igual == true)
                {
                    Conjuntos.AddLast(itemA);
                }
            }
            
            return Conjuntos;
        }
    }
}
