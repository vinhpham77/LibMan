using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using BLL;
using DTO;
using GUI.Child.Dialog;
using System.Windows.Input;

namespace GUI.Child
{
    public partial class AccountManPage : Page
    {
        private ObservableCollection<AccountRoleDTO> _data;

        public AccountManPage()
        {
            InitializeComponent();
            dtgAccount_Load();
        }

        private void dtgAccount_Load(string keywords = "")
        {
            dtgAccount.ItemsSource = _data = AccountRoleBLL.GetAccountRoles(keywords);
        }   
        
        private void txtAccountSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key is Key.Enter)
            {
                string keywords = txtAccountSearch.Text.Trim();
                dtgAccount_Load(keywords);
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtAccountSearch.Clear();
            dtgAccount_Load();
        }

        private void btnEditAccount_Click(object sender, RoutedEventArgs e)
        {
            var item = dtgAccount.SelectedItem as AccountRoleDTO;
            var acc = new UpdateAccountWindow(item);
            acc.ShowDialog();
        }

        private void btnDeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            var ar = dtgAccount.SelectedItem as AccountRoleDTO;
            string message = string.Format($"Bạn có chắc chắn muốn xoá tài khoản '{ar.Username}'" +
                                            " và tất cả dữ liệu liên quan không?");
            string title = "Xoá tài khoản";
            var result = MessageBox.Show(message, title, MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result is MessageBoxResult.Yes)
            {
                try
                {
                    AccountBLL.DeleteAccount(ar.Username);
                    _data.Remove(ar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            var ar = dtgAccount.SelectedItem as AccountRoleDTO;
            var change = new ChangePasswordWindow(ar.Username);
            change.ShowDialog();
        }

        private void btnChangeStatus_Click(object sender, RoutedEventArgs e)
        {
            string title = "Cấp quyền/Khoá";
            var ar = dtgAccount.SelectedItem as AccountRoleDTO;
            bool status = !(ar.Status is true);
            try
            {
                AccountBLL.ChangeStatus(ar.Username);
                int index = _data.IndexOf(ar);
                _data[index].Status = status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            var acc = new CreateAccountWindow();
            acc.ShowDialog();
        }
    }
}
