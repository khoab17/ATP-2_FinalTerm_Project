using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Model
{
    public class CredentialModel
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public int UserId { get; set; }

        public virtual UserModel User { get; set; }
    }
}
