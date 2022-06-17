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
    /// Interaction logic for BookLibrarianPage.xaml
    /// </summary>
    public partial class BookLibrarianPage : Page
    {
        public BookLibrarianPage()
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
            MessageBoxResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá sách mã '{bc.BookID}' không?", title, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                bool successful;
                try
                {
                    BookBLL.DeleteBook(bc.BookID);
                    successful = true;
                }
                catch (Exception ex)
                {
                    successful = false;
                    MessageBox.Show(ex.Message, title, MessageBoxButton.OK, MessageBoxImage.Error);
                }

                if (successful)
                {
                    btnRefresh_Click(null, null);
                }
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            dtgBook_Load();
            txtBookSearch.Clear();
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
