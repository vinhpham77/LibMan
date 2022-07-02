using System;
using System.Windows;
using System.Windows.Controls;
using BLL;
using GUI.Child.Dialog;
using DTO;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace GUI.Child
{
    public partial class BookManPage : Page
    {
        private ObservableCollection<BookCatalogDTO> _data;

        public BookManPage()
        {
            InitializeComponent();
            dtgBook_Load();
        }

        private void dtgBook_Load(string keywords = "")
        {
            dtgBook.ItemsSource = _data = BookCatalogBLL.GetBookCatalogs(keywords);
        }

        private void txtBookSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key is Key.Enter)
            {
                string keywords = txtBookSearch.Text.Trim();
                dtgBook_Load(keywords);
            }
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            var addBook = new BookManWindow();
            addBook.ShowDialog();
        }

        private void btnEditBook_Click(object sender, RoutedEventArgs e)
        {
            var item = dtgBook.SelectedItem as BookCatalogDTO;
            var bookMan = new BookManWindow(item);
            bookMan.ShowDialog();
        }

        private void btnDeleteBook_Click(object sender, RoutedEventArgs e)
        {
            string title = "Xoá sách";
            var bc = dtgBook.SelectedItem as BookCatalogDTO;
            string message = string.Format($"Bạn có chắc chắn muốn xoá sách mã '{bc.BookID}'" +
                                            " và toàn bộ dữ liệu liên quan không?");
            var result = MessageBox.Show(message, title, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            
            if (result is MessageBoxResult.Yes)
            {
                try
                {
                    BookBLL.DeleteBook(bc.BookID);
                    _data.Remove(bc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtBookSearch.Clear();
            dtgBook_Load();
        }

        private void btnLendBook_Click(object sender, RoutedEventArgs e)
        {
            var bc = dtgBook.SelectedItem as BookCatalogDTO;
            var loan = new LoanBookWindow(bc.BookID);
            loan.ShowDialog();
        }
    }
}
