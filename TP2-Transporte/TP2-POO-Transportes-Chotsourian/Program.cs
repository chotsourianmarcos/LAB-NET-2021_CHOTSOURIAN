using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_POO_Transportes_Chotsourian
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> listaAviones = new List<Transporte>
            {
                new Aviones (102, "Avion1"),
                new Aviones (234, "Avion2"),
                new Aviones (310, "Avion3"),
                new Aviones (25, "Avion4"),
                new Aviones (80, "Avion5")
            };
            List<Transporte> listaAutomoviles = new List<Transporte>
            {
                new Automoviles (2, "Automovil1"),
                new Automoviles (3, "Automovil2"),
                new Automoviles (1, "Automovil3"),
                new Automoviles (6, "Automovil4"),
                new Automoviles (2, "Automovil5")
            };
            int totalPasajeros = 0;
            foreach (var item in listaAviones)
            {
                Console.WriteLine(item.nombre + " contiene " + item.GetCantidadPasajeros() + " pasajeros.");
                totalPasajeros += item.GetCantidadPasajeros();
            }
            foreach (var item in listaAutomoviles)
            {
                Console.WriteLine(item.nombre + " contiene " + item.GetCantidadPasajeros() + " pasajeros.");
                totalPasajeros += item.GetCantidadPasajeros();
            }
            foreach (var item in listaAviones)
            {
                if (item.GetCantidadPasajeros()%2 == 0)
                {
                    Console.WriteLine(item.Avanzar());
                }
                else
                {
                    Console.WriteLine(item.Detenerse());
                }
            }
            

            Console.WriteLine("La cantidad total de pasajeros es" + totalPasajeros);

            Console.ReadLine();
        }
    }
}
