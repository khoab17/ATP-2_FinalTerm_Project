using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Model
{
    public class UserModel
    {
        public UserModel()
        {
            this.Credentials = new HashSet<CredentialModel>();
            this.Products = new HashSet<ProductModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public System.DateTime RegDate { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<CredentialModel> Credentials { get; set; }
        public virtual ICollection<ProductModel> Products { get; set; }
    }
}
