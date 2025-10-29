using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        arbol a = new arbol();
        Nodo raiz;
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (raiz == null)
                raiz = a.insertar(null, int.Parse(textNumero.Text));
            else
                a.insertar(raiz, int.Parse(textNumero.Text));

            treeView1.Nodes.Clear();
            a.mostrar(raiz, treeView1, null);
            treeView1.ExpandAll();
            textNumero.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (raiz != null)
            {
                int ra = raiz.numero;
                MessageBox.Show("Suma de nodos: " + (a.sumaNodos(raiz)));
            }
            else MessageBox.Show("Arbol vacio.");

        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            if (raiz != null)
                MessageBox.Show("Mínimo: " + a.minimo(raiz).numero);
            else MessageBox.Show("Arbol vacio.");
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            if (raiz != null)
                MessageBox.Show("Máximo: " + a.maximo(raiz).numero);
            else MessageBox.Show("Arbol vacio.");
        }

        private void btnBalanceado_Click(object sender, EventArgs e)
        {
            if(a.verificarbalance(raiz) != -1)
                MessageBox.Show("Esta balanceado");
            else
                MessageBox.Show("No esta balanceado");

        }
    }
}
