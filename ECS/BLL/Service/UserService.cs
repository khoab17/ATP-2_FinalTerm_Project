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

        public static string GetUserType(int id)
        {
            return UserRepo.GetUserType(id);
        }
        public static List<UserModel> GetAllAdmins()
        {
            var data = UserRepo.GetAllAdmins();
            List<UserModel> um = new List<UserModel>();
            foreach(var item in data)
            {
                UserModel us = new UserModel()
                {
                    Id=item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    Phone = item.Phone,
                    DOB = item.DOB,
                    Address = item.Address,
                    RegDate = item.RegDate,
                    Gender = item.Gender
                };
                um.Add(us);
            }
            return um;
        }

        public static List<UserModel> GetAllBuyers()
        {
            var data = UserRepo.GetAllBuyers();
            List<UserModel> um = new List<UserModel>();
            foreach (var item in data)
            {
                UserModel us = new UserModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    Phone = item.Phone,
                    DOB = item.DOB,
                    Address = item.Address,
                    RegDate = item.RegDate,
                    Gender = item.Gender
                };
                um.Add(us);
            }
            return um;
        }

        public static List<UserModel> GetAllSellers()
        {
            var data = UserRepo.GetAllSellers();
            List<UserModel> um = new List<UserModel>();
            foreach (var item in data)
            {
                UserModel us = new UserModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    Phone = item.Phone,
                    DOB = item.DOB,
                    Address = item.Address,
                    RegDate = item.RegDate,
                    Gender = item.Gender
                };
                um.Add(us);
            }
            return um;
        }




    }
}
