using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Model
{
    public class StatusModel
    {
        public StatusModel()
        {
            this.Orders = new HashSet<OrderModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<OrderModel> Orders { get; set; }
    }
}
