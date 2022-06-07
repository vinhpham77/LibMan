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
            BookManWindow addBook = new BookManWindow();
            addBook.ShowDialog();
        }

        private void btnEditBook_Click(object sender, RoutedEventArgs e)
        {
            BookDTO book = dtgBook.SelectedItem as BookDTO;
            
            if (book is null)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!", "Sửa sách", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                BookManWindow bookMan = new BookManWindow(book);
                bookMan.ShowDialog();
            }
        }
    }
}
