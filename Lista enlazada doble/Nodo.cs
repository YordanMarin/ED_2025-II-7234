using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_enlazada_doble
{
    internal class Nodo
    {
        private int numero;
        private Nodo siguiente;
        private Nodo atras;

        public int Numero { get => numero; set => numero = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
        internal Nodo Atras { get => atras; set => atras = value; }
    }
}
