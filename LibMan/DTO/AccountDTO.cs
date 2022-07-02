using System;

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
    }
}
