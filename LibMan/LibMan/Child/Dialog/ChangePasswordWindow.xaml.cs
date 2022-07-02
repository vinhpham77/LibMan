using System;
using System.Windows;
using BLL;

namespace GUI.Child.Dialog
{
    public partial class ChangePasswordWindow : Window
    {
        public ChangePasswordWindow(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AccountBLL.ChangePassword(txtUsername.Text, txtNewPassword.Text);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
