using BEL.Model;
using DAL;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class OrderService
    {

        public static List<OrderModel> GetOrders()
        {
            var temp=OrderRepo.GetOreders();
            List<OrderModel> data=AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(temp);
            return data;
        }

        public static OrderModel GetOrder(int id)
        {
            var temp = OrderRepo.GetOrder(id);
            var data = AutoMapper.Mapper.Map< Order, OrderModel>(temp);
            return data;

        }

    }
}
