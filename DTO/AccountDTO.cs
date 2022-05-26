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
        public int AccountTypeID { get; set; }
        public string Fullname { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? Gender { get; set; }
        public string UserID { get; set; }
        public string Address { get; set; }
    }
}
