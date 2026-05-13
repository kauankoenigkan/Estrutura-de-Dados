using System;
using System.Collections.Generic;
using System.Text;

namespace PilhaDinamicaESTUDOS
{
   internal class Pilha
   {
        int total;
        Noh topo;

        public Pilha()
        {
            total = 0;
            topo = null;
        }

        public int Total
        {
            get { return total; }
        }

        public void Empilhar(string Valor)
        {
            Noh nn = new Noh();

            nn.Valor = Valor;
            nn.Anterior = topo;

            total++;
            topo = nn;
        }

        public void Desempilhar()
        {
            if (total > 0)
            {
                topo = topo.Anterior;
                total--;
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
            }
        }

        public void Imprimir()
        {
            if (total > 0)
            {
                Noh aux = topo;

                for (int i = 1; i <= total; i++)
                {
                    Console.WriteLine(aux.Valor);
                    aux = aux.Anterior;
                }
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
            }
        }
   }
}