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
using BLL;
using DTO;

namespace GUI.Child.AddWindow
{
    /// <summary>
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class BookManWindow : Window
    {
        private readonly int _bookID;
        public BookManWindow()
        {
            InitializeComponent();
            Title = "Thêm sách";
        }

        public BookManWindow(BookDTO book)
        {
            InitializeComponent();
            Title = "Sửa sách";
            _bookID = book.ID;
            LoadTextElements(book);
        }

        public void LoadTextElements(BookDTO book)
        {
            txtTitle.Text = book.Title;
            txtCatalog.Text = book.Catalog;
            txtAuthor.Text = book.Author;
            txtPublisher.Text = book.Publisher;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            bool successful;

            if (Title.Equals("Thêm sách"))
            {
                successful = BookBLL.AddBook(txtTitle.Text, txtCatalog.Text, txtAuthor.Text, txtPublisher.Text);
            }
            else
            {
                successful = BookBLL.UpdateBook(_bookID, txtTitle.Text, txtCatalog.Text, txtAuthor.Text, txtPublisher.Text);
            }

            if (successful)
            {
                //BookLibrarianPage parent = (BookLibrarianPage)Parent;
                MessageBox.Show("Thành công!", Title, MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Thất bại, vui lòng điền đầy đủ thông tin!", Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
