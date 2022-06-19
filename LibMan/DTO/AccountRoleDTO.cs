using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountRoleDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public string Fullname { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? Gender { get; set; }
        public string ID { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }
    }
}
