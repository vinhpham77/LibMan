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
using BLL;
using DTO;
using GUI.Child.AddWindow;

namespace GUI.Child
{
    /// <summary>
    /// Interaction logic for AccountManPage.xaml
    /// </summary>
    public partial class AccountManPage : Page
    {
        public AccountManPage()
        {
            InitializeComponent();
            dtgAccount_Load();
        }

        private void dtgAccount_Load(string username = "")
        {
            dtgAccount.ItemsSource = AccountRoleBLL.GetAccountRoleList(username);
        }
        
        private void btnAddAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtAccountSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dtgAccount_Load(txtAccountSearch.Text);
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtAccountSearch.Clear();
            dtgAccount_Load();
        }

        private void btnEditAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            AccountRoleDTO ar = dtgAccount.SelectedItem as AccountRoleDTO;
            ChangePasswordWindow change = new ChangePasswordWindow(ar.Username);
            change.ShowDialog();
        }

        private void btnChangeStatus_Click(object sender, RoutedEventArgs e)
        {
            AccountRoleDTO ar = dtgAccount.SelectedItem as AccountRoleDTO;
            bool status = !(ar.Status is true);
            try
            {
                AccountBLL.ChangeStatus(ar.Username, status);
                btnRefresh_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAccount_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
