using BLL;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void Login(string username)
        {
            int roleID = AccountBLL.GetRoleID(username);
            Hide();
            switch (roleID)
            {
                case 1:
                    ReaderWindow reader = new ReaderWindow(username);
                    reader.Show();
                    break;
                case 2:
                    LibrarianWindow librarian = new LibrarianWindow(username);
                    librarian.Show();
                    break;
                case 3:
                    AdminWindow admin = new AdminWindow(username);
                    admin.Show();
                    break;
            }
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            string message = AccountBLL.CheckLogin(username, password);
            if (message is null)
            {
                Login(username);
            }
            else
            {   
                MessageBox.Show(message, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow register = new RegisterWindow();
            register.Show();
        }
    }
}
