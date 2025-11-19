using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoFloyd
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
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
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

        public void floyd(RichTextBox rich)
        {
            int[,] matrizFloy = new int[vertices, vertices];

            for(int i = 0; i < vertices; i++)
            {
                for(int j = 0;j < vertices; j++)
                {
                    if(matriz[i, j] != 0)
                        matrizFloy[i, j] = matriz[i, j];
                    else
                        matrizFloy[i,j] = int.MaxValue;
                }
            }

            //aplicar floy

            for(int i =0; i<vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    for(int k = 0; k < vertices; k++)
                    {
                        if (matrizFloy[j,i] != int.MaxValue && matrizFloy[i,k] != int.MaxValue)
                        {
                            int nuevoCosto = matrizFloy[j,i]+ matrizFloy[i, k];
                            if (nuevoCosto < matrizFloy[j,k])
                            {
                                matrizFloy[j, k] = nuevoCosto;
                            }
                        }
                    }
                }
            }

            //imprimir matriz floyd
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (i == j) rich.Text += "0\t";
                    else if (matrizFloy[i, j] == int.MaxValue) rich.Text += "∞\t";
                    else rich.Text += matrizFloy[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }
    }
}
