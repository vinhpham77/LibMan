using System;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BLL;
using DTO;

namespace GUI.Child.Dialog
{
    /// <summary>
    /// Interaction logic for ReturnBookWindow.xaml
    /// </summary>
    public partial class ReturnBookWindow : Window
    {
        public ReturnBookWindow()
        {
            InitializeComponent();
            cbxUsername_Load();
        }

        public ReturnBookWindow(LoanReturnedBookDTO lr)
        {
            InitializeComponent();
            cbxUsername_Load();
            cbxUsername.SelectedItem = lr.Username;
            cbxLoanID.SelectedItem = lr.LoanID;
            dtpReturnDate.Focus();
            PreventEditingFields();
            InformSomethingWrong();
        }

        private void InformSomethingWrong()
        {
            if (cbxUsername.SelectedItem is null || cbxLoanID.SelectedItem is null)
            {
                MessageBox.Show("Thông tin phiên giao dịch này đã được thay đổi hoặc đã hoàn trả sách trước đó!",
                                Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PreventEditingFields()
        {
            cbxUsername.IsEnabled = false;
            cbxLoanID.IsEnabled = false;    
            txtBookID.IsEnabled = false;
            txtDueDate.IsEnabled = false;
            txtLoanDate.IsEnabled = false;
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
            try
            {
                Hashtable fields = ReturnedBLL.Validate(cbxUsername.Text, cbxLoanID.Text, txtLoanDate.Text, txtDueDate.Text, dtpReturnDate.SelectedDate);
                int loanID = Convert.ToInt32(fields["loanID"]);
                DateTime loanDate = Convert.ToDateTime(fields["loanDate"]);
                DateTime dueDate = Convert.ToDateTime(fields["dueDate"]);
                DateTime returnedDate = Convert.ToDateTime(fields["returnedDate"]);
                double fee = ReturnedBLL.GetFee(loanDate, dueDate, returnedDate);
                if (fee > 0)
                {
                    string feeVN = string.Format("{0:n0}đ", fee);
                    MessageBoxResult result = MessageBox.Show($"Đồng ý thanh toán phí là {feeVN}", "Thanh toán", MessageBoxButton.YesNo, MessageBoxImage.Question);
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
            Loan loan = LoanBLL.GetLoan(Convert.ToInt32(cbxLoanID.SelectedItem));
            txtBookID.Text = loan.BookID.ToString();
            txtLoanDate.Text = loan.LoanDate.ToShortDateString();
            txtDueDate.Text = loan.DueDate.ToShortDateString();
        }

        private void cbxUsername_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbxLoanID.ItemsSource = LoanReturnedBookBLL.GetLoanIDsNotReturned(cbxUsername.SelectedItem as string);
            txtBookID.Clear();
            txtLoanDate.Clear();
            txtDueDate.Clear();
        }
    }
}
