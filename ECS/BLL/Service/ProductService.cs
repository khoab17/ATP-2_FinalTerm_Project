using BEL.Model;
using BLL.Service.MapperConfig;
using DAL;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class ProductService
    {
       /* static ProductService()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSetting>());
        }*/
        public static List<ProductModel> GetAllProducts()
        {
            var temp= ProductRepo.GetAllProducts();
            var data = AutoMapper.Mapper.Map<List<Product>, List<ProductModel>>(temp);
            return data;
        }
        public static ProductModel GetProduct(int id)
        {
            var temp = ProductRepo.GetProduct(id);
            var data = AutoMapper.Mapper.Map<Product, ProductModel>(temp);
            return data;
        }

        public static void AddProduct(ProductModel p)
        {
            //var data=AutoMapper.Mapper.Map<ProductModel, Product>(p);
            Product data = new Product()
            {
                Name = p.Name,
                Brand = p.Brand,
                Description = p.Description,
                Price = p.Price,
                CategoryId = p.CategoryId,
                Unit = p.Unit,
                SellerId = p.SellerId,
            };
            ProductRepo.AddProduct(data);
        }
    }
}
