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
            dtgBook.ItemsSource = BookBLL.GetBookList(title);
        }

        private void txtBookSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dtgBook_Load(txtBookSearch.Text);
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            BookManWindow addBook = new BookManWindow(btnAddBook.Content.ToString());
            addBook.ShowDialog();
        }

        private void btnEditBook_Click(object sender, RoutedEventArgs e)
        {
            string title = btnEditBook.Content.ToString();
            if (!(dtgBook.SelectedItem is BookDTO book))
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!", title, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                BookManWindow bookMan = new BookManWindow(title, book);
                bookMan.ShowDialog();
            }
        }

        private void btnDeleteBook_Click(object sender, RoutedEventArgs e)
        {
            string title = btnDeleteBook.Content.ToString();
            if (!(dtgBook.SelectedItem is BookDTO book))
            {
                MessageBox.Show("Vui lòng chọn sách cần xoá!", title, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá sách '{book.Title}' không?", title, MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    bool successful = BookBLL.DeleteBook(book.ID);
                    if (successful)
                    {
                        MessageBox.Show("Thành công!", title, MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Thất bại, sách '{book.Title}' không tồn tại!", title, MessageBoxButton.OK, MessageBoxImage.Error);
                    }
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
            if (!(dtgBook.SelectedItem is BookDTO book))
            {
                MessageBox.Show("Vui lòng chọn sách cần cho mượn!", btnBorrowBook.Content.ToString(), MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                LoanBookWindow loan = new LoanBookWindow(btnBorrowBook.Content.ToString(), book.ID);
                loan.ShowDialog();
            }
        }

        private void btnReturnBook_Click(object sender, RoutedEventArgs e)
        {
            ReturnBookWindow returnBook = new ReturnBookWindow(btnReturnBook.Content.ToString());
            returnBook.ShowDialog();
        }
    }
}
