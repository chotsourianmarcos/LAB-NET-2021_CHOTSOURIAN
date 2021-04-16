using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_POO_Transportes_Chotsourian
{
    public class Automoviles : Transporte
    {
        public Automoviles (int cantidadPasajeros, string nombre) : base(cantidadPasajeros, nombre)
        {

        }
        public override string Avanzar()
        {
            return $"Yo {nombre} arranco con {GetCantidadPasajeros()} pasajeros.";
        }

        public override string Detenerse()
        {
            return string.Format("Yo {0} me detengo y estaciono con {1} pasajeros", nombre, GetCantidadPasajeros());
        }
    }
}
