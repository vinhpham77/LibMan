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

namespace GUI.Child.AddWindow
{
    /// <summary>
    /// Interaction logic for LoanBookWindow.xaml
    /// </summary>
    public partial class LoanBookWindow : Window
    {
        private readonly int _bookID;
        public LoanBookWindow(string title, int bookID)
        {
            InitializeComponent();
            _bookID = bookID;
            Title = title;
            cbxUsername_Load();
            dtpLoanDate.Language = XmlLanguage.GetLanguage("vi-VN");
            dtpDueDate.Language = XmlLanguage.GetLanguage("vi-VN");
            dtpLoanDate.SelectedDate = DateTime.Now;
            
        }

        private void cbxUsername_Load()
        {
            cbxUsername.ItemsSource = AccountBLL.GetAccountList("", true);
            cbxUsername.DisplayMemberPath = "Username";
            cbxUsername.SelectedValuePath = "Username";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string error = LoanBLL.LoanBook(cbxUsername.Text, _bookID, dtpLoanDate.Text, dtpDueDate.Text);
            if (error is null)
            {
                MessageBox.Show("Thành công!", Title, MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            else
            {
                MessageBox.Show($"Thất bại! {error}", Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
