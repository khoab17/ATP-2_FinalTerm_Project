using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class OrderRepo
    {
        static ECSEntities context;
        static OrderRepo()
        {
            context = new ECSEntities();
        }

        public static List<Order> GetOreders()
        {
            var data = context.Orders.ToList();
            return data;
        }

        //Get orders that are processing
        public static List<Order> GetOrederProcessing()
        {
            int status = 1;
            List<Order> data = (from s in context.Status
                                 join o in context.Orders on s.Id equals o.StatusId
                                 where o.StatusId== status
                                 select o).ToList();
            return data;
        }

        //Get orders that are processing
        public static List<Order> GetOrederPicked()
        {
            int status = 2;
            List<Order> data = (from s in context.Status
                                join o in context.Orders on s.Id equals o.StatusId
                                where o.StatusId == status
                                select o).ToList();
            return data;
        }

        //Get orders that are processing
        public static List<Order> GetOrederDelivered()
        {
            int status = 3;
            List<Order> data = (from s in context.Status
                                join o in context.Orders on s.Id equals o.StatusId
                                where o.StatusId == status
                                select o).ToList();
            return data;
        }

        public static Order GetOrder(int id)
        {
            var data = context.Orders.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }

    }
}
