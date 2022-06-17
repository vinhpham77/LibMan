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
using GUI.Child.AddWindow;
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

        public void dtgLoan_Load(string username = "")
        {
            dtgLoan.ItemsSource = LoanReturnedBLL.GetLoanReturnedList(username);
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
                LoanReturnedDTO lr = dtgLoan.SelectedItem as LoanReturnedDTO;
                if (lr.ReturnedDate is null)
                {
                    returnBook = new ReturnBookWindow(dtgLoan.SelectedItem as LoanReturnedDTO);
                    returnBook.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Dịch vụ mã '{lr.LoanID}' đã hoàn trả sách trước đó!",
                                    "Lập hoá đơn", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
            }
        }

        private void btnDeleteLoan_Click(object sender, RoutedEventArgs e)
        {
            LoanReturnedDTO lr = dtgLoan.SelectedItem as LoanReturnedDTO;
            MessageBoxResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá dịch vụ mã '{lr.LoanID}' không?", "Xoá dịch vụ", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    LoanReturnedBLL.DeleteLoanReturned(lr.LoanID);
                    btnRefresh_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Xoá dịch vụ", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnEditLoan_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtLoanReturnSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dtgLoan_Load(txtLoanReturnSearch.Text);
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            dtgLoan_Load();
            txtLoanReturnSearch.Clear();
        }

        private void txtLoanReturnSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
