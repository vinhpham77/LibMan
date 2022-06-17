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
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string Fullname { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? Gender { get; set; }
        public string ID { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }

        public AccountRoleDTO(Account acc, Role role)
        {
            Username = acc.Username;
            Password = acc.Password;
            RoleID = acc.RoleID;
            RoleName = role.Name;
            Fullname = acc.Fullname;
            Birthday = acc.Birthday;
            Gender = acc.Gender;
            ID = acc.ID;
            Address = acc.Address;
            Status = acc.Status;
        }
    }
}
