using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila
{
    public partial class Form1 : Form
    {
        Pila p = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            p.Push(textNombre.Text);
            p.mostrar(listBox1 );
            textNombre.Clear();
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            if(p.Pop() != null)
            {
                listBox1.Items.Clear();
                p.mostrar(listBox1);
            }
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad: " + p.Count());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            p.Clear();
            listBox1.Items.Clear();
            MessageBox.Show("Pila restaurada");
        }
    }
}
