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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            Close();
            login.Show();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            int readerRole = 1;
            bool status = false;
            
            try
            {
                AccountBLL.CreateAccount(txtUsername.Text, txtPassword.Password, txtRePassword.Password, readerRole,
                        txtFullname.Text, dpBirthday.SelectedDate, (bool)rdMale.IsChecked, txtID.Text, txtAddress.Text, status);
                MessageBox.Show("Đăng ký thành công! Vui lòng đợi phê duyệt tài khoản", Title, MessageBoxButton.OK, MessageBoxImage.Information);
                btnCancel_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
