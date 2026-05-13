using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PilhaDinamicaESTUDOS
{
    internal class Noh
    {
        string valor;
        Noh anterior;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Noh Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }
}