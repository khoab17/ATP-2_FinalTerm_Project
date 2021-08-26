using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Model
{
    public class OrderModel
    {
        /*
        public OrderModel()
        {
            this.OrderDetails = new HashSet<OrderDetailModel>();
        }
        */
        public int Id { get; set; }
        public System.DateTime OrderTime { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int CustomerId { get; set; }
        public string OrderAddress { get; set; }
        public double Amount { get; set; }

        //public virtual ICollection<OrderDetailModel> OrderDetails { get; set; }
       // public virtual StatusModel Status { get; set; }
    }
}
