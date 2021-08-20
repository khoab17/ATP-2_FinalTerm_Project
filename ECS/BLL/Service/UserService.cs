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
        /*static UserService()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSetting>());
        }*/

        //Get user type
        public static string GetUserType(int id)
        {
            return UserRepo.GetUserType(id);
        }

        //Get All the Users
        public static List<UserModel> GetAllUsers()
        {
            var data = UserRepo.GetAllUsers();
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

        public static void UpdateUser(UserModel u)
        {
           // var u = UserRepo.GetUser(id);
            User user = new User()
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                Phone = u.Phone,
                DOB = u.DOB,
                Address = u.Address,
                RegDate = u.RegDate,
                Gender = u.Gender
            };
            UserRepo.UpdateUser(user);
        }

        //Get User by ID
        public static UserModel GetUser(int id)
        {
            var u=UserRepo.GetUser(id);
            UserModel user = new UserModel()
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                Phone = u.Phone,
                DOB = u.DOB,
                Address = u.Address,
                RegDate = u.RegDate,
                Gender = u.Gender
            };
            return user;
        }



        //Get All the Admins
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
        //Add admin
        public static void AddAdmin(UserCredentialModel u)
        {
            User admin = new User()
            {
                Name=u.Name,
                Email=u.Email,
                Phone=u.Phone,
                DOB=u.DOB,
                Address=u.Address,
                Gender=u.Gender
            };
            Credential cred = new Credential()
            {
                Password = u.Password,
                UserType = "Admin",
                UserId = u.Id
            };
            UserRepo.AddAdmin(admin,cred);
      
        }



        //Get All the Buyers
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


        //Get All the Sellers
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
