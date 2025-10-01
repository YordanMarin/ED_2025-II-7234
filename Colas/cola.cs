using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    internal class cola
    {
        Nodo primero = null;
        Nodo ultimo = null;
        int cont = 0;

        public void encolar(string nom)
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            if(primero == null)
            {
                primero = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
            cont++;
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = primero;

            while(actual != null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public string desencolar()
        {
            if(primero != null)
            {
                string nom = primero.Nombre;
                primero = primero.Siguiente;
                cont--;
                return nom;
            }
            return null;
        }

        public int contar()
        {
            return cont;
        }

        public string vistazo()
        {
            if (primero != null)
            {
                return primero.Nombre;
            }
            return null;
        }

        public void limpiar()
        {
            primero = null;
            ultimo = null;
            cont = 0;
        }
    }
}
