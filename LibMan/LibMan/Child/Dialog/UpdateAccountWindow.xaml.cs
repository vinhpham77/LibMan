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
using DTO;
using BLL;

namespace GUI.Child.Dialog
{
    /// <summary>
    /// Interaction logic for UpdateAccountWindow.xaml
    /// </summary>
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
            cbxRole.ItemsSource = RoleBLL.GetRoleList();
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
            try
            {
                AccountBLL.UpdateAccount(txtUsername.Text, (int)cbxRole.SelectedValue, txtFullname.Text, 
                                dtpBirthday.Text, (bool)rdMale.IsChecked, txtID.Text, txtAddress.Text);
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
