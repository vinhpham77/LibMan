using BLL;
using System.Windows;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            bool isCorrect = AccountBLL.CheckAccount(txtUsername.Text, txtPassword.Password);
            if (!isCorrect)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Đăng nhập");
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow register = new RegisterWindow();
            register.Show();
        }
    }
}
