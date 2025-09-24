using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aso2_T1
{
    internal class Pila
    {
        Nodo cima = null;

        public bool apilar(double s)
        {
            Nodo nuevo = new Nodo();
            nuevo.Sueldo = s;

            if(buscar(s) == false)
            {
                nuevo.Siguiente = cima;
                cima = nuevo;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = cima;
            while (actual != null)
            {
                list.Items.Add(actual.Sueldo);
                actual = actual.Siguiente;
            }
        }

        public bool buscar(double s)
        {
            Nodo actual = cima;
            while (actual != null)
            {
                if(actual.Sueldo == s)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }
    }
}
