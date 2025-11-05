using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoRecorridoAdyacencia
{
    internal class Grafo
    {
        private int[,] matrizAdyacencia;
        private int numVertices;

        public Grafo(int numVertices)
        {
            this.numVertices = numVertices;
            matrizAdyacencia = new int[numVertices, numVertices];
        }

        public void insertar(int o, int d)
        {
            matrizAdyacencia[o, d] = 1;
        }

        public void imprimirMatriz(RichTextBox rich)
        {
            for(int i = 0; i < numVertices; i++)
            {
                for(int j = 0; j < numVertices; j++)
                {
                    rich.Text += matrizAdyacencia[i, j]+"\t";
                }
                rich.Text += "\n";
            }
        }

        public void imprimirArista(ListBox list, int o, int d)
        {
            list.Items.Add($"{o} | {d}");
        }

        public void amplitud(TextBox text)
        {
            int nodoInicio = 0;
            bool[] visitado = new bool[numVertices];
            Queue<int> cola = new Queue<int>();

            visitado[nodoInicio] = true;
            cola.Enqueue(nodoInicio);

            while(cola.Count() != 0)
            {
                int nodoActual = cola.Dequeue();
                text.Text += nodoActual + " ";

                for(int i = 0;i < numVertices; i++)
                {
                    if (matrizAdyacencia[nodoActual, i] == 1 && !visitado[i])
                    {
                        visitado[i] = true;
                        cola.Enqueue(i);
                    }
                }
            }
        }

        public void profundidad(TextBox text)
        {
            int nodoInicio = 0;
            bool[] visitado = new bool[numVertices];
            Stack<int> pila = new Stack<int>();

            pila.Push(nodoInicio);

            while (pila.Count() != 0)
            {
                int nodoActual = pila.Pop();

                if (!visitado[nodoActual])
                {
                    visitado[nodoActual] = true;
                    text.Text += nodoActual + " ";

                    for (int i = numVertices-1; i >= 0; i--)
                    {
                        if (matrizAdyacencia[nodoActual, i] == 1 && !visitado[i])
                        {
                            pila.Push(i);
                        }
                    }
                }
                
            }
        }
    }
}
