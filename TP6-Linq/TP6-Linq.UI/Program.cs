using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6_Linq.Entities;
using TP6_Linq.Logic;

namespace TP6_Linq.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqLogic linqLogic = new LinqLogic();

            Console.WriteLine("Vaya ingresando el numero del ejercicio cuya solucion quiera ejecutar, del 1 al 13. Para terminar ingrese 0.");

            int opcion = 99;

            while (opcion != 0)
            {
                Console.WriteLine("\n");
                opcion = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("\n");
                try
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Escriba ID customer para buscar sus datos. Por ejemplo ALFKI");
                            string ID = Console.ReadLine();
                            Console.WriteLine("Customer: " + linqLogic.DevolverCustomer(ID).ContactName);
                            break;
                        case 2:
                            foreach (var item in linqLogic.DevolverProductsSinStock())
                            {
                                Console.WriteLine("Product Name: " + item.ProductName);
                            }
                            break;
                        case 3:
                            foreach (var item in linqLogic.DevolvProdConStockPrecioMas3())
                            {
                                Console.WriteLine("Product Name: " + item.ProductName);
                            }
                            break;
                        case 4:
                            foreach (var item in linqLogic.DevolverCustomersWA())
                            {
                                Console.WriteLine("Customer: " + item.ContactName);
                            }
                            break;
                        case 5:
                            Console.WriteLine("Producto ID 789: " + linqLogic.Product789().ProductName);
                            break;
                        case 6:
                            foreach (var item in linqLogic.DevolverCustomers())
                            {
                                Console.WriteLine($"Customer: {item.ContactName.ToUpper()} - {item.ContactName.ToLower()}");
                            }
                            break;
                        case 7:
                            foreach (var item in linqLogic.JoinCustomersOrders())
                            {
                                Console.WriteLine($"CustomerID: {item.CustomerID} - {item.ContactName} - OrderID: {item.OrderID}");
                            }
                            break;
                        case 8:
                            foreach (var item in linqLogic.Top3CustomersWA())
                            {
                                Console.WriteLine("Customer: " + item.CustomerID + " - " + item.ContactName);
                            }
                            break;
                        case 9:
                            foreach (var item in linqLogic.ProductsPorNombre())
                            {
                                Console.WriteLine("Product: " + item.ProductName);
                            }
                            break;
                        case 10:
                            foreach (var item in linqLogic.ProductsPorStock())
                            {
                                Console.WriteLine("Product: " + item.ProductName + " - " + item.UnitsInStock);
                            }
                            break;
                        case 11:
                            foreach(var item in linqLogic.JoinProductsCategories())
                            {
                                Console.WriteLine(item.ProductID + "--" + item.ProductName + "--" + item.CategoryID + "--" + item.CategoryName);
                            }
                            break;
                        case 12:
                            List<Products> listaProducts = linqLogic.ProductsPorStock().ToList();//Un ejemplo.
                            Console.WriteLine("Primer producto: " + linqLogic.PrimerProduct(listaProducts).ProductName);
                            break;
                        case 13:
                            foreach(var item in linqLogic.GroupCustomersOrders())
                            {
                                Console.WriteLine(item.CustomerID + " - " + item.ContactName + " -- Cantidad de ordenes: " + item.OrderAmount);
                            }
                            break;
                        case 0:
                            break;
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Hubo un error. Verifique los datos.\n");
                }
            }
        }
    }
}
