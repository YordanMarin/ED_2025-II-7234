using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABB3
{
    internal class arbol
    {
        public Nodo insertar(Nodo actual, int num)
        {
            Nodo nuevo = new Nodo(num);
            if (actual == null) return nuevo;
            if (num < actual.numero)
                actual.izquierda = insertar(actual.izquierda, num);
            else if (num > actual.numero)
                actual.derecha = insertar(actual.derecha, num);
            else MessageBox.Show("No duplicados");
            return actual;
        }

        public void mostrar(Nodo actual, TreeView t, TreeNode tallo)
        {
            if (actual != null)
            {
                TreeNode r = new TreeNode(actual.numero.ToString());
                if (tallo == null) t.Nodes.Add(r);
                else tallo.Nodes.Add(r);

                mostrar(actual.izquierda, t, r);
                mostrar(actual.derecha, t, r);
            }
        }

        public int sumaNodos(Nodo actual)
        {
            if (actual == null) return 0;

                if(actual.izquierda == null && actual.derecha == null)
                    return actual.numero;

                return sumaNodos(actual.izquierda) + sumaNodos(actual.derecha)+actual.numero;
        }

        public Nodo minimo(Nodo actual)
        {
                while(actual.izquierda != null)
                    actual = actual.izquierda;

                return actual;
        }

        public Nodo maximo(Nodo actual)
        {
            while (actual.derecha != null)
                actual = actual.derecha;

            return actual;
        }

        public int verificarbalance(Nodo actual)
        {
            if(actual == null) return 0;

            int alturaIzq = verificarbalance(actual.izquierda);
            if (alturaIzq == -1) 
                return -1;

            int alturaDer = verificarbalance(actual.derecha);
            if (alturaDer == -1) 
                return -1;

            if (Math.Abs(alturaIzq - alturaDer) > 1)
                return -1;

            return 1 + Math.Max(alturaDer,alturaIzq);
        }

    }
}
