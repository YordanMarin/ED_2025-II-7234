using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_binario
{
    internal class arbol
    {
        public Nodo insertar(Nodo actual, int num)
        {
            Nodo nuevo = new Nodo(num);

            if (actual == null) //insertar raiz
            {
                return nuevo;
            } //insertar ramas
            else if ((actual.izquierda != null || actual.derecha == null) && (actual.derecha != null || actual.izquierda == null))
                MessageBox.Show("Nodo ocupado!");
            else if (actual.izquierda == null)
                actual.izquierda = nuevo;
            else actual.derecha = nuevo;

            return actual;
        }

        public void mostrar(Nodo actual, TreeView tree, TreeNode cabe)
        {
            TreeNode ra = new TreeNode(actual.numero.ToString());
            ra.Tag = actual; //almacena la referencia al nodo

            if(cabe == null) tree.Nodes.Add(ra);
            else cabe.Nodes.Add(ra);

            if(actual.izquierda != null) mostrar(actual.izquierda, tree, ra);
            if(actual.derecha != null) mostrar(actual.derecha, tree, ra);
        }

        public int altura(Nodo actual)
        {
            if(actual != null)
            {
                int altIzq = altura(actual.izquierda);
                int altDer = altura(actual.derecha);

                return Math.Max(altIzq, altDer)+1;
            }
            return 0;
        }
    }
}
