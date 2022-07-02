using System;
using System.Windows;
using BLL;

namespace GUI.Child.Dialog
{
    public partial class LoanBookWindow : Window
    {
        public LoanBookWindow(int bookID)
        {
            InitializeComponent();
            txtBookID.Text = bookID.ToString();
            cbxUsername_Load();
            cbxUsername.IsDropDownOpen = true;
        }

        private void cbxUsername_Load()
        {
            cbxUsername.ItemsSource = AccountBLL.GetUsernames();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string username = cbxUsername.Text;
            int bookID = int.Parse(txtBookID.Text);
            DateTime? loanDate = dtpLoanDate.SelectedDate;
            DateTime? dueDate = dtpDueDate.SelectedDate;

            try
            {
                LoanBLL.LoanBook(username, bookID, loanDate, dueDate);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }            
        }
    }
}
