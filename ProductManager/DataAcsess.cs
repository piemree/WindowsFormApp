using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductManager
{
    internal class DataAcsess
    {
        DbFirstEfEntities ctx = new DbFirstEfEntities();
        public List<Product> GetProducts()
        {
            return ctx.Product.Select(x => x).ToList();
        }

        public string AddProduct(string name, string count)
        {
                Product product = new Product()
                {
                    name = name,
                    count = Convert.ToInt32(count),
                };

                ctx.Product.Add(product);

                try
                {
                    ctx.SaveChanges();

                    return "Product added to db successfully";
                }
                catch (Exception err)
                {
                    return err.Message;
                }
           
        }

        public void DeleteProduct(Product product)
        {
            ctx.Product.Remove(product);

            ctx.SaveChanges();
        }

        internal Product FindProduct(int id)
        {
        var product = ctx.Product.Where(p => p.id == id).FirstOrDefault();

            return product;
        }
    }
}