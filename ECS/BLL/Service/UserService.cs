using BEL.Model;
using BLL.Service.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class UserService
    {
        static UserService()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSetting>());
        }
        /*public static UserModel GetAllProducts()
        {
            var temp = UserRepo.GetAllAdmins();
            var data = AutoMapper.Mapper.Map<List<Product>, List<ProductModel>>(temp);
        }
        */
    }
}
