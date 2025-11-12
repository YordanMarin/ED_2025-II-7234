using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoCostos
{
    internal class Grafo
    {
        int[,] matriz;
        int vertices;

        public Grafo(int vertices)
        {
            this.vertices = vertices;
            matriz = new int[vertices, vertices];
        }

        public void imprimirMatriz(RichTextBox rich)
        {
            for(int i = 0; i < vertices; i++)
            {
                for(int j = 0; j < vertices; j++)
                {
                    rich.Text += matriz[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }

        public void insertarArista(int o, int d, int c)
        {
            matriz[o, d] = c;
        }

        public void imprimirArista(ListBox list, int o, int d, int c)
        {
            list.Items.Add($"{o} | {d} | {c}");
        }

        public void Dijsktra(int origen, ListBox list)
        {
            int[] distancias = new int[vertices];
            bool[] visitado = new bool[vertices];

            for(int i = 0; i < vertices; i++)
            {
                distancias[i] = int.MaxValue; //ingresado infinito
                visitado[i] = false;
            }
            distancias[origen] = 0;

            for(int i = 0;i < vertices-1; i++)
            {
                int u = minDistancia(distancias, visitado);
                visitado[u] = true;

                for(int v = 0; v < vertices; v++)
                {
                    if (!visitado[v] && matriz[u,v] != 0 && distancias[u] != int.MaxValue && distancias[u] + matriz[u,v] < distancias[v])
                    {
                        distancias[v] = distancias[u] + matriz[u, v];
                    }
                }

            }
            //MOSTRAR DISTANCIAS
            list.Items.Add("Origen\tDestino\tCosto");
            for(int i = 0;i<vertices ; i++)
            {
                if (distancias[i] == int.MaxValue) 
                    list.Items.Add($"{origen}\t{i}\tNo hay ruta");
                else list.Items.Add($"{origen}\t{i}\t{distancias[i]}");
            }
        }

        public int minDistancia(int[] distancia, bool[] visitado)
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for( int i = 0; i < vertices; i++)
            {
                if(!visitado[i] && distancia[i] <= min)
                {
                    min = distancia[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
    }
}
