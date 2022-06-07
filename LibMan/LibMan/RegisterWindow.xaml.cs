using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BLL;

namespace GUI
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string pass = txtPassword.Password.Trim();
            string repass = txtRePassword.Password.Trim();
            string fullname = txtUsername.Text.Trim();
            string birthday = dpBirthday.Text.Trim();
            bool gender = rdMale.IsChecked == true;
            string id = txtID.Text.Trim();
            string address = txtAddress.Text.Trim();
            object[] formInputs = { username, pass, repass, fullname, birthday, gender, id, address};

            string error = AccountBLL.ValidateRegister(formInputs);
            if (error is null)
            {
                AccountBLL.CreateAccount(username, pass, 1, fullname, birthday, gender, id, address);
                MessageBox.Show("Đăng ký thành công! Vui lòng đợi phê duyệt tài khoản", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                btnBack_Click(null, null);
            }
            else
            {
                MessageBox.Show(error, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
