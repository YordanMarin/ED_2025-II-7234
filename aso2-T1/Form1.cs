using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aso2_T1
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
            string su = textSueldo.Text;

            if (su.Contains("."))
            {
                string[] partes = su.Split('.');

                if (partes[0].Length == 4)
                {
                    if (partes[1].Length > 0)
                    {
                        if (!string.IsNullOrWhiteSpace(su) && double.TryParse(su, out double sueldo) && sueldo >0)
                        {
                            if(p.buscar(sueldo) == false)
                            {
                                listBox1.Items.Clear();
                                p.apilar(sueldo);
                                p.mostrar(listBox1);
                                textSueldo.Clear();
                            }else MessageBox.Show("No se permite sueldos duplicados");
                        }
                        else MessageBox.Show("Tiene que ser un número válido");
                    }
                    else MessageBox.Show("Ingresa como minimo 1 decimal");
                }
                else MessageBox.Show("Tiene que ser 4 enteros");
            }
            else MessageBox.Show("Tiene que ser decimal");
        }
    }
}
