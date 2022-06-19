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
using System.Windows.Shapes;
using System.Windows.Markup;
using BLL;
using DTO;

namespace GUI.Child.Dialog
{
    /// <summary>
    /// Interaction logic for LoanBookWindow.xaml
    /// </summary>
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
            cbxUsername.ItemsSource = AccountBLL.GetUsernameList();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoanBLL.LoanBook(cbxUsername.Text, Convert.ToInt32(txtBookID.Text), dtpLoanDate.Text, dtpDueDate.Text);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }            
        }
    }
}
