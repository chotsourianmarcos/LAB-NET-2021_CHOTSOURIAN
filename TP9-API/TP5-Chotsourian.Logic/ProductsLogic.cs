using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Chotsourian.Data;
using TP5_Chotsourian.Entities;

namespace TP5_Chotsourian.Logic
{
    public class ProductsLogic : BaseLogic, IABMLogic<Products, int>
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public void Add(Products newProduct)
        {
            context.Products.Add(newProduct);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productAEliminar = context.Products.Single(p => p.ProductID == id);

            context.Products.Remove(productAEliminar);

            context.SaveChanges();
        }

        public void Update(Products product)
        {
            var productupdate = context.Products.Find(product.ProductID);

            productupdate.ProductName = product.ProductName;

            context.SaveChanges();
        }

    }
}
