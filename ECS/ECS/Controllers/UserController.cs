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
        [Route("api/User/{id}/Type")]
        [HttpGet]
        public string GetUserType(int id)
        {
            return UserService.GetUserType(id);
        }

        [Route("api/Admin/GetAll")]
        [HttpGet]
        public List<UserModel> GetAdmin()
        {
            return UserService.GetAllAdmins();
        }

        [Route("api/Buyer/GetAll")]
        [HttpGet]
        public List<UserModel> GetBuyers()
        {
            return UserService.GetAllBuyers();
        }

        [Route("api/Seller/GetAll")]
        [HttpGet]
        public List<UserModel> GetSellers()
        {
            return UserService.GetAllSellers();
        }

    }
}
