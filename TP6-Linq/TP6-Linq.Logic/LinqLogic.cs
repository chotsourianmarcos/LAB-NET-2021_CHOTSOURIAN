using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6_Linq.Data;
using TP6_Linq.Entities;
using TP6_Linq.Entities.JoinEntities;

namespace TP6_Linq.Logic
{
    public class LinqLogic
    {
        private readonly NorthwindContext context;

        public LinqLogic()
        {
            context = new NorthwindContext();
        }

        // 1. Query para devolver objeto customer.

        public Customers DevolverCustomer(string ID)
        {
            return context.Customers.Where(id => id.CustomerID == ID).SingleOrDefault();
        }

        // 2. Query para devolver todos los productos sin stock.
        public List<Products> DevolverProductsSinStock()
        {
            var products = context.Products.Where(i => i.UnitsInStock == 0).ToList();
            return products;
        }

        // 3.Query para devolver todos los productos que tienen stock y que cuestan más de 3 por
        // unidad.
        public List<Products> DevolvProdConStockPrecioMas3()
        {
            var products3 = context.Products.Where(i => i.UnitPrice > 3 && i.UnitsInStock > 0).ToList();
            return products3;
        }

        // 4. Query para devolver todos los customers de Washington.
        public List<Customers> DevolverCustomersWA()
        {
            var customersWA = context.Customers.Where(i => i.Region == "WA").ToList();
            return customersWA;
        }
        // 5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de
        // producto sea igual a 789.
        
        public Products Product789()
        {
            return context.Products.Where(i => i.ProductID == 789).FirstOrDefault();
        }

        // 6. Query para devolver los nombre de los Customers.Mostrarlos en Mayuscula y en
        // Minuscula.

        public List<Customers> DevolverCustomers()
        {
            var customers = context.Customers.ToList();
            return customers;
        }

        // 7. Query para devolver Join entre Customers y Orders donde los customers sean de
        // Washington y la fecha de orden sea mayor a 1/1/1997.
        public IEnumerable<CustomersOrders> JoinCustomersOrders()
        {
            DateTime fecha = DateTime.ParseExact(19970101.ToString(), "yyyyMMdd", null);
            var customersOrders = from Customers in context.Customers
                                  join Orders in context.Orders
                                  on Customers.CustomerID equals Orders.CustomerID
                                  where Orders.OrderDate > fecha && Customers.Region == "WA"
                                  select new CustomersOrders
                                  {
                                      CustomerID = Customers.CustomerID,
                                      ContactName = Customers.ContactName,
                                      OrderID = Orders.OrderID
                                  };
            return customersOrders; 
        }

        // 8. Query para devolver los primeros 3 Customers de Washington.

        public List<Customers> Top3CustomersWA()
        {
            var top3CustomersWA = context.Customers.Take(3).ToList();
            return top3CustomersWA;
        }

        // 9. Query para devolver lista de productos ordenados por nombre.

        public List<Products> ProductsPorNombre()
        {
            var productsPorNombre = context.Products.OrderBy(name => name.ProductName).ToList();
            return productsPorNombre;
        }

        // 10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.

        public IEnumerable<Products> ProductsPorStock()
        {
            var productosPorStock = from Products in context.Products
                                    orderby Products.UnitsInStock descending
                                    select Products;

            return productosPorStock;
        }

        // 11. Query para devolver las distintas categorías asociadas a los productos.

        public IEnumerable<ProductsCategories> JoinProductsCategories()
        {
            var productsCategories =    from Categories in context.Categories
                                        join Products in context.Products
                                        on Categories.CategoryID equals Products.CategoryID
                                        select new ProductsCategories
                                        {
                                        ProductID = Products.ProductID,
                                        ProductName = Products.ProductName,
                                        CategoryID = Categories.CategoryID,
                                        CategoryName = Categories.CategoryName
                                        };
            return productsCategories;
        }

        // 12. Query para devolver el primer elemento de una lista de productos.

        public Products PrimerProduct(List<Products> listaProducts)
        {
            var primerProduct = listaProducts.FirstOrDefault();
            return primerProduct;
        }

        // 13. Query para devolver los customer con la cantidad de ordenes asociadas.

        public IEnumerable<CustomersOrders> GroupCustomersOrders()
        {
            var groupCustomersOrders =     from Customers in context.Customers
                                           join Orders in context.Orders
                                           on Customers.CustomerID equals Orders.CustomerID
                                           group Customers by new
                                           {Customers.ContactName,
                                           Customers.CustomerID }
                                           into tabla
                                           select new CustomersOrders 
                                           {
                                           CustomerID = (string)tabla.Key.CustomerID,
                                           ContactName = (string)tabla.Key.ContactName,
                                           OrderAmount = tabla.Count()
                                           };
            return groupCustomersOrders;
        }

    }

}       
