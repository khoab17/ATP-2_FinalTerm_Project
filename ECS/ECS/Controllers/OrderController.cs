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
    public class OrderController : ApiController
    {
        [Route("api/Order/All")]
        [HttpGet]
        public List<OrderModel> GetOrders()
        {
            var data= OrderService.GetOrders();
            return data;
        }

        [Route("api/Order/{id}")]
        [HttpGet]
        public OrderModel GetOrder(int id)
        {
            return OrderService.GetOrder(id);
        }

    }
}
