using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Model
{
    public class UserCredentialModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public System.DateTime RegDate { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public int UserId { get; set; }
    }
}
