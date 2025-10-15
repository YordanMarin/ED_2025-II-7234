using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_Busqueda
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
            try
            {
                if (raiz == null) //inserta raiz
                    raiz = a.insertar(null, int.Parse(textNumero.Text));
                else //inserta tallos y hojas
                    a.insertar(raiz, int.Parse(textNumero.Text));

                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("No se permiten nulos");

            }
        }
        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            textPre.Clear();
            textIn.Clear();
            textPost.Clear();
            a.preOrden(raiz, textPre);
            a.inOrden(raiz, textIn);
            a.postOrden(raiz, textPost);
        }
    }
}
