using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_POO_Transportes_Chotsourian
{
    public abstract class Transporte
    {
        private int cantidadPasajeros { get; }
        public string nombre { get; }
        public Transporte(int cantidadPasajeros, string nombre)
        {
            this.cantidadPasajeros = cantidadPasajeros;
            this.nombre = nombre;
        }

        public int GetCantidadPasajeros()
        {
            return cantidadPasajeros;
        }
        public abstract string Avanzar();
        public abstract string Detenerse();
    }
}
