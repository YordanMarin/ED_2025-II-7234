using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        cola c = new cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textNombre.Text))
            {
                if (Regex.IsMatch(textNombre.Text, @"^[a-zA-Z]+$"))
                {
                    listBox1.Items.Clear();
                    c.encolar(textNombre.Text.Trim());
                    c.mostrar(listBox1);
                    textNombre.Clear();
                }
                else MessageBox.Show("Solo se permiten lestras");
            }
            else MessageBox.Show("No se permiten vacios!");
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            string nom = c.desencolar();

            if (nom != null)
            {
                listBox1.Items.Clear();
                c.mostrar(listBox1);
                MessageBox.Show($"El nombre {nom} ah sido desencolado");
            }
            else MessageBox.Show("Cola vacia");
        }

        private void btnVistazo_Click(object sender, EventArgs e)
        {
            string nom = c.desencolar();

            if (nom != null)
            {
                MessageBox.Show($"Primero: {nom}");
            }
            else MessageBox.Show("Cola vacia");
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cantidad: {c.contar()}");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c.limpiar();
            listBox1.Items.Clear();
        }
    }
}
