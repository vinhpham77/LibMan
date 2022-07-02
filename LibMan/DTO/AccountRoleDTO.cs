using System;
using System.ComponentModel;

namespace DTO
{
    public class AccountRoleDTO : INotifyPropertyChanged
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public string Fullname { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? Gender { get; set; }
        public string ID { get; set; }
        public string Address { get; set; }
        private bool? _status { get; set; }
        
        public bool? Status
        {
            get => _status;
            set
            {
                _status = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Status"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
