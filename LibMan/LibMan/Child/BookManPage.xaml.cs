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
    /// Interaction logic for BookLibrarianPage.xaml
    /// </summary>
    public partial class BookManPage : Page
    {
        public BookManPage()
        {
            InitializeComponent();
            dtgBook_Load();
        }

        private void dtgBook_Load(string title = "")
        {
            dtgBook.ItemsSource = BookCatalogBLL.GetBookCatalogList(title);
        }

        private void txtBookSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dtgBook_Load(txtBookSearch.Text);
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            BookManWindow addBook = new BookManWindow();
            addBook.ShowDialog();
        }

        private void btnEditBook_Click(object sender, RoutedEventArgs e)
        {
            BookManWindow bookMan = new BookManWindow(dtgBook.SelectedItem as BookCatalogDTO);
            bookMan.ShowDialog();
        }

        private void btnDeleteBook_Click(object sender, RoutedEventArgs e)
        {
            string title = "Xoá sách";
            BookCatalogDTO bc = dtgBook.SelectedItem as BookCatalogDTO;
            MessageBoxResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá sách mã '{bc.BookID}' và toàn bộ dữ liệu liên quan không?",
                                        title, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result is MessageBoxResult.Yes)
            {
                try
                {
                    BookBLL.DeleteBook(bc.BookID);
                    dtgBook_Load(txtBookSearch.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtBookSearch.TextChanged -= txtBookSearch_TextChanged;
            txtBookSearch.Clear();
            dtgBook_Load();
            txtBookSearch.TextChanged += txtBookSearch_TextChanged;
        }

        private void btnBorrowBook_Click(object sender, RoutedEventArgs e)
        {
            BookCatalogDTO bc = dtgBook.SelectedItem as BookCatalogDTO;
            LoanBookWindow loan = new LoanBookWindow(bc.BookID);
            loan.ShowDialog();
        }

        private void btnReturnBook_Click(object sender, RoutedEventArgs e)
        {
            ReturnBookWindow returnBook = new ReturnBookWindow();
            returnBook.ShowDialog();
        }
    }
}
