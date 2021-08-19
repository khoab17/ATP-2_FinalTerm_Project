using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL.Model;
using BLL.Service;

namespace ECS.Controllers
{
    public class UserController : ApiController
    {
        //Get the user Role
        [Route("api/User/{id}/Type")]
        [HttpGet]
        public string GetUserType(int id)
        {
            return UserService.GetUserType(id);
        }

        //Get the user Role
        [Route("api/User/{id}")]
        [HttpGet]
        public UserModel GetUser(int id)
        {
            return UserService.GetUser(id);
        }

        //Get all the Users
        [Route("api/Users/All")]
        [HttpGet]
        public List<UserModel> GetAllUsers()
        {
            return UserService.GetAllUsers();
        }

        //Get All the Admins
        [Route("api/Admin/GetAll")]
        [HttpGet]
        public List<UserModel> GetAdmin()
        {
            return UserService.GetAllAdmins();
        }

        //Add admin
        [Route("api/Admin/Add")]
        [HttpPost]
        public void AddAdmin(UserCredentialModel u)
        {
            UserService.AddAdmin(u);
        }

        //Get All the Buyers
        [Route("api/Buyer/GetAll")]
        [HttpGet]
        public List<UserModel> GetBuyers()
        {
            return UserService.GetAllBuyers();
        }

        //Get All the Sellers
        [Route("api/Seller/GetAll")]
        [HttpGet]
        public List<UserModel> GetSellers()
        {
            return UserService.GetAllSellers();
        }

    }
}
