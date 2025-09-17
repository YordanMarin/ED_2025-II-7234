using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila
{
    internal class Pila
    {
        private Nodo cima = null;
        private int contador = 0;

        public void Push(string nom)
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            nuevo.Siguiente = cima;
            cima = nuevo;
            contador++;
        }

        public string Pop()
        {
            if(cima != null)
            {
                string nom = cima.Nombre;
                cima = cima.Siguiente;
                contador--;
                return nom;
            }
            return null;
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = cima;

            while(actual != null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public int Count()
        {
            return contador;
        }

        public void Clear()
        {
            cima = null;
            contador = 0;
        }
    }
}
