using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL.Model;

namespace ECS.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/Admin/GetAll")]
        [HttpPost]
        public List<UserModel> GetAdmin()
        {
            return null;
        }
    }
}
