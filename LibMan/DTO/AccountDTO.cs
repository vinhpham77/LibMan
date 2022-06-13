using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public string Fullname { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? Gender { get; set; }
        public string ID { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }

        public AccountDTO(string username, string password, int roleID, string fullname, DateTime? birthday, bool? gender, string id, string address, bool? status)
        {
            Username = username;
            Password = password;
            RoleID = roleID;
            Fullname = fullname;
            Birthday = birthday;
            Gender = gender;
            ID = id;
            Address = address;
            Status = status;
        }

        public AccountDTO (Account acc)
        {
            Username = acc.Username;
            Password = acc.Password;
            RoleID = acc.RoleID;
            Birthday = acc.Birthday;
            Gender = acc.Gender;
            ID = acc.ID;
            Address = acc.Address;
            Status = acc.Status;
        }
    }
}
