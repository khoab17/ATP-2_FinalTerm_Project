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

        //Get all Products by name
        public static List<ProductModel> GetAllProductsByName(string n)
        {
            var temp = ProductRepo.GetAllProductsByName(n);
            var data = AutoMapper.Mapper.Map<List<Product>, List<ProductModel>>(temp);
            return data;
        }

        //Add Product
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

        //Update Product

        public static void UpdateProduct(ProductModel p)
        {
            Product prouduct = new Product()
            {
                Id = p.Id,
                Name = p.Name,
                Brand = p.Brand,
                Description = p.Description,
                Price = p.Price,
                CategoryId = p.CategoryId,
                Unit = p.Unit,
                SellerId = 2
            };
            ProductRepo.UpdateProduct(prouduct);

        }

        //Get All the categories
        public static List<CategoryModel> GetCategories()
        {
            var temp = ProductRepo.GetCategories();
            List<CategoryModel> data = new List<CategoryModel>();
            foreach(var category in temp)
            {
                CategoryModel c = new CategoryModel()
                {
                    Id = category.Id,
                    Name = category.Name
                };
                data.Add(c);
            }
            return data;
        }

        //Get Category by id
        public static CategoryModel GetCategory(int id)
        {
            var temp = ProductRepo.getCategory(id);
            CategoryModel data = new CategoryModel()
            {
                Id = temp.Id,
                Name = temp.Name
            };
            return data;
        }
        //Add Category

        public static void AddCategory(CategoryModel c)
        {
            Category data = new Category()
            {
                Name = c.Name
            };
            ProductRepo.AddCategory(data);
        }

    }
}
