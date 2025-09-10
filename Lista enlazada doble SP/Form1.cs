using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_enlazada_doble_SP
{
    public partial class Form1 : Form
    {
        Lista l = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre!");
            }
            else
            {
                if(byte.TryParse(textEdad.Text, out byte edad)){
                    listView1.Items.Clear();
                    l.insertar(textNombre.Text.Trim(), edad);
                    l.mostrar(listView1);
                    textNombre.Clear();
                    textEdad.Clear();
                }
                else
                {
                    MessageBox.Show("Ingrese una edad válida!");
                }
            }
        }
    }
}
