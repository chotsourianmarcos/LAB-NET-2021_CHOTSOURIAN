using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Chotsourian.Entities;

namespace TP5_Chotsourian.Logic
{
    public class MenuLogic
    {
        TerritoriesLogic territoriesLogic = new TerritoriesLogic();

        ProductsLogic productsLogic = new ProductsLogic();
        public void LlamarMenu()
        {
            Console.WriteLine(
            "Menú:\n" +
            "1. Mostrar todos los territorios.\n" +
            "2. Mostrar todos los productos.\n" +
            "3. Agregar un nuevo territorio.\n" +
            "4. Borrar un territorio.\n" +
            "5. Modificar un territorio.\n" +
            "0. Terminar."
            );
        }
        public void LlamarTerritories()
        {
            foreach (Territories territory in territoriesLogic.GetAll())
            {
                Console.WriteLine($"{territory.TerritoryID} - {territory.TerritoryDescription} - {territory.RegionID}");
            }
        }
        public void LlamarProducts()
        {
            foreach (Products product in productsLogic.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
        public void NuevoTerritorio()
        {
            Console.WriteLine("Ingrese un ID int de 5 cifras a partir de 99.000 para crear un territorio.");
            string IDNew = Console.ReadLine();
            Console.WriteLine("Ingrese un string para la descripción del territorio.");
            string DescripNew = Console.ReadLine();
            Console.WriteLine("Ingrese un int del 1 al 4 para la región del territorio");
            int RegionIDNew = Convert.ToInt16(Console.ReadLine());
            try
            {
                territoriesLogic.Add(new Territories
                {
                    TerritoryID = IDNew,
                    TerritoryDescription = DescripNew,
                    RegionID = RegionIDNew
                });
                Console.WriteLine("El nuevo territorio ha sido creado.");
            }
            catch
            {
                Console.WriteLine("Lo siento, el territorio no ha podido ser creado. Verifique los datos.");
            }
        }

        public void BorrarTerritorio()
        {
            Console.WriteLine("Ingrese un ID int de 5 cifras para borrar un territorio");
            string IDDelete = Console.ReadLine();
            try
            {
                territoriesLogic.Delete(IDDelete);
                Console.WriteLine("El territorio ha sido borrado.");
            }
            catch
            {
                Console.WriteLine("Lo siento, el territorio no ha podido ser eliminado. Verifique los datos.");
            }
        }

        public void ModificarTerritorio()
        {
            Console.WriteLine("Seleccione un territorio para modificar datos con ID int de 5 cifras.");
            string IDModificar = Console.ReadLine();
            Console.WriteLine("Escriba la nueva descripción para el territorio elegido.");
            string DescripModificar = Console.ReadLine();
            Console.WriteLine("Escriba el ID de la región del nuevo territorio con un int del 1 al 4.");
            int IDRegionModificar = Convert.ToInt16(Console.ReadLine());
            try
            {
                territoriesLogic.Update(new Territories
                {
                    TerritoryDescription = DescripModificar,
                    TerritoryID = IDModificar,
                    RegionID = IDRegionModificar
                });
                Console.WriteLine("Los datos han sido modificados con éxito.");
            }
            catch
            {
                Console.WriteLine("Lo siento, la modificación no ha podido realizarse. Verifique los datos.");
            }
        }
    }
}
