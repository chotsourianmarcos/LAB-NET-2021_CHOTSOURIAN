using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_POO_Transportes_Chotsourian
{
    public class Aviones : Transporte
    {
        public Aviones(int cantidadPasajeros, string nombre) : base(cantidadPasajeros, nombre)
        {

        }
        public override string Avanzar()
        {
            return $"Yo {nombre} despego exitosamente con {GetCantidadPasajeros()} pasajeros.";
        }

        public override string Detenerse()
        {
            return string.Format("Yo {0} aterrizo exitosamente con {1} pasajeros", nombre, GetCantidadPasajeros());
        }
    }
}
