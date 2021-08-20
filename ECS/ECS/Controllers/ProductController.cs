using BEL.Model;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECS.Controllers
{
    public class ProductController : ApiController
    {
        //Get Request to get All the products == "api/Product/All"

        [Route("api/Product/All")]
        [HttpGet]
        public List<ProductModel> GetAllProduct()
        {
            return ProductService.GetAllProducts();
        }

        //Get Request to get the product by id == "api/Product/{id}"
        [Route("api/Product/{id}")]
        [HttpGet]
        public ProductModel GetProduct(int id)
        {
            return ProductService.GetProduct(id);
        }

        //Add Product =="api/Product/Add"
        [Route("api/Product/Add")]
        [HttpPost]
        public void AddProduct(ProductModel p)
        {
            ProductService.AddProduct(p);
        }

        //Update Product
        [Route("api/Product/Update")]
        public void UpdateProduct(ProductModel p)
        {
            ProductService.UpdateProduct(p);
        }

        //Get All Categories
        [Route("api/Category/All")]
        [HttpGet]
        public List<CategoryModel> GetCategories()
        {
            return ProductService.GetCategories();
        }

        //Get categories by id
        [Route("api/Category/{id}")]
        [HttpGet]
        public CategoryModel GetCategory (int id)
        {
            return ProductService.GetCategory(id);
        }
        //Add Category
        [Route("api/Category/Add")]
        [HttpPost]
        public void AddCategory(CategoryModel c)
        {
            ProductService.AddCategory(c);
        }
    }
}
