using System;
using System.Windows;
using System.Windows.Controls;
using BLL;
using DTO;

namespace GUI.Child.Dialog
{
    public partial class ReturnBookWindow : Window
    {
        public ReturnBookWindow()
        {
            InitializeComponent();
            cbxUsername_Load();
            cbxUsername.IsDropDownOpen = true;
        }

        public ReturnBookWindow(LoanReturnedBookDTO lr)
        {
            InitializeComponent();
            cbxUsername_Load();
            cbxUsername.SelectedItem = lr.Username;
            cbxLoanID.SelectedItem = lr.LoanID;
            dtpReturnDate.Focus();
            PreventSelectingItem();
            InformSomethingWrong();
        }

        private void InformSomethingWrong()
        {
            if (cbxUsername.SelectedItem is null || cbxLoanID.SelectedItem is null)
            {
                string message = "Phiên giao dịch này đã được thay đổi hoặc đã hoàn trả sách trước đó!";
                MessageBox.Show(message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PreventSelectingItem()
        {
            cbxUsername.IsEnabled = false;
            cbxLoanID.IsEnabled = false;
        }

        private void cbxUsername_Load()
        {
            cbxUsername.ItemsSource = LoanReturnedBookBLL.GetUsernamesNotReturned();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string username = cbxUsername.Text;
            string id = cbxLoanID.Text;
            string loan = txtLoanDate.Text;
            string due = txtDueDate.Text;
            string returned = dtpReturnDate.Text;
            try
            {
                string[] fields = {username, id, loan, due, returned};
                ReturnedBLL.Validate(fields);
                int loanID = Convert.ToInt32(fields[1]);
                DateTime loanDate = Convert.ToDateTime(fields[2]);
                DateTime dueDate = Convert.ToDateTime(fields[3]);
                DateTime returnedDate = Convert.ToDateTime(fields[4]);
                double fee = ReturnedBLL.GetFee(loanDate, dueDate, returnedDate);

                if (fee > 0)
                {
                    string feeVN = string.Format("{0:n0}đ", fee);
                    string message = string.Format($"Đồng ý thanh toán phí là {feeVN}");
                    string title = "Trả phí";
                    var result = MessageBox.Show(message, title, MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result is MessageBoxResult.Yes)
                    {
                        ReturnedBLL.CreateReturned(loanID, returnedDate, fee);
                        Close();
                    }
                }
                else
                {
                    ReturnedBLL.CreateReturned(loanID, returnedDate, fee);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cbxLoanID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var loanID = (int)cbxLoanID.SelectedItem;
            Loan loan = LoanBLL.GetLoan(loanID);
            txtBookID.Text = loan.BookID.ToString();
            txtLoanDate.Text = loan.LoanDate.ToShortDateString();
            txtDueDate.Text = loan.DueDate.ToShortDateString();
        }

        private void cbxUsername_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var username = cbxUsername.SelectedItem as string;
            cbxLoanID.ItemsSource = LoanReturnedBookBLL.GetLoanIDsNotReturned(username);
            txtBookID.Clear();
            txtLoanDate.Clear();
            txtDueDate.Clear();
        }
    }
}
