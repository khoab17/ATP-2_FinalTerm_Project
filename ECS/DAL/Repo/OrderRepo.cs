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
        public static Order GetOrder(int id)
        {
            var data = context.Orders.Where(x => x.Id == id).FirstOrDefault();
            return data;
        }

    }
}
