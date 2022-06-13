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

namespace GUI.Child.AddWindow
{
    /// <summary>
    /// Interaction logic for ReturnBookWindow.xaml
    /// </summary>
    public partial class ReturnBookWindow : Window
    {
        public ReturnBookWindow(string title)
        {
            InitializeComponent();
            Title = title;
            cbxUsername_Load();
//            dtpReturnDate.Language = XmlLanguage.GetLanguage("vi-VN");
            dtpReturnDate.SelectedDate = DateTime.Now;
        }

        private void cbxUsername_Load()
        {
            cbxUsername.ItemsSource = LoanReturnedBLL.GetNotReturnedList();
            cbxUsername.DisplayMemberPath = "Username";
            cbxUsername.SelectedValuePath = "Username";
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
                    string feeVN = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", fee);
                    MessageBoxResult result = MessageBox.Show($"Đồng ý thanh toán phí là {feeVN}đ", "Thanh toán", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        ReturnedBLL.CreateReturned(loanID, returnedDate, fee);
                    }
                }
                else
                {
                    ReturnedBLL.CreateReturned(loanID, returnedDate, fee);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cbxUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            cbxLoanID.ItemsSource = LoanBLL.GetLoanList(cbxUsername.Text);
            txtLoanDate.Clear();
            txtDueDate.Clear();
        }

        private void cbxLoanID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxLoanID.SelectedValue is LoanDTO loanDTO)
            {
                int loanID = loanDTO.ID;
                Loan loan = LoanBLL.GetLoan(loanID);

                txtLoanDate.Text = loan.LoanDate.ToString("dd/MM/yyyy");
                txtDueDate.Text = loan.DueDate.ToString("dd/MM/yyyy");
            }
        }
    }
}
