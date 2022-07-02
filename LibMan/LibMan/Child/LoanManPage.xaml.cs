using System;
using System.Windows;
using System.Windows.Controls;
using BLL;
using GUI.Child.Dialog;
using DTO;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace GUI.Child
{
    public partial class LoanManPage : Page
    {
        private ObservableCollection<LoanReturnedBookDTO> _data;

        public LoanManPage()
        {
            InitializeComponent();
            dtgLoan_Load();
        }

        public void dtgLoan_Load(string keywords = "")
        {
            dtgLoan.ItemsSource = _data = LoanReturnedBookBLL.GetLoanReturneds(keywords);
        }

        private void txtLoanReturnSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key is Key.Enter)
            {
                string keywords = txtLoanReturnSearch.Text.Trim();
                dtgLoan_Load(keywords);
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtLoanReturnSearch.Clear();
            dtgLoan_Load();
        }

        private void btnReturnBook_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            ReturnBookWindow returnBook;

            if (btn.Name.Equals("btnReturnBook"))
            {
                returnBook = new ReturnBookWindow();
                returnBook.ShowDialog();
            }
            else
            {
                var lr = dtgLoan.SelectedItem as LoanReturnedBookDTO;

                if (lr.ReturnedDate is null)
                {
                    returnBook = new ReturnBookWindow(lr);
                    returnBook.ShowDialog();
                }
                else
                {
                    string message = string.Format($"Giao dịch mã '{lr.LoanID}' đã hoàn trả sách trước đó!");
                    string title = "Lập hoá đơn";
                    MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Stop);
                }
            }
        }

        private void btnDeleteLoan_Click(object sender, RoutedEventArgs e)
        {
            string title = "Xoá giao dịch";
            var lr = dtgLoan.SelectedItem as LoanReturnedBookDTO;
            string message = string.Format($"Bạn có chắc chắn muốn xoá giao dịch mã '{lr.LoanID}' không?");
            var result = MessageBox.Show(message, title, MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result is MessageBoxResult.Yes)
            {
                try
                {
                    LoanBLL.DeleteLoan(lr.LoanID);
                    _data.Remove(lr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
