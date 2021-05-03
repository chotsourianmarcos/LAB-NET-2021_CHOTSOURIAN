using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Chotsourian.Entities;
using TP5_Chotsourian.Logic;

namespace TP5_Chotsourian
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            int opcion = 9;
            menu.LlamarMenu();

            while (opcion != 0)
            {
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        menu.LlamarTerritories();
                        Console.WriteLine("\n\n");
                        menu.LlamarMenu();
                        break;
                    case 2:
                        menu.LlamarProducts();
                        Console.WriteLine("\n\n");
                        menu.LlamarMenu();
                        break;
                    case 3:
                        menu.NuevoTerritorio();
                        Console.WriteLine("\n\n");
                        menu.LlamarMenu();
                        break;
                    case 4:
                        menu.BorrarTerritorio();
                        Console.WriteLine("\n\n");
                        menu.LlamarMenu();
                        break;
                    case 5:
                        menu.ModificarTerritorio();
                        Console.WriteLine("\n\n");
                        menu.LlamarMenu();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida.");
                        menu.LlamarMenu();
                        break;
                }
            }
        }
    }
}
