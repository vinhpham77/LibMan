using BLL;
using System;
using System.Windows;

namespace GUI
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login(string username, int roleID)
        {
            switch (roleID)
            {
                case 1:
                    var reader = new ReaderWindow(username);
                    reader.Show();
                    break;
                case 2:
                    var librarian = new LibrarianWindow(username);
                    librarian.Show();
                    break;
                case 3:
                    var admin = new AdminWindow(username);
                    admin.Show();
                    break;
            }
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Password;

            try
            {
                int roleID = AccountBLL.CheckLogin(username, password);
                Login(username, roleID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var register = new RegisterWindow();
            Close();
            register.Show();
        }
    }
}
