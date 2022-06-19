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
using GUI.Child.Dialog;
using DTO;

namespace GUI.Child
{
    /// <summary>
    /// Interaction logic for LoanManPage.xaml
    /// </summary>
    public partial class LoanManPage : Page
    {
        public LoanManPage()
        {
            InitializeComponent();
            dtgLoan_Load();
        }

        public void dtgLoan_Load(string keywords = "")
        {
            dtgLoan.ItemsSource = LoanReturnedBookBLL.GetLoanReturnedList(keywords);
        }

        private void btnReturnBook_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
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
                    MessageBox.Show($"Giao dịch mã '{lr.LoanID}' đã hoàn trả sách trước đó!",
                                    "Lập hoá đơn", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
            }
        }

        private void btnDeleteLoan_Click(object sender, RoutedEventArgs e)
        {
            string title = "Xoá giao dịch";
            LoanReturnedBookDTO lr = dtgLoan.SelectedItem as LoanReturnedBookDTO;
            MessageBoxResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá giao dịch mã '{lr.LoanID}' không?", title,
                                            MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result is MessageBoxResult.Yes)
            {
                try
                {
                    LoanBLL.DeleteLoan(lr.LoanID);
                    dtgLoan_Load(txtLoanReturnSearch.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void txtLoanReturnSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dtgLoan_Load(txtLoanReturnSearch.Text);
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtLoanReturnSearch.TextChanged -= txtLoanReturnSearch_TextChanged;
            txtLoanReturnSearch.Clear();
            dtgLoan_Load();
            txtLoanReturnSearch.TextChanged += txtLoanReturnSearch_TextChanged;
        }
    }
}
