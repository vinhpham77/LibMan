using System;
using System.Windows;
using DTO;
using BLL;

namespace GUI.Child.Dialog
{
    public partial class UpdateAccountWindow : Window
    {
        public UpdateAccountWindow(AccountRoleDTO acc)
        {
            InitializeComponent();
            LoadElements(acc);
        }

        private void LoadElements(AccountRoleDTO acc)
        {
            txtUsername.Text = acc.Username;
            cbxRole.ItemsSource = RoleBLL.GetRoles();
            cbxRole.Text = acc.RoleName;
            txtFullname.Text = acc.Fullname;
            dtpBirthday.SelectedDate = acc.Birthday;
            
            if (acc.Gender is true)
            {
                rdMale.IsChecked = true;
            }
            else
            {
                rdFemale.IsChecked = true;
            }

            txtID.Text = acc.ID;
            txtAddress.Text = acc.Address;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            int roleID = (int)cbxRole.SelectedValue;
            string fullname = txtFullname.Text.Trim();
            string birthday = dtpBirthday.Text.Trim();
            bool gender = (bool)rdMale.IsChecked;
            string id = txtID.Text.Trim();
            string address = txtAddress.Text.Trim();

            try
            {
                AccountBLL.UpdateAccount(username, roleID, fullname, 
                                            birthday, gender, id, address);
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
