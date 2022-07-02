using System;
using System.Windows;
using BLL;

namespace GUI
{
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            var login = new LoginWindow();
            Close();
            login.Show();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string pass = txtPassword.Password;
            string repass = txtRePassword.Password;
            int readerRole = 1;
            string fullname = txtFullname.Text.Trim();
            DateTime? birthday = dpBirthday.SelectedDate;
            bool gender = (bool)rdMale.IsChecked;
            string id = txtID.Text.Trim();
            string address = txtAddress.Text.Trim();
            bool status = false;
            
            try
            {
                AccountBLL.CreateAccount(username,pass, repass, readerRole, fullname, 
                                            birthday, gender, id, address, status);
                string message = "Đăng ký thành công! Vui lòng đợi phê duyệt tài khoản";
                MessageBox.Show(message, Title, MessageBoxButton.OK, MessageBoxImage.Information);
                btnCancel_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
