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
            try
            {
                return context.Products.ToList();
            }
            catch
            {
                throw new Exception();
            }
            
        }

        public void Add(Products newProduct)
        {
            try
            {
                context.Products.Add(newProduct);
                context.SaveChanges();
            }
            catch
            {
                throw new Exception();
            }
        }

        public void Delete(int id)
        {
            try
            {
                var productAEliminar = context.Products.Single(p => p.ProductID == id);

                context.Products.Remove(productAEliminar);

                context.SaveChanges();
            }
            catch
            {
                throw new Exception();
            }
        }

        public void Update(Products product)
        {
            try
            {
                var productupdate = context.Products.Find(product.ProductID);

                productupdate.ProductName = product.ProductName;

                context.SaveChanges();
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
