using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public  class ProductRepo
    {
        static ECSEntities context;
        static ProductRepo()
        {
            context = new ECSEntities();
        }

        //Get All the Products
        public static List<Product> GetAllProducts()
        {
            var data = context.Products.ToList();
            return data;
        }

        //Search Product by Id
        public static Product GetProduct(int id)
        {
            Product data = context.Products.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }

        //Add Product
        public static void AddProduct(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }
    }
}
