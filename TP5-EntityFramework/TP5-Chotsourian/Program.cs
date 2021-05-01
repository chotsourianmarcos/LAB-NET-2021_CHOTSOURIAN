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
            MenuLogic menulogic = new MenuLogic();

            int opcion = 9;
            menulogic.LlamarMenu();

            while (opcion != 0)
            {
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        menulogic.LlamarTerritories();
                        Console.WriteLine("\n\n");
                        menulogic.LlamarMenu();
                        break;
                    case 2:
                        menulogic.LlamarProducts();
                        Console.WriteLine("\n\n");
                        menulogic.LlamarMenu();
                        break;
                    case 3:
                        menulogic.NuevoTerritorio();
                        Console.WriteLine("\n\n");
                        menulogic.LlamarMenu();
                        break;
                    case 4:
                        menulogic.BorrarTerritorio();
                        Console.WriteLine("\n\n");
                        menulogic.LlamarMenu();
                        break;
                    case 5:
                        menulogic.ModificarTerritorio();
                        Console.WriteLine("\n\n");
                        menulogic.LlamarMenu();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida.");
                        menulogic.LlamarMenu();
                        break;
                }
            }
        }
    }
}
