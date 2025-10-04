using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_binario
{
    internal class Nodo
    {
        public int numero { get; set; }
        public Nodo izquierda { get; set; }
        public Nodo derecha { get; set; }

        public Nodo(int numero)
        {
            this.numero = numero;
            izquierda = null;
            derecha = null;
        }
    }
}
