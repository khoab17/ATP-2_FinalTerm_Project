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
            List<OrderModel> data = new List<OrderModel>();
           // List<OrderModel> data=AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(temp);
           foreach(var item in temp)
            {
                OrderModel o = new OrderModel();
                o.Id = item.Id;
                o.OrderTime = item.OrderTime;
                o.StatusId = item.StatusId;
                if(item.StatusId==1)
                {
                    o.StatusName = "Processing";
                }
                else if(item.StatusId==2)
                {
                    o.StatusName = "Picked";
                }
                else if(item.StatusId==3)
                {
                    o.StatusName = "Delivered";
                }
                o.CustomerId = item.CustomerId;
                o.OrderAddress = item.OrderAddress;
                o.Amount = item.Amount;
                data.Add(o);
            }

            return data;
        }

        public static OrderModel GetOrder(int id)
        {
            var temp = OrderRepo.GetOrder(id);
            var data = AutoMapper.Mapper.Map< Order, OrderModel>(temp);
            return data;

        }

        public static List<OrderModel> GetOrderProcessing()
        {
            var temp = OrderRepo.GetOrederProcessing();
            List<OrderModel> data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(temp);
            return data;
        }
        public static List<OrderModel> GetOrderPicked()
        {
            var temp = OrderRepo.GetOrederPicked();
            List<OrderModel> data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(temp);
            return data;
        }
        public static List<OrderModel> GetOrderDelivered()
        {
            var temp = OrderRepo.GetOrederDelivered();
            List<OrderModel> data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(temp);
            return data;
        }

    }
}
