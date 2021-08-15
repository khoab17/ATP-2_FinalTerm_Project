using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Model
{
    public class ProductModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductModel()
        {
            this.OrderDetails = new HashSet<OrderDetailModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int Unit { get; set; }
        public int SellerId { get; set; }
        public Nullable<int> user_Id { get; set; }

        [NoMap]
        public virtual CategoryModel CategoryModel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetailModel> OrderDetails { get; set; }
        [NoMap]
        public virtual UserModel UserModel { get; set; }
    }
}
