using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aso2_T1
{
    internal class Nodo
    {
        private double sueldo;
        private Nodo siguiente;

        public double Sueldo { get => sueldo; set => sueldo = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
