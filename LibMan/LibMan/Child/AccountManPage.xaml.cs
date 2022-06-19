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
using GUI.Child.Dialog;

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

        private void dtgAccount_Load(string keywords = "")
        {
            dtgAccount.ItemsSource = AccountRoleBLL.GetAccountRoleList(keywords);
        }
        
        private void txtAccountSearch_TextChanged(object sender, TextChangedEventArgs e)
        {            
            dtgAccount_Load(txtAccountSearch.Text);
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtAccountSearch.TextChanged -= txtAccountSearch_TextChanged;
            txtAccountSearch.Clear();
            dtgAccount_Load();
            txtAccountSearch.TextChanged += txtAccountSearch_TextChanged;
        }

        private void btnEditAccount_Click(object sender, RoutedEventArgs e)
        {
            UpdateAccountWindow acc = new UpdateAccountWindow(dtgAccount.SelectedItem as AccountRoleDTO);
            acc.ShowDialog();
        }

        private void btnDeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            string title = "Xoá tài khoản";
            AccountRoleDTO ar = dtgAccount.SelectedItem as AccountRoleDTO;
            MessageBoxResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá tài khoản '{ar.Username}' và tất cả dữ liệu liên quan không?",
                                                title, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result is MessageBoxResult.Yes)
            {
                try
                {
                    AccountBLL.DeleteAccount(ar.Username);
                    dtgAccount_Load(txtAccountSearch.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
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
                dtgAccount_Load(txtAccountSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            CreateAccountWindow acc = new CreateAccountWindow();
            acc.ShowDialog();
        }
    }
}
