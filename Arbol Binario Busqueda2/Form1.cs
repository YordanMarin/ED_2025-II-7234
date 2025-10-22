using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario_Busqueda2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Nodo raiz;
        arbol a = new arbol();
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                if (raiz == null) raiz = a.insertar(null, num);
                else a.insertar(raiz, num);

                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
            }
            else MessageBox.Show("Ingrese un número valido.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                Nodo buscar = a.buscar(raiz, num);
                if (buscar != null)
                    MessageBox.Show($"El número{num} si existe");
                else 
                    MessageBox.Show($"El número {num} no existe");
            }
            else MessageBox.Show("Ingrese un número valido a buscar.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textNumero.Text, out int num))
            {
                Nodo buscar = a.buscar(raiz,num);

                if(buscar != null)
                {
                    raiz = a.eliminar(raiz, num);
                    treeView1.Nodes.Clear();
                    a.mostrar(raiz, treeView1 , null);
                    treeView1.ExpandAll();
                    textNumero.Clear();
                }else MessageBox.Show($"No se puede eliminar. El número {num} no existe");
            }
            else MessageBox.Show("Ingrese un número valido a eliminar.");
        }
    }
}
