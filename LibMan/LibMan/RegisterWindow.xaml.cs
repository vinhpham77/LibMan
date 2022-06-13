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
            txtUsername.Focus();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            
            string error = AccountBLL.CreateAccount(txtAddress.Text, txtPassword.Password, txtRePassword.Password, 1
                                          , txtFullname.Text, dpBirthday.Text, rdMale.IsChecked, txtID.Text, txtAddress.Text);
            if (error is null)
            {
                MessageBox.Show("Đăng ký thành công! Vui lòng đợi phê duyệt tài khoản", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                btnCancel_Click(null, null);
            }
            else
            {
                MessageBox.Show(error, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
