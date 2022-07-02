using System;

namespace DTO
{
    public class LoanDTO
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public int BookID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
