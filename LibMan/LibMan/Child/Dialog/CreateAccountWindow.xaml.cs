using System;
using System.Windows;
using BLL;

namespace GUI.Child.Dialog
{
    public partial class CreateAccountWindow : Window
    {
        public CreateAccountWindow()
        {
            InitializeComponent();
            cbxRole.ItemsSource = RoleBLL.GetRoles();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string pass = txtPassword.Password;
            string repass = txtRePassword.Password;
            var roleID = cbxRole.SelectedValue as int?;
            string fullname = txtFullname.Text.Trim();
            DateTime? birthday = dtpBirthday.SelectedDate;
            var gender = (bool)rdMale.IsChecked;
            string id = txtID.Text.Trim();
            string address = txtAddress.Text.Trim();
            bool status = true;

            try
            {
                AccountBLL.CreateAccount(username, pass, repass, roleID, fullname,
                                            birthday, gender, id, address, status);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
