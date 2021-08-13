using AutoMapper;
using BEL.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.MapperConfig
{
    public class AutoMapperSetting:Profile
    {
        public AutoMapperSetting()
        {
            CreateMap<User, UserModel>();
            CreateMap<Category, CategoryModel>();
            CreateMap<Credential, CredentialModel>();
            CreateMap<Order, OrderModel>();
            CreateMap<Product, ProductModel>();
            CreateMap<Status, StatusModel>();
            CreateMap<OrderDetail, OrderDetailModel>();
        }

    }
}
